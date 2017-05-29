using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TestRunnerGUI.Controllers;
using TestRunnerGUI.Utilities;
using TestRunnerGUI.Utilities.Enums;

namespace TestRunnerGUI.RunOptionsEditorForms
{
    public partial class GeneralSettingsForm : Form
    {

        #region Fields

        private Dictionary<RunOptionsEnums, string> generalSettingsRunOptionsDictionary = new Dictionary<RunOptionsEnums, string>();
        

        #endregion

        #region ctor

        public GeneralSettingsForm( )
        {
            InitializeComponent( );

            nunitPathChangeMessageLabel1.Text   = string.Empty;
            nunitPathChangeMessageLabel2.Text   = string.Empty;
            msBuildPathChangeMessageLabel1.Text = string.Empty;
            msBuildPathChangeMessageLabel2.Text = string.Empty;

            ButtonControl buttonControls = new ButtonControl( );

            selectMsBuildPathButton.MouseEnter += buttonControls.controlButtons_MouseEnter;
            selectMsBuildPathButton.MouseLeave += buttonControls.controlButtons_MouseLeave;
            selectNunitPathButton.MouseEnter += buttonControls.controlButtons_MouseEnter;
            selectNunitPathButton.MouseLeave += buttonControls.controlButtons_MouseLeave;
            saveGeneralSettingsButton.MouseEnter += buttonControls.controlButtons_MouseEnter;
            saveGeneralSettingsButton.MouseLeave += buttonControls.controlButtons_MouseLeave;
        }

        public GeneralSettingsForm( Dictionary<RunOptionsEnums, string> generalSettingsRunOptionsDictionary )
            : this()
        {
            this.generalSettingsRunOptionsDictionary = generalSettingsRunOptionsDictionary;

            if ( this.generalSettingsRunOptionsDictionary != null )
            {
                DataLoadHandlers loadDataHandler = new DataLoadHandlers( );

                loadDataHandler.SetMsbuildNunitPaths( msBuildPathTextBox, nunitPathTextBox, this.generalSettingsRunOptionsDictionary );
            }
        }

        #endregion

        #region Helper methods

        private void SetLabelPosition( TextBox currentTextBox, Label currentLabel, int height )
        {
            string currentPathText = currentTextBox.Text;

            if ( currentLabel != null )
            {

                if ( currentPathText.Length > 70 )
                {
                    currentLabel.Location = new Point( 40, height );
                }
                else if ( currentPathText.Length > 60 )
                {
                    currentLabel.Location = new Point( 80, height );
                }
                else if ( currentPathText.Length > 50 )
                {
                    currentLabel.Location = new Point( 110, height );
                }
                else if ( currentPathText.Length > 40 )
                {
                    currentLabel.Location = new Point( 160, height );
                }
                else if ( currentPathText.Length > 30 )
                {
                    currentLabel.Location = new Point( 200, height );
                }
                else if ( currentPathText.Length > 22 )
                {
                    currentLabel.Location = new Point( 240, height );
                }
                else if ( currentPathText.Length > 12 )
                {
                    currentLabel.Location = new Point( 260, height );
                }
                else
                {
                    currentLabel.Location = new Point( 280, height );
                }
            }
        }

        #endregion

        #region Event handlers

        private void selectMsBuildPathButton_Click( object sender, EventArgs e )
        {
            OpenFileDialog fileExplorer = new OpenFileDialog( );

            DialogResult result = fileExplorer.ShowDialog( );

            if ( result == DialogResult.OK )
            {
                string filePath = fileExplorer.FileName;

                msBuildPathTextBox.Text = $"{filePath}";

                msBuildPathTextBox.ReadOnly = true;
                msBuildPathTextBox.Cursor = Cursors.Arrow;
            }
        }

        private void selectNunitPathButton_Click( object sender, EventArgs e )
        {
            OpenFileDialog fileExplorer = new OpenFileDialog( );

            DialogResult result = fileExplorer.ShowDialog( );

            if ( result == DialogResult.OK )
            {
                string filePath = fileExplorer.FileName;

                nunitPathTextBox.Text = $"{filePath}";

                nunitPathTextBox.ReadOnly = true;
                nunitPathTextBox.Cursor = Cursors.Arrow;
            }
        }

        private void msBuildPathTextBox_DoubleClick( object sender, EventArgs e )
        {
            msBuildPathTextBox.ReadOnly = false;
            msBuildPathTextBox.Cursor = Cursors.IBeam;
        }

        private void nunitPathTextBox_DoubleClick( object sender, EventArgs e )
        {
            nunitPathTextBox.ReadOnly = false;
            nunitPathTextBox.Cursor = Cursors.IBeam;
        }

        private void saveBrowserOptionsButton_Click( object sender, EventArgs e )
        {

            DictionaryManipulators handleRunOptionsDictionary = new DictionaryManipulators( );

            if( !string.IsNullOrEmpty( nunitPathTextBox.Text ) )
            {
                string nunitPathText = nunitPathTextBox.Text;

                handleRunOptionsDictionary.AddToDictionary( RunOptionsEnums.NunitPath, nunitPathText, generalSettingsRunOptionsDictionary );

                SetLabelPosition( nunitPathTextBox, nunitPathChangeMessageLabel1, 400 );

                nunitPathChangeMessageLabel1.Text = $"'{nunitPathText}'";
                nunitPathChangeMessageLabel2.Text = "set as the nunit3-console.exe path";
            }

            if( !string.IsNullOrEmpty( msBuildPathTextBox.Text ) )
            {
                string msBuildPathText = msBuildPathTextBox.Text;

                handleRunOptionsDictionary.AddToDictionary( RunOptionsEnums.MsBuildPath, msBuildPathText, generalSettingsRunOptionsDictionary );

                SetLabelPosition( msBuildPathTextBox, msBuildPathChangeMessageLabel1, 450 );

                msBuildPathChangeMessageLabel1.Text = $"'{msBuildPathText}'";
                msBuildPathChangeMessageLabel2.Text = "set as the MSBuild.exe path";
            }

            EditRunOptionsBase editReportRunOptionsBase = new EditRunOptionsBase( true );

            editReportRunOptionsBase.EditFormRunOptionsDictionary = generalSettingsRunOptionsDictionary;
        }

        #endregion
    }
}
