using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using TestRunnerGUI.Utilities.Enums;

namespace TestRunnerGUI
{
    [Serializable( )]
    public class RunOptions
    {
        public Dictionary<RunOptionsEnums, string> runOptionsDictionary { get; set; }

        public List<string> browserList { get; set; }


        public RunOptions()
        {

        }

        public RunOptions( Dictionary<RunOptionsEnums, string> runOptionsDict, List<string> runBrowserList )
        {
            runOptionsDictionary = runOptionsDict;
            browserList = new List<string>( );
            browserList.Clear( );
            browserList = runBrowserList;
        }


        public bool SerializeRunOptionsDictionary()
        {
            try
            {
                string currentAssemblyDirectory = AppDomain.CurrentDomain.BaseDirectory;

                if ( currentAssemblyDirectory.Contains ( "bin" ) )
                {
                    string stringToReplace = currentAssemblyDirectory.Substring( currentAssemblyDirectory.IndexOf( "bin", StringComparison.Ordinal ) - 1 );
                    currentAssemblyDirectory = currentAssemblyDirectory.Replace ( stringToReplace, "" );
                }

                string testRunnerDataDirectory = Path.Combine( currentAssemblyDirectory, "TestRunnerData" );

                Directory.CreateDirectory( testRunnerDataDirectory );

                string serializedFilePath = Path.Combine( testRunnerDataDirectory, "runopt.bin" );

                using (Stream stream = File.Open( serializedFilePath, FileMode.Create ) )
                {
                    BinaryFormatter bin = new BinaryFormatter( );
                    bin.Serialize( stream, runOptionsDictionary );
                }

                return true;
            }
            catch ( IOException ioEx )
            {
                Debug.WriteLine( "Exception happened, while tried to serialize object. Exception message: " + ioEx );
                Console.WriteLine( "Exception happened, while tried to serialize object. Exception message: " + ioEx );

                return false;
            }
        }

        public bool SerializeRunOptionsBrowserList()
        {
            try
            {
                string currentAssemblyDirectory = AppDomain.CurrentDomain.BaseDirectory;

                if ( currentAssemblyDirectory.Contains ( "bin" ) )
                {
                    string stringToReplace = currentAssemblyDirectory.Substring( currentAssemblyDirectory.IndexOf( "bin", StringComparison.Ordinal ) - 1 );
                    currentAssemblyDirectory = currentAssemblyDirectory.Replace ( stringToReplace, "" );
                }

                string testRunnerDataDirectory = Path.Combine( currentAssemblyDirectory, "TestRunnerData" );

                Directory.CreateDirectory( testRunnerDataDirectory );

                string serializedFilePath = Path.Combine( testRunnerDataDirectory, "browsers.bin" );

                using (Stream stream = File.Open( serializedFilePath, FileMode.Create ) )
                {
                    BinaryFormatter bin = new BinaryFormatter( );
                    bin.Serialize( stream, browserList          );
                }

                return true;
            }
            catch ( IOException ioEx )
            {
                Debug.WriteLine( "Exception happened, while tried to serialize object. Exception message: " + ioEx );
                Console.WriteLine( "Exception happened, while tried to serialize object. Exception message: " + ioEx );

                return false;
            }
        }

        public void DeserializeRunOptions()
        {
            try
            {
                string currentAssemblyDirectory = AppDomain.CurrentDomain.BaseDirectory;

                if ( currentAssemblyDirectory.Contains ( "bin" ) )
                {
                    string stringToReplace = currentAssemblyDirectory.Substring( currentAssemblyDirectory.IndexOf( "bin", StringComparison.Ordinal ) - 1 );
                    currentAssemblyDirectory = currentAssemblyDirectory.Replace ( stringToReplace, "" );
                }

                string testRunnerDataDirectory = Path.Combine( currentAssemblyDirectory, "TestRunnerData" );

                string serializedFilePath = Path.Combine( testRunnerDataDirectory, "runopt.bin" );

                if ( File.Exists( serializedFilePath ) )
                {
                    using ( Stream stream = File.Open( serializedFilePath, FileMode.Open ) )
                    {
                        BinaryFormatter bin = new BinaryFormatter( );

                        runOptionsDictionary = ( Dictionary<RunOptionsEnums, string> ) bin.Deserialize( stream );
                    }
                }
            }
            catch ( IOException ioEx )
            {
                Debug.WriteLine( "Exception happened, while tried to serialize object. Exception message: " + ioEx );
                Console.WriteLine( "Exception happened, while tried to serialize object. Exception message: " + ioEx );
            }
        }

        public void DeserializeRunOptionsBrowserList()
        {
            try
            {
                string currentAssemblyDirectory = AppDomain.CurrentDomain.BaseDirectory;

                if ( currentAssemblyDirectory.Contains ( "bin" ) )
                {
                    string stringToReplace = currentAssemblyDirectory.Substring( currentAssemblyDirectory.IndexOf( "bin", StringComparison.Ordinal ) - 1 );
                    currentAssemblyDirectory = currentAssemblyDirectory.Replace ( stringToReplace, "" );
                }

                string testRunnerDataDirectory = Path.Combine( currentAssemblyDirectory, "TestRunnerData" );

                string serializedFilePath = Path.Combine( testRunnerDataDirectory, "browsers.bin" );

                if ( File.Exists( serializedFilePath ) )
                {
                    using ( Stream stream = File.Open( serializedFilePath, FileMode.Open ) )
                    {
                        BinaryFormatter bin = new BinaryFormatter( );

                        browserList = ( List<string> ) bin.Deserialize( stream );
                    }
                }
            }
            catch ( IOException ioEx )
            {
                Debug.WriteLine( "Exception happened, while tried to serialize object. Exception message: " + ioEx );
                Console.WriteLine( "Exception happened, while tried to serialize object. Exception message: " + ioEx );
            }
        }

    }
}
