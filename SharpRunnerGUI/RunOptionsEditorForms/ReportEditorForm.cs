using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TestRunnerGUI.Controllers;
using TestRunnerGUI.Utilities;
using TestRunnerGUI.Utilities.Enums;

namespace TestRunnerGUI.RunOptionsEditorForms
{
    public partial class ReportEditorForm : Form
    {

        #region Fields

        private Dictionary<RunOptionsEnums, string> editReportRunOptionsDictionary = new Dictionary<RunOptionsEnums, string>();

        #endregion

        #region ctor

        public ReportEditorForm( )
        {
            InitializeComponent( );

            reportOptionsSuccessfulEditedLabel.Text = string.Empty;

            ButtonControl buttonControls = new ButtonControl( );

            reportOutputPathSetterButton.MouseEnter += buttonControls.controlButtons_MouseEnter;
            reportOutputPathSetterButton.MouseLeave += buttonControls.controlButtons_MouseLeave;
            saveReportOptionsButton.MouseEnter += buttonControls.controlButtons_MouseEnter;
            saveReportOptionsButton.MouseLeave += buttonControls.controlButtons_MouseLeave;
        }

        public ReportEditorForm( Dictionary<RunOptionsEnums, string> editReportRunOptionsDictionary )
            : this()
        {
            this.editReportRunOptionsDictionary = editReportRunOptionsDictionary;

            if ( this.editReportRunOptionsDictionary != null )
            {
                DataLoadHandlers loadDataHandler = new DataLoadHandlers( );

                loadDataHandler.SetReportOutputFolderPath( reportOutputPathTextBox, this.editReportRunOptionsDictionary );
                loadDataHandler.SetTextReportName( textReportFileName, this.editReportRunOptionsDictionary );
                loadDataHandler.SetXmlOptions( xmlReportFileName, nunitTwoStyleRadioButton, nunitThreeStyleRadioButton, this.editReportRunOptionsDictionary );
            }
        }

        #endregion

        #region Event handlers

        private void reportOutputPathSetterButton_Click( object sender, EventArgs e )
        {
            FolderBrowserDialog reportPathSetterFolderBrowser = new FolderBrowserDialog( );
            DialogResult folderSelectResult = reportPathSetterFolderBrowser.ShowDialog( );

            if ( folderSelectResult == DialogResult.OK )
            {
                reportOutputPathTextBox.Text = reportPathSetterFolderBrowser.SelectedPath;
            }
        }

        private void saveReportOptionsButton_Click( object sender, EventArgs e )
        {
            DictionaryManipulators handleRunOptionsDictionary = new DictionaryManipulators( );

            string reportOutputPathTextBoxText = reportOutputPathTextBox.Text;

            bool reportOutputPathChanged = handleRunOptionsDictionary.AddToDictionary( RunOptionsEnums.ReportFolderPath, reportOutputPathTextBoxText, editReportRunOptionsDictionary );

            string textReportFileNameText = textReportFileName.Text;

            bool textReportNameChanged = handleRunOptionsDictionary.AddToDictionary( RunOptionsEnums.TextReportFileName, textReportFileNameText, editReportRunOptionsDictionary );

            string xmlReportFileNameText = xmlReportFileName.Text;

            bool xmlReportNameChanged = handleRunOptionsDictionary.AddToDictionary( RunOptionsEnums.XmlReportFileName, xmlReportFileNameText, editReportRunOptionsDictionary );

            bool isNunitTwoStyleRadioButtonChecked = nunitTwoStyleRadioButton.Checked;

            bool isNunitThreeStyleRadioButtonChecked = nunitThreeStyleRadioButton.Checked;

            bool xmlReportStyleChanged = false;

            if( isNunitTwoStyleRadioButtonChecked )
            {
                xmlReportStyleChanged = handleRunOptionsDictionary.AddToDictionary( RunOptionsEnums.XmlNunitStyle, "nunit2", editReportRunOptionsDictionary );
            }
            else if( isNunitThreeStyleRadioButtonChecked )
            {
                xmlReportStyleChanged = handleRunOptionsDictionary.AddToDictionary( RunOptionsEnums.XmlNunitStyle, "nunit3", editReportRunOptionsDictionary );
            }

            Queue<string> labelMessageQueue = new Queue<string>( );
            labelMessageQueue.Enqueue( "Report options changed:" );

            if( textReportNameChanged )
            {
                labelMessageQueue.Enqueue( " text report name" );
            }

            if( reportOutputPathChanged )
            {
                labelMessageQueue.Enqueue( " report output folder" );
            }

            if( xmlReportNameChanged )
            {
                labelMessageQueue.Enqueue( " xml report name" );
            }

            if( xmlReportStyleChanged )
            {
                labelMessageQueue.Enqueue( " xml report style options" );
            }

            StringBuilder stringBuilder = new StringBuilder( );

            int labelMessageQueueCount = labelMessageQueue.Count;

            if( labelMessageQueueCount < 3 )
            {
                reportOptionsSuccessfulEditedLabel.Location = new Point( 217, 466 );
            }
            else if ( labelMessageQueueCount == 3 )
            {
                reportOptionsSuccessfulEditedLabel.Location = new Point( 170, 466 );
            }
            else
            {
                reportOptionsSuccessfulEditedLabel.Location = new Point( 140, 466 );
            }

            for( int i = 0; i < labelMessageQueueCount; ++i )
            {
                if( i == 0 || i == labelMessageQueueCount - 1 )
                {
                    stringBuilder.Append( labelMessageQueue.Dequeue() );
                }
                else
                {
                    stringBuilder.Append( labelMessageQueue.Dequeue( ) );
                    stringBuilder.Append( "," );
                }
            }

            string labelMessage = stringBuilder.ToString( );

            reportOptionsSuccessfulEditedLabel.Text = labelMessage;

            EditRunOptionsBase editReportRunOptionsBase = new EditRunOptionsBase( true );

            editReportRunOptionsBase.EditFormRunOptionsDictionary = editReportRunOptionsDictionary;
        }

        #endregion

        
    }
}
