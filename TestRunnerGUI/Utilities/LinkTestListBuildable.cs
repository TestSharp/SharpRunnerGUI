using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace TestRunnerGUI.Utilities
{
    [Serializable( )]
    public class LinkTestListBuildable
    {
        #region Fields
        public Dictionary<string, string> testNameBuildableDictionary { get; set; }
        #endregion

        #region ctor
        public LinkTestListBuildable( Dictionary<string,string> myTestBuildableDictionary )
        {
            testNameBuildableDictionary = myTestBuildableDictionary;
        }

        public LinkTestListBuildable( )
        { }

        #endregion

        public void SerializeTestDictionary()
        {
            try
            {
                string currentAssemblyDirectory = AppDomain.CurrentDomain.BaseDirectory;

                string serializedFilePath = currentAssemblyDirectory + "testbuildable.bin";

                using (Stream stream = File.Open( serializedFilePath, FileMode.Create ) )
                {
                    BinaryFormatter bin = new BinaryFormatter( );
                    bin.Serialize( stream, testNameBuildableDictionary );
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

                string serializedFilePath = currentAssemblyDirectory + "testbuildable.bin";

                if ( File.Exists( serializedFilePath ) )
                {
                    using ( Stream stream = File.Open( serializedFilePath, FileMode.Open ) )
                    {
                        BinaryFormatter bin = new BinaryFormatter( );

                        testNameBuildableDictionary = ( Dictionary<string, string> ) bin.Deserialize( stream );
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
