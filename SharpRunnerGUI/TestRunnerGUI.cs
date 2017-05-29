using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using TestRunnerGUI.Controllers;
using TestRunnerGUI.Utilities;
using TestRunnerGUI.Utilities.Enums;
using TestRunnerGUI.Utilities.RunCommandBuilders;

namespace TestRunnerGUI
{

    public partial class TestRunnerGUI : Form
    {

        #region Fields
        public string CurrentTestExecutablePath { get; set; }

        public static Dictionary<string, string> testDictionary
        {
            get
            {
                return testListNamePath;
            }
        }

        private Dictionary<RunOptionsEnums, string> testRunnerRunOptionsDictionary = new Dictionary<RunOptionsEnums, string>();

        private Dictionary<string, string> testLinkedToBuildableDictionary = new Dictionary<string, string>( );

        private List<string> testRunnerBrowserList = new List<string>();

        public Dictionary<RunOptionsEnums, string> TestRunnerRunOptionsDictionary
        {
            get
            {
                return testRunnerRunOptionsDictionary;
            }
        }

        public List<string> TestRunnerBrowserList
        {
            get
            {
                return testRunnerBrowserList;
            }
        }

        private TestList testList;
        private RunOptions runOptions;

        private string testSelectedFromDropdown;

        private static Dictionary<string, string> testListNamePath = new Dictionary<string, string>();

        DataLoadHandlers loadDataHandler;

        #endregion

        #region ctor
        public TestRunnerGUI( )
        {
            loadDataHandler = new DataLoadHandlers( );
            ButtonControl buttonControls = new ButtonControl();
            FormControl formControls = new FormControl();

            InitializeComponent( );

            testSelectorDropdown.DrawItem += testSelectorDropdown_DrawItem;

            editDropdownButton.MouseEnter += buttonControls.controlButtons_MouseEnter;
            editDropdownButton.MouseLeave += buttonControls.controlButtons_MouseLeave;
            editRunOptionsButton.MouseEnter += buttonControls.controlButtons_MouseEnter;
            editRunOptionsButton.MouseLeave += buttonControls.controlButtons_MouseLeave;
            setCurrentTest.MouseEnter += buttonControls.controlButtons_MouseEnter;
            setCurrentTest.MouseLeave += buttonControls.controlButtons_MouseLeave;
            selectTestExecutableFromFileExplorer.MouseEnter += buttonControls.controlButtons_MouseEnter;
            selectTestExecutableFromFileExplorer.MouseLeave += buttonControls.controlButtons_MouseLeave;
            runTestButton.MouseEnter += buttonControls.controlButtons_MouseEnter;
            runTestButton.MouseLeave += buttonControls.controlButtons_MouseLeave;
            closeButton.MouseEnter += buttonControls.controlButtons_MouseEnter;
            closeButton.MouseLeave += buttonControls.controlButtons_MouseLeave;
            minimizeButton.MouseEnter += buttonControls.controlButtons_MouseEnter;
            minimizeButton.MouseLeave += buttonControls.controlButtons_MouseLeave;
            helpButton.MouseEnter += buttonControls.controlButtons_MouseEnter;
            helpButton.MouseLeave += buttonControls.controlButtons_MouseLeave;

            this.MouseDown += formControls.form_MouseDown;
            this.MouseMove += formControls.form_MouseMove;
            this.MouseUp += formControls.form_MouseUp;

            testList = new TestList( testListNamePath );

            testList.DeserializeTestDictionary( );

            foreach ( KeyValuePair<string, string> currentDictionaryItem in testList.testListNamePath )
            {
                testListNamePath.Add( currentDictionaryItem.Key, currentDictionaryItem.Value );
            }

            loadDataHandler.LoadInTestListToDropdown( testSelectorDropdown, testListNamePath );

            runOptions = new RunOptions( );

            runOptions.DeserializeRunOptions( );

            testRunnerRunOptionsDictionary = runOptions.runOptionsDictionary;

            runOptions.DeserializeRunOptionsBrowserList( );

            testRunnerBrowserList = runOptions.browserList;

            if ( testRunnerBrowserList != null )
            {
                loadDataHandler.PopulateBrowserDropdowns( new List<ComboBox>( ) { runBrowserSelector }, testRunnerBrowserList );
            }

            if ( testRunnerRunOptionsDictionary != null )
            {
                loadDataHandler.SetDefaultBrowser( runBrowserSelector, testRunnerRunOptionsDictionary );
                loadDataHandler.SetMaxAndDefaultValueForWorkerInput( workersNumberSetterInput, testRunnerRunOptionsDictionary );
            }

            LinkTestListBuildable linkTestListBuildable = new LinkTestListBuildable( );

            linkTestListBuildable.DeserializeTestDictionary( );

            testLinkedToBuildableDictionary = linkTestListBuildable.testNameBuildableDictionary;
        }

