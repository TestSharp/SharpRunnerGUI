using System.Collections.Generic;
using System.Windows.Forms;
using TestRunnerGUI.Utilities.Enums;

namespace TestRunnerGUI.Utilities
{
    public class DataLoadHandlers
    {

        public void PopulateBrowserDropdowns( List<ComboBox> dropdownList, List<string> browserList )
        {
            if ( browserList.Count != 0 )
            {
                SetOptions options = new SetOptions( );

                foreach ( ComboBox currentDropdown in dropdownList )
                {
                    options.PopulateBrowserDropdown( currentDropdown, browserList );
                }
            }
        }

        public void SetDefaultBrowser( ComboBox dropdown, Dictionary<RunOptionsEnums, string> runOptionsDictionary )
        {
            if ( runOptionsDictionary.Count != 0 )
            {
                SetOptions options = new SetOptions( );

                options.SetDefaultBrowser( dropdown, runOptionsDictionary );
            }

        }

        public void LoadInTestListToDropdown( ComboBox dropdownSelector, Dictionary<string, string> testDictionary )
        {
            dropdownSelector.Items.Clear( );

            List<string> testNameList = new List<string>( testDictionary.Keys );

            foreach( string testName in testNameList )
            {
                dropdownSelector.Items.Add( testName );
            }
        }

        public void SetReportOutputFolderPath( TextBox folderPathTextBox, Dictionary<RunOptionsEnums, string> runOptionsDictionary )
        {
            if ( runOptionsDictionary.Count != 0 )
            {
                SetOptions options = new SetOptions( );

                options.SetReportFolderPath( folderPathTextBox, runOptionsDictionary );
            }
        }

        public void SetTextReportName( TextBox nameTextBox, Dictionary<RunOptionsEnums, string> runOptionsDictionary )
        {
            if ( runOptionsDictionary.Count != 0 )
            {
                SetOptions options = new SetOptions( );

                options.SetTextReportName( nameTextBox, runOptionsDictionary );
            }

        }

        public void SetWorkersMaxAndDefaultNumbers( NumericUpDown maxWorkersNum, NumericUpDown defaultWorkersNum, Dictionary<RunOptionsEnums, string> runOptionsDictionary )
        {
            if ( runOptionsDictionary.Count != 0 )
            {
                SetOptions options = new SetOptions( );

                options.SetWorkerInputs( maxWorkersNum, defaultWorkersNum, runOptionsDictionary );
            }

        }

        public void SetMaxAndDefaultValueForWorkerInput( NumericUpDown workersInput, Dictionary<RunOptionsEnums, string> runOptionsDictionary )
        {
            if ( runOptionsDictionary.Count != 0 )
            {
                SetOptions options = new SetOptions( );

                options.SetWorkerOptions( workersInput, runOptionsDictionary );
            }

        }

        public void SetMsbuildNunitPaths( TextBox MsBuildPathTextBox, TextBox NunitPathTextBox, Dictionary<RunOptionsEnums, string> runOptionsDictionary )
        {
            if ( runOptionsDictionary.Count != 0 )
            {
                SetOptions options = new SetOptions( );

                options.SetBuilderRunnerPath( MsBuildPathTextBox, NunitPathTextBox, runOptionsDictionary );
            }
        }

        public void SetXmlOptions( TextBox nameTextBox, RadioButton nunitTwoStyleRadioButton, RadioButton nunitThreeStyleRadioButton, Dictionary<RunOptionsEnums, string> runOptionsDictionary )
        {
            if ( runOptionsDictionary.Count != 0 )
            {
                SetOptions options = new SetOptions( );

                options.SetXmlReportNameAndStyle( nameTextBox, nunitTwoStyleRadioButton, nunitThreeStyleRadioButton, runOptionsDictionary );
            }

        }


    }
}
