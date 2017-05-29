using System;
using System.Drawing;
using System.Windows.Forms;
using TestRunnerGUI.Controllers;

namespace TestRunnerGUI
{
    public partial class AddToDropdown : Form
    {
        #region Fields

        private readonly string currentPath;

        #endregion

        #region ctor

        public AddToDropdown( string currentPath )
        {
            this.currentPath = currentPath;

            InitializeComponent( );

            ButtonControl buttonControls = new ButtonControl( );

            addToDropdownButton.MouseEnter += buttonControls.controlButtons_MouseEnter;
            addToDropdownButton.MouseLeave += buttonControls.controlButtons_MouseLeave;

            successfullyAddedText.Text = string.Empty;

            currentPathTextBox.Text = this.currentPath;

            currentPathTextBox.ForeColor = Color.FromArgb( 39, 182, 16 );

            addToDropdownButton.DialogResult = DialogResult.OK;
        }

        #endregion

        #region Event handlers

        private void addToDropdownButton_Click( object sender, EventArgs e )
        {

            string givenName = givenNameTextBox.Text;
            string currentPathTextBoxText = currentPathTextBox.Text;

            if( !string.IsNullOrEmpty( givenName ) && ( !string.IsNullOrEmpty( currentPath ) || !string.IsNullOrEmpty( currentPathTextBoxText ) ) )
            {
                TestRunnerGUI.testDictionary.Add( givenName, currentPathTextBoxText );

                givenNameTextBox.Clear( );
                currentPathTextBox.Clear( );

                string message = $"'{givenName}' test" + Environment.NewLine + $"with '{currentPathTextBoxText}' path" + Environment.NewLine + "is successfully added to the list!";

                int messsageLength = currentPathTextBoxText.Length;

                if ( messsageLength <= 20 )
                {
                    successfullyAddedText.Location = new Point( 235, 420 );
                }
                else if ( messsageLength <= 30 )
                {
                    successfullyAddedText.Location = new Point( 205, 420 );
                }
                else if ( messsageLength <= 45 )
                {
                    successfullyAddedText.Location = new Point( 190, 420 );
                }
                else if ( messsageLength <= 60 )
                {
                    successfullyAddedText.Location = new Point( 135, 420 );
                }
                else if ( messsageLength <= 75 )
                {
                    successfullyAddedText.Location = new Point( 100, 420 );
                }
                else
                {
                    successfullyAddedText.Location = new Point( 30, 420 );
                }

                successfullyAddedText.Text = message;
            }
            else
            {
                MessageBox.Show( "The newly added test should have a path and a name given. If either of those are empty, please fill the name, choose a path and try again", "", MessageBoxButtons.OK );
            }
        }

        #endregion
    }
}
