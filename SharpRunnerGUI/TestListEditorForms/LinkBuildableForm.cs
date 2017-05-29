using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TestRunnerGUI.Controllers;
using TestRunnerGUI.Utilities;

namespace TestRunnerGUI.TestListEditorForms
{
    public partial class LinkBuildableForm : Form
    {
        #region Fields

        private Dictionary<string, string> testNameAndBuildableDictionary;

        #endregion

        #region ctor

        public LinkBuildableForm( )
        {
            testNameAndBuildableDictionary = new Dictionary<string, string>( );

            LinkTestListBuildable serializationLinkBuildables = new LinkTestListBuildable( );

            serializationLinkBuildables.DeserializeTestDictionary( );

            if ( serializationLinkBuildables.testNameBuildableDictionary != null )
            {
                testNameAndBuildableDictionary = serializationLinkBuildables.testNameBuildableDictionary;
            }

            DataLoadHandlers loadDataHandler = new DataLoadHandlers( );
            ButtonControl buttonControls = new ButtonControl( );
            InitializeComponent( );

            selectBuildablePathButton.MouseEnter += buttonControls.controlButtons_MouseEnter;
            selectBuildablePathButton.MouseLeave += buttonControls.controlButtons_MouseLeave;
            saveBuildableLinkedButton.MouseEnter += buttonControls.controlButtons_MouseEnter;
            saveBuildableLinkedButton.MouseLeave += buttonControls.controlButtons_MouseLeave;

            testListDropdown.DrawItem += testListDropdown_DrawItem;

            testBuildableSuccessfulLinkedMessage.Text = string.Empty;

            loadDataHandler.LoadInTestListToDropdown( testListDropdown, TestRunnerGUI.testDictionary );
        }

        public LinkBuildableForm( string currentBuildablePath )
            : this()
        {
            pathToBuildableTextBox.Text = currentBuildablePath;
            pathToBuildableTextBox.ReadOnly = true;
            pathToBuildableTextBox.Cursor = Cursors.Arrow;
        }

        #endregion

        #region Event handlers

        private void testListDropdown_DropDownClosed(object sender, EventArgs e)
        {
            buildablePathTooltip.Hide( testListDropdown );
        }

        private void testListDropdown_DrawItem(object sender, DrawItemEventArgs e)
        {
            if ( e.Index < 0 )
            {
                return;
            }

            string dropdownItemsText = testListDropdown.GetItemText( testListDropdown.Items[ e.Index ] );

            string toolTipText = null;

            if ( testNameAndBuildableDictionary.ContainsKey( testListDropdown.GetItemText( testListDropdown.Items[ e.Index ] ) ) )
            {
                toolTipText = $"Linked buildable: {testNameAndBuildableDictionary[ testListDropdown.GetItemText( testListDropdown.Items[ e.Index ] ) ]}";
            }

            e.DrawBackground( );

            using ( SolidBrush brush = new SolidBrush( e.ForeColor ) )
            {
                e.Graphics.DrawString( dropdownItemsText, e.Font, brush, e.Bounds );
            }

            if ( (e.State & DrawItemState.Selected ) == DrawItemState.Selected )
            {
                if ( toolTipText != null )
                {
                    buildablePathTooltip.Show( toolTipText, testListDropdown, e.Bounds.Right, e.Bounds.Bottom );
                }
                else
                {
                    buildablePathTooltip.Hide( this );
                }
            }

            e.DrawFocusRectangle();
        }

        private void selectBuildablePathButton_Click( object sender, EventArgs e )
        {
            OpenFileDialog fileExplorer = new OpenFileDialog( );

            DialogResult result = fileExplorer.ShowDialog( );

            if ( result == DialogResult.OK )
            {
                string filePath = fileExplorer.FileName;

                pathToBuildableTextBox.Text = $"{filePath}";

                pathToBuildableTextBox.ReadOnly = true;
                pathToBuildableTextBox.Cursor = Cursors.Arrow;
            }
        }