        private void EditDropdownButton_MouseEnter( object sender, EventArgs e )
        {
            throw new NotImplementedException( );
        }

        public TestRunnerGUI( bool emptyCtor )
        { }

        #endregion

        #region Helper Methods

        private string GetProjectRootDir()
        {
            string projectRootDir = AppDomain.CurrentDomain.BaseDirectory;
            
            // changes the unnecessary parts of the path (the remaining is the project dir) and changes to our wanted screenshot dir
            if ( projectRootDir.Contains ( "bin" ) )
            {
                string stringToReplace = projectRootDir.Substring( projectRootDir.IndexOf( "bin", StringComparison.Ordinal ) - 1 );
                projectRootDir = projectRootDir.Replace ( stringToReplace, "" );
            }

            return projectRootDir;
        }

        #endregion

        #region Event handlers
        private void minimizeButton_Click( object sender, EventArgs e )
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeButton_Click( object sender, EventArgs e )
        {
            DialogResult exitVerification = MessageBox.Show( "Are you sure, you would like to quit?", "Quit", MessageBoxButtons.YesNo );

            if ( exitVerification == DialogResult.Yes )
            {
                Application.Exit( );
            }
        }

        private void helpButton_Click( object sender, EventArgs e )
        {
            MessageBox.Show( "If You click on the 'Edit dropdown' button, You can:" +
                Environment.NewLine + "\t1, add new tests to the list" +
                Environment.NewLine + "\t2, edit your currently added tests names and paths" +
                Environment.NewLine + "\t3, remove previous tests from the list" +
                Environment.NewLine + "\t4, link project or solution file to a test in the list" +
                Environment.NewLine +
                Environment.NewLine + "You can edit the run options if you click on the 'Edit run options' button" +
                Environment.NewLine + "\t1, You can set the NUnit3 console and MSBuild path" +
                Environment.NewLine + "\t2, Change the reporting option parameters" +
                Environment.NewLine + "\t3, Customize the browser list and set a default browser" +
                Environment.NewLine + "\t4, And set the default workers number" +
                Environment.NewLine + "\tand the maximum workers numbers" +
                Environment.NewLine +
                Environment.NewLine + "In order to run your test, you need to:" +
                Environment.NewLine + "\t1, Either select a test from the list, or" +
                Environment.NewLine + "\t\tManually write the dll's path to the input field, or" +
                Environment.NewLine + "\t\tSelect the dll with the" +
                Environment.NewLine + "\t\t'Select test executable from file explorer' button" +
                Environment.NewLine + "\t2, Click on the 'Set current test' button" + 
                Environment.NewLine + "\t3, Select run options or just leave the default options" + 
                Environment.NewLine + "\t4, Click on 'Run Test' button"
                ,"Welcome to TestSharp Runner GUI" );
        }

        private void selectFromFileExplorer_Click( object sender, EventArgs e )
        {
            OpenFileDialog fileExplorer = new OpenFileDialog( );

            DialogResult result = fileExplorer.ShowDialog( );

            if ( result == DialogResult.OK )
            {
                string filePath = fileExplorer.FileName;

                testExecPathTextBox.Text = $"{filePath}";

                testExecPathTextBox.ReadOnly = true;
            }
        }

        private void selectTestBuildableFromFileExplorer_Click( object sender, EventArgs e )
        {
            OpenFileDialog fileExplorer = new OpenFileDialog( );

            DialogResult result = fileExplorer.ShowDialog( );

            if ( result == DialogResult.OK )
            {
                string filePath = fileExplorer.FileName;

                testBuildablePathTextBox.Text = $"{filePath}";

                testBuildablePathTextBox.ReadOnly = true;

                testBuildablePathTextBox.Cursor = Cursors.Arrow;
            }
        }

        private void editDropdownButton_Click( object sender, EventArgs e )
        {
            EditTestListBase editTestListForm;

            if ( !string.IsNullOrEmpty( testExecPathTextBox.Text ) && !string.IsNullOrEmpty( testBuildablePathTextBox.Text ) )
            {
                editTestListForm = new EditTestListBase( testExecPathTextBox.Text, testBuildablePathTextBox.Text );
            }
            else if( !string.IsNullOrEmpty( testExecPathTextBox.Text ) )
            {
                editTestListForm = new EditTestListBase( testExecPathTextBox.Text );
            }
            else if( !string.IsNullOrEmpty( testBuildablePathTextBox.Text ) )
            {
                editTestListForm = new EditTestListBase( testBuildablePathTextBox.Text, true );
            }
            else
            {
                editTestListForm = new EditTestListBase( );
            }

            editTestListForm.ShowDialog( );

            testExecPathTextBox.Clear( );

            loadDataHandler.LoadInTestListToDropdown( testSelectorDropdown, testListNamePath );
        }

