using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TestRunnerGUI.Controllers;
using TestRunnerGUI.Utilities;
using TestRunnerGUI.Utilities.Enums;

namespace TestRunnerGUI.RunOptionsEditorForms
{
    public partial class BrowserOptionsEditorForm : Form
    {

        #region Fields

        private Dictionary<RunOptionsEnums, string> editBrowsersRunOptionsDictionary = new Dictionary<RunOptionsEnums, string>();
        private List<string> editBrowsersList = new List<string>( );
        Point messageLocation;
        DataLoadHandlers loadDataHandler;

        #endregion

        #region ctor

        public BrowserOptionsEditorForm( )
        {
            loadDataHandler = new DataLoadHandlers( );

            InitializeComponent( );

            ButtonControl buttonControls = new ButtonControl( );

            removeBrowserFromListButton.MouseEnter += buttonControls.controlButtons_MouseEnter;
            removeBrowserFromListButton.MouseLeave += buttonControls.controlButtons_MouseLeave;
            addNewBrowserButton.MouseEnter += buttonControls.controlButtons_MouseEnter;
            addNewBrowserButton.MouseLeave += buttonControls.controlButtons_MouseLeave;
            saveBrowserOptionsButton.MouseEnter += buttonControls.controlButtons_MouseEnter;
            saveBrowserOptionsButton.MouseLeave += buttonControls.controlButtons_MouseLeave;

            browserOptionsSuccessfullChangeMessageLabel.Text = string.Empty;
            messageLocation = browserOptionsSuccessfullChangeMessageLabel.Location;
        }

        public BrowserOptionsEditorForm( Dictionary<RunOptionsEnums, string> editBrowsersRunOptionsDictionary, List<string> editBrowsersList )
            : this()
        {
            this.editBrowsersRunOptionsDictionary = editBrowsersRunOptionsDictionary;
            this.editBrowsersList = editBrowsersList;

            if ( this.editBrowsersList != null )
            {
                List<ComboBox> browserSelectorsList = new List<ComboBox>( )
                {
                    defaultBrowserSelector,
                    browserListToRemoveBrowser
                };

                loadDataHandler.PopulateBrowserDropdowns( browserSelectorsList, this.editBrowsersList );
            }

            if ( this.editBrowsersRunOptionsDictionary != null )
            {
                loadDataHandler.SetDefaultBrowser( defaultBrowserSelector, this.editBrowsersRunOptionsDictionary );
            }
        }

        #endregion

        #region Event handlers

        private void saveBrowserOptionsButton_Click( object sender, EventArgs e )
        {
            browserOptionsSuccessfullChangeMessageLabel.Location = messageLocation;

            if( defaultBrowserSelector.SelectedIndex > -1 )
            {
                DictionaryManipulators handleRunOptionsDictionary = new DictionaryManipulators( );

                string defaultBrowserSelectedItemText = defaultBrowserSelector.SelectedItem.ToString();
                handleRunOptionsDictionary.AddToDictionary( RunOptionsEnums.DefaultBrowser, defaultBrowserSelectedItemText, editBrowsersRunOptionsDictionary );

                browserOptionsSuccessfullChangeMessageLabel.Text = $"'{defaultBrowserSelectedItemText}' selected as the new default browser";
            }

            EditRunOptionsBase editReportRunOptionsBase = new EditRunOptionsBase( true );

            editReportRunOptionsBase.EditFormRunOptionsDictionary = editBrowsersRunOptionsDictionary;
            editReportRunOptionsBase.EditFormBrowserList = editBrowsersList;
        }

        private void addNewBrowserButton_Click( object sender, EventArgs e )
        {
            browserOptionsSuccessfullChangeMessageLabel.Location = messageLocation;

            if( !string.IsNullOrEmpty( newBrowserTextBox.Text ) )
            {
                if ( !editBrowsersList.Contains( newBrowserTextBox.Text ) )
                {
                    editBrowsersList.Add( newBrowserTextBox.Text );

                    defaultBrowserSelector.Items.Add( newBrowserTextBox.Text );
                    browserListToRemoveBrowser.Items.Add( newBrowserTextBox.Text );

                    defaultBrowserSelector.Refresh( );
                    defaultBrowserSelector.Update( );

                    browserListToRemoveBrowser.Refresh( );
                    browserListToRemoveBrowser.Update( );

                    browserOptionsSuccessfullChangeMessageLabel.Text = $"Successfully added '{newBrowserTextBox.Text}' as a new browser";
                }
                else
                {
                    browserOptionsSuccessfullChangeMessageLabel.Location = new Point( 235, 466 );
                    browserOptionsSuccessfullChangeMessageLabel.Text = $"Browser list already contains '{newBrowserTextBox.Text}'";
                }
            }

            newBrowserTextBox.Clear( );
        }

        private void removeBrowserFromListButton_Click( object sender, EventArgs e )
        {
            browserOptionsSuccessfullChangeMessageLabel.Location = messageLocation;

            if( browserListToRemoveBrowser.SelectedIndex > -1 )
            {
                string removeBrowserSelectedItemText = browserListToRemoveBrowser.SelectedItem.ToString();

                if ( editBrowsersList.Contains( removeBrowserSelectedItemText ) )
                {
                    editBrowsersList.Remove( removeBrowserSelectedItemText );

                    defaultBrowserSelector.Items.Remove( removeBrowserSelectedItemText );
                    browserListToRemoveBrowser.Items.Remove( removeBrowserSelectedItemText );

                    defaultBrowserSelector.Refresh( );
                    defaultBrowserSelector.Update( );

                    browserListToRemoveBrowser.Refresh( );
                    browserListToRemoveBrowser.Update( );

                    browserOptionsSuccessfullChangeMessageLabel.Location = new Point( 225, 466 );
                    browserOptionsSuccessfullChangeMessageLabel.Text = $"'{removeBrowserSelectedItemText}' browser is removed from the list";
                }

                browserListToRemoveBrowser.SelectedIndex = -1;
            }
        }

        #endregion
    }
}