        private void pathToBuildableTextBox_DoubleClick( object sender, EventArgs e )
        {
            pathToBuildableTextBox.ReadOnly = false;
            pathToBuildableTextBox.Cursor = Cursors.IBeam;
        }

        private void saveBuildableLinkedButton_Click( object sender, EventArgs e )
        {
            string currentSelectedBuildablePath = pathToBuildableTextBox.Text;

            if( testListDropdown.SelectedIndex > -1 && !string.IsNullOrEmpty( currentSelectedBuildablePath ) )
            {

                string currentSelectedTestName = testListDropdown.GetItemText( testListDropdown.SelectedItem );

                DialogResult linkTestWithBuildable =
                MessageBox.Show( $"Are You sure, you want to link: '{currentSelectedTestName}'" +
                Environment.NewLine + $"with this test buildable: '{currentSelectedBuildablePath}'?",
                "Link Test with Buildable", MessageBoxButtons.OKCancel );

                if ( linkTestWithBuildable == DialogResult.OK )
                {
                    DictionaryManipulators handleDictionary = new DictionaryManipulators( );

                    bool successfullyAddedToDictionary = handleDictionary.AddLinkedTestWithBuildableDictionary(
                        currentSelectedTestName, currentSelectedBuildablePath, testNameAndBuildableDictionary );

                    string message;

                    if( successfullyAddedToDictionary )
                    {
                        LinkTestListBuildable serializationLinkBuildables = new LinkTestListBuildable( testNameAndBuildableDictionary );

                        serializationLinkBuildables.SerializeTestDictionary( );

                        message = $"You are successfully linked '{currentSelectedTestName}' test with"
                            + Environment.NewLine + currentSelectedBuildablePath + Environment.NewLine + "buildable.";
                    }
                    else
                    {
                        message = $"Something went wrong, when tried to link '{currentSelectedTestName}' test with"
                            + Environment.NewLine + currentSelectedBuildablePath + Environment.NewLine +
                            "buildable. Please try again, and if the issue still exist, contact TestSharp team." ;
                    }
                    
                    testBuildableSuccessfulLinkedMessage.Text = message;
                }

                testListDropdown.SelectedIndex = -1;
                pathToBuildableTextBox.Clear( );
            }
        }

        private void removedLinkButton_Click( object sender, EventArgs e )
        {
            if ( testListDropdown.SelectedIndex > -1 )
            {
                string currentlySelectedTest = testListDropdown.GetItemText( testListDropdown.SelectedItem );

                if( testNameAndBuildableDictionary.ContainsKey( currentlySelectedTest ) )
                {
                    DialogResult result = MessageBox.Show( "Are you sure, you would like to detach"
                        + Environment.NewLine + $"'{currentlySelectedTest}' from" + Environment.NewLine
                        + $"'{testNameAndBuildableDictionary[ currentlySelectedTest ]}'?", "Remove linked buildable", MessageBoxButtons.YesNo );

                    if ( result == DialogResult.Yes )
                    {
                        string buildablePathToRemove = testNameAndBuildableDictionary[ currentlySelectedTest ];
                        testNameAndBuildableDictionary.Remove( currentlySelectedTest );
                        LinkTestListBuildable serializationLinkBuildables = new LinkTestListBuildable( testNameAndBuildableDictionary );
                        serializationLinkBuildables.SerializeTestDictionary( );
                        testBuildableSuccessfulLinkedMessage.Text = $"Successfully removed" + Environment.NewLine + $"'{buildablePathToRemove}'"
                            + Environment.NewLine + $"from '{currentlySelectedTest}' test";
                    }
                }
                else
                {
                    MessageBox.Show( "You cannot remove link to a buildable, because that test doesn't contains one" );
                }
            }
            else
            {
                MessageBox.Show( "Please select a test first" );
            }
        }

        #endregion

        
    }
}