        private void setCurrentTest_Click( object sender, EventArgs e )
        {
            if ( testSelectorDropdown.SelectedIndex != -1 )
            {
                string currentlySelectedItem = testSelectorDropdown.SelectedItem as string;

                if ( currentlySelectedItem != null )
                {

                    string getCurrentPath = testListNamePath[ currentlySelectedItem ];

                    if ( getCurrentPath != null )
                    {
                        CurrentTestExecutablePath = getCurrentPath;
                    }
                }

                currentSelectedPathTextBox.Text = CurrentTestExecutablePath;
            }
            else if ( testExecPathTextBox.Text.Length > 0 )
            {
                CurrentTestExecutablePath = testExecPathTextBox.Text;

                currentSelectedPathTextBox.Text = CurrentTestExecutablePath;
            }
            else
            {
                MessageBox.Show( "We couldn't find any test executable path neither in the dropdown or in the textbox", "Couldn't find test executable path", MessageBoxButtons.OK );
            }
        }

        private void testSelectorDropdown_IndexChanged( object sender, EventArgs e )
        {
            if( testSelectorDropdown.SelectedIndex != -1 )
            {
                string currentlySelectedItem = testSelectorDropdown.SelectedItem as string;

                if ( currentlySelectedItem != null )
                {
                    testSelectedFromDropdown = currentlySelectedItem;

                    if( testLinkedToBuildableDictionary.ContainsKey( currentlySelectedItem ) )
                    {
                        testBuildablePathTextBox.Text = testLinkedToBuildableDictionary[ currentlySelectedItem ];
                        testBuildablePathTextBox.ReadOnly = true;
                        testBuildablePathTextBox.Cursor = Cursors.Arrow;
                    }
                }
            }
        }

        private void testSelectorDropdown_DropDownClosed(object sender, EventArgs e)
        {
            pathToolTip.Hide( testSelectorDropdown );
        }

        private void testSelectorDropdown_DrawItem(object sender, DrawItemEventArgs e)
        {
            if ( e.Index < 0 )
            {
                return;
            }

            string dropdownItemsText = testSelectorDropdown.GetItemText( testSelectorDropdown.Items[ e.Index ] );

            string toolTipText = $"Test executable path: {testDictionary[ testSelectorDropdown.GetItemText( testSelectorDropdown.Items[ e.Index ] ) ]}";

            e.DrawBackground( );

            using ( SolidBrush brush = new SolidBrush( e.ForeColor ) )
            {
                e.Graphics.DrawString( dropdownItemsText, e.Font, brush, e.Bounds );
            }

            if ( (e.State & DrawItemState.Selected ) == DrawItemState.Selected )
            {
                pathToolTip.Show( toolTipText, testSelectorDropdown, e.Bounds.Right, e.Bounds.Bottom );
            }

            e.DrawFocusRectangle();
        }
        private void testRunnerGui_FormClosed( object sender, FormClosedEventArgs e )
        {
            testList.testListNamePath = testListNamePath;
            testList.SerializeTestDictionary( );
        }

        private void editRunOptionsButton_Click( object sender, EventArgs e )
        {
            EditRunOptionsBase editOptionsPopup = new EditRunOptionsBase( );
            editOptionsPopup.ShowDialog( );

            runOptions = new RunOptions( );

            runOptions.DeserializeRunOptions( );

            testRunnerRunOptionsDictionary = runOptions.runOptionsDictionary;

            runOptions.DeserializeRunOptionsBrowserList( );

            testRunnerBrowserList = runOptions.browserList;

            if ( testRunnerBrowserList != null )
            {
                loadDataHandler.PopulateBrowserDropdowns( new List<ComboBox>( ) { runBrowserSelector }, testRunnerBrowserList );
            }

            if ( testRunnerRunOptionsDictionary != null )
            {
                loadDataHandler.SetDefaultBrowser( runBrowserSelector, testRunnerRunOptionsDictionary );
                loadDataHandler.SetMaxAndDefaultValueForWorkerInput( workersNumberSetterInput, testRunnerRunOptionsDictionary );
            }
        }

        private void LogNunitDataToFile( string data )
        {

            string logPath = Path.Combine( GetProjectRootDir( ), "logs" );

            Directory.CreateDirectory( logPath );

            string currentDateString = DateTime.Now.ToString( "yyyyMMdd" );
            string currentTimeString = DateTime.Now.ToString( "HHmmss" );

            string currentLogFile = $"{currentDateString}_{currentTimeString}_TestSharpRunnerGUIlog.txt";

            string logFilePath = Path.Combine( logPath, currentLogFile );

            using ( StreamWriter streamWriter = File.CreateText( logFilePath ) )
            {
                try
                {
                    streamWriter.WriteLine( data );
                }
                catch( InvalidOperationException invalidOpEx )
                {
                    Debug.WriteLine( "Invalid Operation happened while tried to log the console output to a file. Exception message:"
                        + Environment.NewLine + invalidOpEx );
                }
            }
        }

