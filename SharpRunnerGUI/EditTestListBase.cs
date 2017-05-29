using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TestRunnerGUI.Controllers;
using TestRunnerGUI.TestListEditorForms;

namespace TestRunnerGUI
{

    public partial class EditTestListBase : Form
    {
        #region Fields

        private readonly string currentPath;
        private readonly string currentBuildablePath;

        private readonly Dictionary<Button, Color> tabButtonForeColorDictionary;
        private readonly Dictionary<Button, Color> tabButtonBackColorDictionary;

        private readonly bool testExecutablePathGiven = false;
        private readonly bool testBuildablePathGiven = false;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        
        [System.Runtime.InteropServices.DllImport( "user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport( "user32.dll")]
        public static extern bool ReleaseCapture();

        ButtonControl buttonControls = new ButtonControl( );

        #endregion

        #region ctor

        public EditTestListBase( )
        {
            InitializeComponent( );

            closeButton.MouseEnter += buttonControls.controlButtons_MouseEnter;
            closeButton.MouseLeave += buttonControls.controlButtons_MouseLeave;

            helpButton.MouseEnter += buttonControls.controlButtons_MouseEnter;
            helpButton.MouseLeave += buttonControls.controlButtons_MouseLeave;

            tabButtonForeColorDictionary = new Dictionary<Button, Color>( )
            {
                [ addNewTestTabButton ] = addNewTestTabButton.ForeColor,
                [ editTestListTabButton ] = editTestListTabButton.ForeColor,
                [ removeTestTabButton ] = removeTestTabButton.ForeColor,
                [ linkProjSolutionToTestButton ] = linkProjSolutionToTestButton.ForeColor
            };

            tabButtonBackColorDictionary = new Dictionary<Button, Color>( )
            {
                [ addNewTestTabButton ] = addNewTestTabButton.BackColor,
                [ editTestListTabButton ] = editTestListTabButton.BackColor,
                [ removeTestTabButton ] = removeTestTabButton.BackColor,
                [ linkProjSolutionToTestButton ] = linkProjSolutionToTestButton.BackColor
            };

        }

        public EditTestListBase( string currentPath )
            : this()
        {
            testExecutablePathGiven = true;
            this.currentPath = currentPath;
        }

        public EditTestListBase( string currentPath, string currentBuildablePath )
            : this()
        {
            testExecutablePathGiven = true;
            testBuildablePathGiven = true;
            this.currentPath = currentPath;
            this.currentBuildablePath = currentBuildablePath;
        }

        public EditTestListBase( string currentBuildablePath, bool isOnlyBuildableGiven )
            : this()
        {
            testBuildablePathGiven = isOnlyBuildableGiven;
            this.currentBuildablePath = currentBuildablePath;
        }

        #endregion

        #region Event handlers

        private void addNewTestTabButton_Click( object sender, EventArgs e )
        {
            buttonControls.SwitchBackTabColorsToDefault( tabButtonForeColorDictionary, tabButtonBackColorDictionary );

            Button tabButton = sender as Button;

            buttonControls.SwitchForeAndBackButtonColors( tabButton );

            AddToDropdown addToDropdownForm = new AddToDropdown( currentPath );
            addToDropdownForm.TopLevel = false;

            foreach( Control child in editTestListSplitContainer.Panel1.Controls )
            {
                editTestListSplitContainer.Panel1.Controls.Remove( child );
            }

            editTestListSplitContainer.Panel1.Controls.Add( addToDropdownForm );
            addToDropdownForm.Dock = DockStyle.Fill;
            if( !testExecutablePathGiven )
            {
                addToDropdownForm.currentPathTextBox.ReadOnly = false;
                addToDropdownForm.currentPathTextBox.Cursor = Cursors.IBeam;
            }
            addToDropdownForm.Show( );
        }

        private void editTestListTabButton_Click( object sender, EventArgs e )
        {
            buttonControls.SwitchBackTabColorsToDefault( tabButtonForeColorDictionary, tabButtonBackColorDictionary );

            Button tabButton = sender as Button;

            buttonControls.SwitchForeAndBackButtonColors( tabButton );

            EditDropdown editTestListForm = new EditDropdown( );
            editTestListForm.TopLevel = false;
            
            foreach( Control child in editTestListSplitContainer.Panel1.Controls )
            {
                editTestListSplitContainer.Panel1.Controls.Remove( child );
            }

            editTestListSplitContainer.Panel1.Controls.Add( editTestListForm );
            editTestListForm.Dock = DockStyle.Fill;
            editTestListForm.Show( );
        }

        private void linkProjSolutionToTestButton_Click( object sender, EventArgs e )
        {
             buttonControls.SwitchBackTabColorsToDefault( tabButtonForeColorDictionary, tabButtonBackColorDictionary );

            Button tabButton = sender as Button;

            buttonControls.SwitchForeAndBackButtonColors( tabButton );

            LinkBuildableForm linkBuildableTestForm = new LinkBuildableForm( currentBuildablePath );
            linkBuildableTestForm.TopLevel = false;
            
            foreach( Control child in editTestListSplitContainer.Panel1.Controls )
            {
                editTestListSplitContainer.Panel1.Controls.Remove( child );
            }

            editTestListSplitContainer.Panel1.Controls.Add( linkBuildableTestForm );
            linkBuildableTestForm.Dock = DockStyle.Fill;

            if( !testBuildablePathGiven )
            {
                linkBuildableTestForm.pathToBuildableTextBox.ReadOnly = false;
                linkBuildableTestForm.pathToBuildableTextBox.Cursor = Cursors.IBeam;
            }

            linkBuildableTestForm.Show( );
        }

        private void removeTestTabButton_Click( object sender, EventArgs e )
        {
            buttonControls.SwitchBackTabColorsToDefault( tabButtonForeColorDictionary, tabButtonBackColorDictionary );

            Button tabButton = sender as Button;

            buttonControls.SwitchForeAndBackButtonColors( tabButton );

            RemoveDropdown removeTestForm = new RemoveDropdown( );
            removeTestForm.TopLevel = false;

            foreach( Control child in editTestListSplitContainer.Panel1.Controls )
            {
                editTestListSplitContainer.Panel1.Controls.Remove( child );
            }

            editTestListSplitContainer.Panel1.Controls.Add( removeTestForm );
            removeTestForm.Dock = DockStyle.Fill;
            removeTestForm.Show( );
        }

        private void closeButton_Click( object sender, EventArgs e )
        {
            Close( );
        }

        private void helpButton_Click( object sender, EventArgs e )
        {
            MessageBox.Show(
                "On this form you are able to:" +
                Environment.NewLine + "\t1, Add new tests to the list" +
                Environment.NewLine + "\t2, You can edit the dll's path and test name in test list" + 
                Environment.NewLine + "\t3, Remove tests from the test list" + 
                Environment.NewLine + "\t4, Link solution or project file to the test"
                ,"Edit Test List Help" );
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
