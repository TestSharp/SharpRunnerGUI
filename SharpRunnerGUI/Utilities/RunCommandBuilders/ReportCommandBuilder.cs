using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using TestRunnerGUI.Utilities.Enums;

namespace TestRunnerGUI.Utilities.RunCommandBuilders
{
    public class ReportCommandBuilder
    {
        #region ctor

        public ReportCommandBuilder( CheckBox produceXmlReport, CheckBox produceTextReport, Dictionary<RunOptionsEnums, string> testRunnerRunOptionsDictionary )
        {
            this.produceXmlReport = produceXmlReport;
            this.produceTextReport = produceTextReport;
            this.testRunnerRunOptionsDictionary = new Dictionary<RunOptionsEnums, string>( );
            this.testRunnerRunOptionsDictionary = testRunnerRunOptionsDictionary;
        }

        #endregion

        #region Fields

        private readonly CheckBox produceXmlReport;
        private readonly CheckBox produceTextReport;
        private readonly Dictionary<RunOptionsEnums, string> testRunnerRunOptionsDictionary;

        #endregion

        #region Helper methods

        private DialogResult UnsetValuesMessageGenerator( string defaultTestName, string defaultReportStyle, string type,
            bool hasReportName, bool hasReportStyle )
        {
            List<string> messageList = new List<string>( );

            if ( !hasReportName )
            {
                messageList.Add( $"{type} report name is not set. Default value: {defaultTestName}" );
            }

            if ( !hasReportStyle )
            {
                messageList.Add( $"{type} report style is not set. Default value: {defaultReportStyle}" );
            }

            StringBuilder messageBuilder = new StringBuilder( );
            messageBuilder.Append( "Some values were not set. If you click on 'Yes' the default values will be used." );
            messageBuilder.Append( Environment.NewLine );
            messageBuilder.Append( "If you click 'No', you'll return to the app, and you'll be able to set the values" );

            if ( messageList.Count != 0 )
            {
                messageBuilder.Append( Environment.NewLine );

                foreach( string messageAppendage in messageList )
                {
                    messageBuilder.Append( messageAppendage );
                    messageBuilder.Append( Environment.NewLine );
                }
            }

            string message = messageBuilder.ToString( );

            DialogResult result = MessageBox.Show( message, "Some values are missing", MessageBoxButtons.YesNo );

            return result;
        }

        private DialogResult UnsetValuesMessageGenerator( string defaultTestName, string type, bool hasReportName )
        {
            List<string> messageList = new List<string>( );

            if ( !hasReportName )
            {
                messageList.Add( $"{type} report name is not set. Default value: {defaultTestName}" );
            }

            StringBuilder messageBuilder = new StringBuilder( );
            messageBuilder.Append( "Some values were not set. If you click on 'Yes' the default values will be used." );
            messageBuilder.Append( Environment.NewLine );
            messageBuilder.Append( "If you click 'No', you'll return to the app, and you'll be able to set the values" );

            if ( messageList.Count != 0 )
            {
                messageBuilder.Append( Environment.NewLine );

                foreach( string messageAppendage in messageList )
                {
                    messageBuilder.Append( messageAppendage );
                    messageBuilder.Append( Environment.NewLine );
                }
            }

            string message = messageBuilder.ToString( );

            DialogResult result = MessageBox.Show( message, "Some values are missing", MessageBoxButtons.YesNo );

            return result;
        }

        private string SetXmlReportCommandString( bool hasXmlFileName, string defaultTestName, bool hasXmlNunitStyle )
        {
            string xmlName = !hasXmlFileName ? defaultTestName : testRunnerRunOptionsDictionary[ RunOptionsEnums.XmlReportFileName ];
            string xmlStyle = !hasXmlNunitStyle ? ";format=nunit2" : string.Empty;

            return $"--result={xmlName}{xmlStyle}";
        }

        #endregion

        #region Text and XML report command builder methods

        private string SetXmlReportCommand()
        {
            bool hasXmlFileName     = testRunnerRunOptionsDictionary.ContainsKey( RunOptionsEnums.XmlReportFileName );
            bool hasXmlNunitStyle   = testRunnerRunOptionsDictionary.ContainsKey( RunOptionsEnums.XmlNunitStyle );

            string defaultTestName;
            string reportCommand;

            if( !hasXmlFileName || !hasXmlNunitStyle )
            {
                defaultTestName = "XMLReport.xml";

                string defaultXmlStyle = "NUnit2";

                DialogResult result = UnsetValuesMessageGenerator(
                    defaultTestName, defaultXmlStyle, "XML", hasXmlFileName, hasXmlNunitStyle );

                if( result == DialogResult.Yes )
                {
                    reportCommand = SetXmlReportCommandString( hasXmlFileName, defaultTestName, hasXmlNunitStyle );
                }
                else
                {
                    return null;
                }
            }
            else
            {
                string xmlStyle = testRunnerRunOptionsDictionary[ RunOptionsEnums.XmlNunitStyle ] == "nunit2" ? ";format=nunit2" : string.Empty;

                string xmlReportName = testRunnerRunOptionsDictionary[ RunOptionsEnums.XmlReportFileName ];

                if( !xmlReportName.EndsWith( ".xml" ) )
                {
                    xmlReportName += ".xml";
                }

                reportCommand = $@" ""--result={xmlReportName}{xmlStyle}""";
            }

            return reportCommand;
        }

        private string SetTextReportCommand()
        {
            bool hasTextFileName = testRunnerRunOptionsDictionary.ContainsKey( RunOptionsEnums.TextReportFileName );

            string reportCommand;

            if( !hasTextFileName )
            {
                string defaultTestName = "TextReport.txt";

                DialogResult result = UnsetValuesMessageGenerator( defaultTestName, "Text", hasTextFileName );

                if( result == DialogResult.Yes )
                {
                    reportCommand = $" --out={defaultTestName}";
                }
                else
                {
                    return null;
                }
            }
            else
            {
                string textReportName = testRunnerRunOptionsDictionary[ RunOptionsEnums.TextReportFileName ];

                if( !textReportName.EndsWith( ".txt" ) )
                {
                    textReportName += ".txt";
                }

                reportCommand = $" --out={textReportName}";
            }

            return reportCommand;
        }

        #endregion

        public string BuildReportCommand()
        {
            string reportCommand = null;

            if ( !produceXmlReport.Checked && !produceTextReport.Checked )
            {
                reportCommand = "--noresult";
            }
            else
            {
                if( testRunnerRunOptionsDictionary.ContainsKey( RunOptionsEnums.ReportFolderPath ) )
                {
                    reportCommand = $@" --work=""{testRunnerRunOptionsDictionary[ RunOptionsEnums.ReportFolderPath ]}""";
                }

                if ( produceXmlReport.Checked && produceTextReport.Checked )
                {
                    string xmlCommand = SetXmlReportCommand( );
                    string textCommand = SetTextReportCommand( );

                    if ( string.IsNullOrEmpty( xmlCommand ) || string.IsNullOrEmpty( textCommand ) )
                    {
                        return null;
                    }

                    reportCommand += $"{textCommand} {xmlCommand}";
                }
                else if ( produceXmlReport.Checked )
                {
                    reportCommand += SetXmlReportCommand( );
                }
                else if ( produceTextReport.Checked )
                {
                    reportCommand += SetTextReportCommand( );
                }

            }

            if ( string.IsNullOrEmpty( reportCommand ) )
            {
                return null;
            }
            else
            {
                return reportCommand;
            }
        }

    }
}
