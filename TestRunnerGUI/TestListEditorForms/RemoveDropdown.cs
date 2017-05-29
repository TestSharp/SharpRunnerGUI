using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TestRunnerGUI.Controllers;
using TestRunnerGUI.Utilities;

namespace TestRunnerGUI
{
    public partial class RemoveDropdown : Form
    {

        #region Fields

        DataLoadHandlers loadDataHandler;

        #endregion

        #region ctor

        public RemoveDropdown( )
        {
            InitializeComponent( );

            loadDataHandler = new DataLoadHandlers( );
            ButtonControl buttonControls = new ButtonControl( );

            testListDropdown.DrawItem += testListDropdown_DrawItem;

            removeDropdownButton.MouseEnter += buttonControls.controlButtons_MouseEnter;
            removeDropdownButton.MouseLeave += buttonControls.controlButtons_MouseLeave;

            loadDataHandler.LoadInTestListToDropdown( testListDropdown, TestRunnerGUI.testDictionary );

            successfullRemovalLabel.Text = string.Empty;
        }

        #endregion

        #region Event handlers

        private void closeButton_Click( object sender, EventArgs e )
        {
            Close( );
        }

        private void helpButton_Click( object sender, EventArgs e )
        {
            // Show a popup with some help info
        }

        private void removeDropdownButton_Click( object sender, EventArgs e )
        {
            if ( testListDropdown.SelectedIndex > -1 )
            {
                string selectedTest = testListDropdown.GetItemText( testListDropdown.SelectedItem );

                DialogResult popupResult = MessageBox.Show( $"Are you sure, that you would like to remove '{selectedTest}' from the list?", "Remove test", MessageBoxButtons.YesNo );

                if( popupResult == DialogResult.Yes )
                {
                    TestRunnerGUI.testDictionary.Remove( selectedTest );

                    Dictionary<string, string> linkTestListBuildableDictionary = new Dictionary<string, string>( );

                    LinkTestListBuildable linkTestListBuildable = new LinkTestListBuildable( );

                    linkTestListBuildable.DeserializeTestDictionary( );

                    if( linkTestListBuildable.testNameBuildableDictionary != null )
                    {
                        linkTestListBuildableDictionary = linkTestListBuildable.testNameBuildableDictionary;
                    }

                    if( linkTestListBuildableDictionary.ContainsKey( selectedTest ) )
                    {
                        linkTestListBuildableDictionary.Remove( selectedTest );
                        linkTestListBuildable.testNameBuildableDictionary = linkTestListBuildableDictionary;
                        linkTestListBuildable.DeserializeTestDictionary( );
                    }

                    loadDataHandler.LoadInTestListToDropdown( testListDropdown, TestRunnerGUI.testDictionary );

                    testListDropdown.SelectedIndex = -1;

                    successfullRemovalLabel.Text = $"'{selectedTest}' successfully removed from the list!";
                }
            }
            else
            {
                MessageBox.Show( "Please select the item from the dropdown, you would like to remove" );
            }
        }

        private void cancelButton_Click( object sender, EventArgs e )
        {
            Close( );
        }

        private void testListDropdown_DropDownClosed(object sender, EventArgs e)
        {
            pathToolTip.Hide( testListDropdown );
        }

        private void testListDropdown_DrawItem(object sender, DrawItemEventArgs e)
        {
            if ( e.Index < 0 )
            {
                return;
            }

            string dropdownItemsText = testListDropdown.GetItemText( testListDropdown.Items[ e.Index ] );

            string toolTipText = $"Test executable path: {TestRunnerGUI.testDictionary[ testListDropdown.GetItemText( testListDropdown.Items[ e.Index ] ) ]}";

            e.DrawBackground( );

            using ( SolidBrush brush = new SolidBrush( e.ForeColor ) )
            {
                e.Graphics.DrawString( dropdownItemsText, e.Font, brush, e.Bounds );
            }

            if ( (e.State & DrawItemState.Selected ) == DrawItemState.Selected )
            {
                pathToolTip.Show( toolTipText, testListDropdown, e.Bounds.Right, e.Bounds.Bottom );
            }

            e.DrawFocusRectangle();
        }

        #endregion
    }
}
