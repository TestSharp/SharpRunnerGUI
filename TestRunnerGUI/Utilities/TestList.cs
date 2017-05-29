using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace TestRunnerGUI
{
    [Serializable( )]
    public class TestList
    {
        public Dictionary<string, string> testListNamePath { get; set; }

        public TestList( Dictionary<string,string> myTestDictionary )
        {
            testListNamePath = myTestDictionary;
        }

        public void SerializeTestDictionary()
        {

            try
            {
                string currentAssemblyDirectory = AppDomain.CurrentDomain.BaseDirectory;

                if ( currentAssemblyDirectory.Contains ( "bin" ) )
                {
                    string stringToReplace = currentAssemblyDirectory.Substring( currentAssemblyDirectory.IndexOf( "bin", StringComparison.Ordinal ) - 1 );
                    currentAssemblyDirectory = currentAssemblyDirectory.Replace ( stringToReplace, "" );
                }

                string testRunnerDataDirectory = Path.Combine( currentAssemblyDirectory, "SharpRunnerData" );

                Directory.CreateDirectory( testRunnerDataDirectory );

                string serializedFilePath = Path.Combine( testRunnerDataDirectory, "testlist.bin" );

                using (Stream stream = File.Open( serializedFilePath, FileMode.Create ) )
                {
                    BinaryFormatter bin = new BinaryFormatter( );
                    bin.Serialize( stream, testListNamePath );
                }
            }
            catch ( IOException ioEx )
            {
                Debug.WriteLine( "Exception happened, while tried to serialize object. Exception message: " + ioEx );
                Console.WriteLine( "Exception happened, while tried to serialize object. Exception message: " + ioEx );
            }
        }

        public void DeserializeTestDictionary()
        {
            try
            {
                string currentAssemblyDirectory = AppDomain.CurrentDomain.BaseDirectory;

                if ( currentAssemblyDirectory.Contains ( "bin" ) )
                {
                    string stringToReplace = currentAssemblyDirectory.Substring( currentAssemblyDirectory.IndexOf( "bin", StringComparison.Ordinal ) - 1 );
                    currentAssemblyDirectory = currentAssemblyDirectory.Replace ( stringToReplace, "" );
                }

                string testRunnerDataDirectory = Path.Combine( currentAssemblyDirectory, "SharpRunnerData" );

                string serializedFilePath = Path.Combine( testRunnerDataDirectory, "testlist.bin" );

                if ( File.Exists( serializedFilePath ) )
                {
                    using ( Stream stream = File.Open( serializedFilePath, FileMode.Open ) )
                    {
                        BinaryFormatter bin = new BinaryFormatter( );

                        testListNamePath = ( Dictionary<string, string> ) bin.Deserialize( stream );
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
