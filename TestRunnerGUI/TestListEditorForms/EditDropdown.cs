using System;
using System.Drawing;
using System.Windows.Forms;
using TestRunnerGUI.Controllers;
using TestRunnerGUI.Utilities;

namespace TestRunnerGUI
{
    public partial class EditDropdown : Form
    {

        #region Fields

        DataLoadHandlers loadDataHandler;

        #endregion

        #region ctor

        public EditDropdown( )
        {
            loadDataHandler = new DataLoadHandlers( );
            ButtonControl buttonControls = new ButtonControl( );
            InitializeComponent( );

            saveDropdownChangesButton.MouseEnter += buttonControls.controlButtons_MouseEnter;
            saveDropdownChangesButton.MouseLeave += buttonControls.controlButtons_MouseLeave;

            testListDropdown.DrawItem += testListDropdown_DrawItem;

            loadDataHandler.LoadInTestListToDropdown( testListDropdown, TestRunnerGUI.testDictionary );
        }

        #endregion

        #region Event handlers

        private void saveDropdownChangesButton_Click( object sender, EventArgs e )
        {
            string selectedTestFromDropdown = testListDropdown.GetItemText( testListDropdown.SelectedItem );
            string givenNameFromNameInputField = givenNameTextBox.Text;
            string givenPathFromPathInputField = currentPathTextBox.Text;

            DialogResult editListResult =
                MessageBox.Show( $"Are You sure, you want to edit: '{selectedTestFromDropdown}'?" +
                Environment.NewLine + $"New name will be: '{givenNameFromNameInputField}'." +
                Environment.NewLine + $"New path will be: '{givenPathFromPathInputField}'.", "Edit Test List", MessageBoxButtons.OKCancel );

            if ( editListResult == DialogResult.OK )
            {
                DictionaryManipulators handleDictionary = new DictionaryManipulators( );

                handleDictionary.EditTestDictionary( selectedTestFromDropdown, givenNameFromNameInputField, givenPathFromPathInputField );

                loadDataHandler.LoadInTestListToDropdown( testListDropdown, TestRunnerGUI.testDictionary );

                currentPathTextBox.Clear( );

                givenNameTextBox.Clear( );

            }

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
