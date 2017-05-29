using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TestRunnerGUI.RunOptionsEditorForms;
using TestRunnerGUI.Controllers;
using TestRunnerGUI.Utilities.Enums;

namespace TestRunnerGUI
{
    public partial class EditRunOptionsBase : Form
    {
        #region Fields

        private Dictionary<RunOptionsEnums, string> editFormRunOptionsDictionary = new Dictionary<RunOptionsEnums, string>( );

        private readonly Dictionary<Button, Color> tabButtonForeColorDictionary;
        private readonly Dictionary<Button, Color> tabButtonBackColorDictionary;
        public Dictionary<RunOptionsEnums, string> EditFormRunOptionsDictionary { get; set; }

        private List<string> editFormBrowserList = new List<string>( );

        public List<string> EditFormBrowserList { get; set; }

        ButtonControl buttonControls = new ButtonControl( );

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        
        [System.Runtime.InteropServices.DllImport( "user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport( "user32.dll")]
        public static extern bool ReleaseCapture();

        #endregion

        #region ctor

        public EditRunOptionsBase( )
        {
            InitializeComponent( );

            closeButton.MouseEnter += buttonControls.controlButtons_MouseEnter;
            closeButton.MouseLeave += buttonControls.controlButtons_MouseLeave;
            saveSettingsButton.MouseEnter += buttonControls.controlButtons_MouseEnter;
            saveSettingsButton.MouseLeave += buttonControls.controlButtons_MouseLeave;
            helpButton.MouseEnter += buttonControls.controlButtons_MouseEnter;
            helpButton.MouseLeave += buttonControls.controlButtons_MouseLeave;

            RunOptions editFormRunOptions = new RunOptions( );

            editFormRunOptions.DeserializeRunOptions( );
            editFormRunOptions.DeserializeRunOptionsBrowserList( );

            if ( editFormRunOptions.runOptionsDictionary != null )
            {
                editFormRunOptionsDictionary = editFormRunOptions.runOptionsDictionary;
            }

            if ( editFormRunOptions.browserList != null )
            {
                editFormBrowserList = editFormRunOptions.browserList;
            }

            tabButtonForeColorDictionary = new Dictionary<Button, Color>( )
            {
                [ generalSettingsButton ] = generalSettingsButton.ForeColor,
                [ reportOptionsButton ] = reportOptionsButton.ForeColor,
                [ browserOptionsButton ] = browserOptionsButton.ForeColor,
                [ workersOptionsButton ] = workersOptionsButton.ForeColor
            };

            tabButtonBackColorDictionary = new Dictionary<Button, Color>( )
            {
                [ generalSettingsButton ] = generalSettingsButton.BackColor,
                [ reportOptionsButton ] = reportOptionsButton.BackColor,
                [ browserOptionsButton ] = browserOptionsButton.BackColor,
                [ workersOptionsButton ] = workersOptionsButton.BackColor
            };
        }

        public EditRunOptionsBase( bool isEmptyCtor )
        { }

        #endregion

        #region Event handlers

        private void helpButton_Click( object sender, EventArgs e )
        {
            MessageBox.Show(
                "In the Edit Run Options menu, you can:" + 
                Environment.NewLine + "\t1, In general settings:" +
                Environment.NewLine + "\t\tSet the nunit3-console.exe and MSBuild.exe paths" +
                Environment.NewLine + "\t2, Under report options:" +
                Environment.NewLine + "\t\tSet the text and XML reports filenames" +
                Environment.NewLine + "\t\tSet the XML's formatting style and the reports folder path" +
                Environment.NewLine + "\t3, In browser options:" +
                Environment.NewLine + "\t\tYou can edit the browser list and select a default browser" +
                Environment.NewLine + "\t4, Under workers option:" +
                Environment.NewLine + "\t\tYou are able to set the default" +
                Environment.NewLine + "\t\tand maximum numbers of the workers"
                ,"Edit Run Options Help" );
        }

        private void closeButton_Click( object sender, EventArgs e )
        {
            Close( );
        }

        private void saveSettingsButton_Click( object sender, EventArgs e )
        {
            RunOptions editFormRunOptions = new RunOptions( editFormRunOptionsDictionary, editFormBrowserList );

            bool SuccessfullySerializedRunOptionsDictionary = editFormRunOptions.SerializeRunOptionsDictionary( );
            bool SuccessfullySerializedBrowserList = editFormRunOptions.SerializeRunOptionsBrowserList( );

            if( !SuccessfullySerializedRunOptionsDictionary && !SuccessfullySerializedBrowserList )
            {
                MessageBox.Show( "Unable to save either the browser list or the other options" );
            }
            else if( !SuccessfullySerializedRunOptionsDictionary )
            {
                MessageBox.Show( "Unable to save the general run options" );
            }
            else if( !SuccessfullySerializedBrowserList )
            {
                MessageBox.Show( "Unable to save the browser list" );
            }
            else
            {
                Close( );
            }
        }

        private void reportOptionsButton_Click( object sender, EventArgs e )
        {
            buttonControls.SwitchBackTabColorsToDefault( tabButtonForeColorDictionary, tabButtonBackColorDictionary );

            Button tabButton = sender as Button;

            buttonControls.SwitchForeAndBackButtonColors( tabButton );

            ReportEditorForm reportOptionsEditorForm = new ReportEditorForm( editFormRunOptionsDictionary );
            reportOptionsEditorForm.TopLevel = false;

            foreach( Control child in editRunOptionsSplitContainer.Panel1.Controls )
            {
                editRunOptionsSplitContainer.Panel1.Controls.Remove( child );
            }

            editRunOptionsSplitContainer.Panel1.Controls.Add( reportOptionsEditorForm );
            reportOptionsEditorForm.Dock = DockStyle.Fill;
            
            reportOptionsEditorForm.Show( );
        }

        private void browserOptionsButton_Click( object sender, EventArgs e )
        {
            buttonControls.SwitchBackTabColorsToDefault( tabButtonForeColorDictionary, tabButtonBackColorDictionary );

            Button tabButton = sender as Button;

            buttonControls.SwitchForeAndBackButtonColors( tabButton );

            BrowserOptionsEditorForm browserOptionsEditorForm = new BrowserOptionsEditorForm( editFormRunOptionsDictionary, editFormBrowserList );
            browserOptionsEditorForm.TopLevel = false;

            foreach( Control child in editRunOptionsSplitContainer.Panel1.Controls )
            {
                editRunOptionsSplitContainer.Panel1.Controls.Remove( child );
            }

            editRunOptionsSplitContainer.Panel1.Controls.Add( browserOptionsEditorForm );
            browserOptionsEditorForm.Dock = DockStyle.Fill;

            browserOptionsEditorForm.Show( );
        }

        private void workersOptionsButton_Click( object sender, EventArgs e )
        {
            buttonControls.SwitchBackTabColorsToDefault( tabButtonForeColorDictionary, tabButtonBackColorDictionary );

            Button tabButton = sender as Button;

            buttonControls.SwitchForeAndBackButtonColors( tabButton );

            WorkersOptionEditorForm workersOptionEditorForm = new WorkersOptionEditorForm( editFormRunOptionsDictionary );
            workersOptionEditorForm.TopLevel = false;

            foreach( Control child in editRunOptionsSplitContainer.Panel1.Controls )
            {
                editRunOptionsSplitContainer.Panel1.Controls.Remove( child );
            }

            editRunOptionsSplitContainer.Panel1.Controls.Add( workersOptionEditorForm );
            workersOptionEditorForm.Dock = DockStyle.Fill;

            workersOptionEditorForm.Show( );
        }

        private void generalSettingsButton_Click( object sender, EventArgs e )
        {
            buttonControls.SwitchBackTabColorsToDefault( tabButtonForeColorDictionary, tabButtonBackColorDictionary );

            Button tabButton = sender as Button;

            buttonControls.SwitchForeAndBackButtonColors( tabButton );

            GeneralSettingsForm generalSettingsForm = new GeneralSettingsForm( editFormRunOptionsDictionary );
            generalSettingsForm.TopLevel = false;

            foreach( Control child in editRunOptionsSplitContainer.Panel1.Controls )
            {
                editRunOptionsSplitContainer.Panel1.Controls.Remove( child );
            }

            editRunOptionsSplitContainer.Panel1.Controls.Add( generalSettingsForm );
            generalSettingsForm.Dock = DockStyle.Fill;

            generalSettingsForm.Show( );
        }

        private void splitContainer_MouseDown(object sender, MouseEventArgs e)
        {     
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion
    }
}
