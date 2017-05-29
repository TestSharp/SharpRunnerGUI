using System.Collections.Generic;
using System.Windows.Forms;
using TestRunnerGUI.Utilities.Enums;

namespace TestRunnerGUI
{
    public class SetOptions
    {

        public void SetWorkerInputs( NumericUpDown maxNumberOfWorkersNumericSetter, NumericUpDown defaultNumberOfWorkersNumericSetter, Dictionary<RunOptionsEnums, string> runOptionsDictionary )
        {
            if ( runOptionsDictionary.ContainsKey( RunOptionsEnums.WorkersMaximumNumber ) )
                {
                    decimal maxWorkersNumber;

                    bool successfullyParsedMaxWorkerNum = decimal.TryParse( runOptionsDictionary[ RunOptionsEnums.WorkersMaximumNumber ], out maxWorkersNumber );

                    if ( successfullyParsedMaxWorkerNum )
                    {
                        maxNumberOfWorkersNumericSetter.Value = maxWorkersNumber;
                    }
                }

                if ( runOptionsDictionary.ContainsKey( RunOptionsEnums.WorkersDefaultNumber ) )
                {
                    decimal defaultWorkersNumber;

                    bool successfullyParsedDefaultWorkerNum = decimal.TryParse( runOptionsDictionary[ RunOptionsEnums.WorkersDefaultNumber ], out defaultWorkersNumber );

                    if ( successfullyParsedDefaultWorkerNum )
                    {
                        defaultNumberOfWorkersNumericSetter.Value = defaultWorkersNumber;
                    }
                }
        }

        public void SetWorkerOptions( NumericUpDown workersNumericSetter, Dictionary<RunOptionsEnums, string> runOptionsDictionary )
        {
            if ( runOptionsDictionary.ContainsKey( RunOptionsEnums.WorkersMaximumNumber ) )
                {
                    decimal maxWorkersNumber;

                    bool successfullyParsedMaxWorkerNum = decimal.TryParse( runOptionsDictionary[ RunOptionsEnums.WorkersMaximumNumber ], out maxWorkersNumber );

                    if ( successfullyParsedMaxWorkerNum )
                    {
                        workersNumericSetter.Maximum = maxWorkersNumber;
                    }
                }

                if ( runOptionsDictionary.ContainsKey( RunOptionsEnums.WorkersDefaultNumber ) )
                {
                    decimal defaultWorkersNumber;

                    bool successfullyParsedDefaultWorkerNum = decimal.TryParse( runOptionsDictionary[ RunOptionsEnums.WorkersDefaultNumber ], out defaultWorkersNumber );

                    if ( successfullyParsedDefaultWorkerNum )
                    {
                        workersNumericSetter.Value = defaultWorkersNumber;
                    }
                }
        }

        public void SetDefaultBrowser( ComboBox browserSelector, Dictionary<RunOptionsEnums, string> runOptionsDictionary )
        {
            if ( runOptionsDictionary.ContainsKey( RunOptionsEnums.DefaultBrowser ) )
            {
                string defaultBrowser = runOptionsDictionary[ RunOptionsEnums.DefaultBrowser ];

                browserSelector.SelectedIndex = browserSelector.FindStringExact( defaultBrowser );
            }
        }

        public void PopulateBrowserDropdown( ComboBox dropdown, List<string> browserList )
        {
            if ( browserList != null && browserList.Count != 0 )
            {
                dropdown.Items.Clear( );

                foreach( string currentBrowser in browserList )
                {
                    dropdown.Items.Add( currentBrowser );
                }
            }
        }

        public void SetTextReportName( TextBox fileNameTextBox, Dictionary<RunOptionsEnums, string> runOptionsDictionary )
        {
            if ( runOptionsDictionary.ContainsKey( RunOptionsEnums.TextReportFileName ) )
            {
                fileNameTextBox.Text = runOptionsDictionary[ RunOptionsEnums.TextReportFileName ];
            }
        }

        public void SetReportFolderPath( TextBox pathFolderTextBox, Dictionary<RunOptionsEnums, string> runOptionsDictionary )
        {
            if ( runOptionsDictionary.ContainsKey( RunOptionsEnums.ReportFolderPath ) )
            {
                pathFolderTextBox.Text = runOptionsDictionary[ RunOptionsEnums.ReportFolderPath ];
            }
        }

        public void SetBuilderRunnerPath( TextBox MsBuildPathTextBox, TextBox NunitPathTextBox, Dictionary<RunOptionsEnums, string> runOptionsDictionary )
        {
            if ( runOptionsDictionary.ContainsKey( RunOptionsEnums.MsBuildPath ) )
            {
                MsBuildPathTextBox.Text = runOptionsDictionary[ RunOptionsEnums.MsBuildPath ];
            }

            if ( runOptionsDictionary.ContainsKey( RunOptionsEnums.NunitPath ) )
            {
                NunitPathTextBox.Text = runOptionsDictionary[ RunOptionsEnums.NunitPath ];
            }
        }

        public void SetXmlReportNameAndStyle( TextBox xmlName, RadioButton nunitTwo, RadioButton nunitThree, Dictionary<RunOptionsEnums, string> runOptionsDictionary )
        {
            if ( runOptionsDictionary.ContainsKey( RunOptionsEnums.XmlReportFileName ) )
            {
                xmlName.Text = runOptionsDictionary[ RunOptionsEnums.XmlReportFileName ];
            }

            if ( runOptionsDictionary.ContainsKey( RunOptionsEnums.XmlNunitStyle ) )
            {
                string currentXmlNunitStyle = runOptionsDictionary[ RunOptionsEnums.XmlNunitStyle ];

                switch ( currentXmlNunitStyle )
                {
                    case "nunit3":
                        nunitTwo.Checked = false;
                        nunitThree.Checked = true;
                        break;
                    default:
                        nunitTwo.Checked = true;
                        nunitThree.Checked = false;
                        break;
                }
            }
        }

    }
}