        private void runTestButton_Click( object sender, EventArgs e )
        {
            string msBuildCommand;
            string nunitCommand = null;
            string reportCommand;
            string testExecutablePath = null;
            string workersCommand;

            if( rebuildTestCheckBox.Checked )
            {
                if( testRunnerRunOptionsDictionary.ContainsKey( RunOptionsEnums.MsBuildPath ) )
                {
                    if( !string.IsNullOrEmpty( testBuildablePathTextBox.Text ) )
                    {
                        // Build the given file
                    }
                    else
                    {
                        MessageBox.Show( "Please set path for the project/solution you would like to build in the 'Test csproj or sln path' input field" );
                    }
                }
                else
                {
                    MessageBox.Show( "Please set path for the MSBuild if you would like to rebuild before run" );
                }
            }

            if( !testRunnerRunOptionsDictionary.ContainsKey( RunOptionsEnums.NunitPath ) || string.IsNullOrEmpty( testRunnerRunOptionsDictionary[ RunOptionsEnums.NunitPath ] ) )
            {
                MessageBox.Show( "Please set the path for the nunit3-console.exe file in order to run your test" );
            }
            else
            {
                nunitCommand = testRunnerRunOptionsDictionary[ RunOptionsEnums.NunitPath ];
            }

            ReportCommandBuilder reportCommandBuilder = new ReportCommandBuilder( produceXmlReport, produceTextReport, testRunnerRunOptionsDictionary );

            string reportCommandBuildResult = reportCommandBuilder.BuildReportCommand( );

            reportCommand = !string.IsNullOrEmpty( reportCommandBuildResult ) ? reportCommandBuildResult : "--noresult";

            if( !string.IsNullOrEmpty( currentSelectedPathTextBox.Text ) )
            {
                testExecutablePath = $@"{currentSelectedPathTextBox.Text}";
            }
            else
            {
                MessageBox.Show( "Test executable path is not set." + Environment.NewLine +
                    "Please set by writing it manually to the 'Test executable path' field, or select it with the 'Select test executable from file explorer' button" +
                    Environment.NewLine + "After you added the path, please also click on the 'Set current test' button to finalize your selection!" );
                return;
            }

            string workersNumber = workersNumberSetterInput.Value.ToString( );
            workersCommand = $@"--workers={workersNumber}";

            if( !string.IsNullOrEmpty( nunitCommand ) &&
                !string.IsNullOrEmpty( reportCommand ) &&
                !string.IsNullOrEmpty( workersCommand ) &&
                !string.IsNullOrEmpty( testExecutablePath ) )
            {
                string commandArgs = $@"""{reportCommand}"" ""{workersCommand}"" ""{testExecutablePath}""";

                using ( Process testRunProcess = new Process( ) )
                {
                    ProcessStartInfo testProcessInfo = new ProcessStartInfo( );
                    testProcessInfo.FileName = nunitCommand;
                    testProcessInfo.Arguments = commandArgs;
                    testRunProcess.StartInfo = testProcessInfo;

                    StringBuilder output = new StringBuilder( );

                    testRunProcess.StartInfo.UseShellExecute = false;
                    testRunProcess.StartInfo.RedirectStandardOutput = true;
                    testRunProcess.StartInfo.RedirectStandardError = true;

                    using ( var outputWaitHandle = new AutoResetEvent( false ) )
                    {

                        testRunProcess.OutputDataReceived += ( caller, args ) =>
                        {
                            if ( args.Data == null )
                            {
                                outputWaitHandle.Set( );
                            }
                            else
                            {
                                output.AppendLine( args.Data );
                            }

                        };

                        testRunProcess.ErrorDataReceived += ( caller, args ) =>
                        {
                            if ( args.Data == null )
                            {
                                outputWaitHandle.Set( );
                            }
                            else
                            {
                                output.AppendLine( string.Format( "ERR: {0}", args.Data ) );
                            }
                        };

                        testRunProcess.Start( );

                        testRunProcess.BeginOutputReadLine( );
                        testRunProcess.BeginErrorReadLine( );

                        testRunProcess.WaitForExit( );

                        outputWaitHandle.WaitOne( );

                        if( testRunProcess.ExitCode == 0 )
                        {
                             LogNunitDataToFile( output.ToString( ) );
                        }
                        else
                        {
                            Debug.WriteLine( "Something went wrong while tried to log the nunit data" );
                        }

                    }
                }

            }
            else
            {
                MessageBox.Show( "Something went wrong while tried to run the tests" );
            }

            // TODO - Later implement the browser flag also!
        }


        #endregion

        
    }
}
