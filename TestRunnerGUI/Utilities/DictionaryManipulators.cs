using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TestRunnerGUI.Utilities.Enums;

namespace TestRunnerGUI.Utilities
{
    public class DictionaryManipulators
    {

        public void EditTestDictionary( string selectedTestName, string newTestName, string newTestPath )
        {
            string selectedTestPath = TestRunnerGUI.testDictionary[ selectedTestName ];

            bool givenNameIsEmptyOrEqualsSelected = newTestName == "" || newTestName == selectedTestName;

            bool givenPathIsEmptyOrEqualsSelectedTestPath = newTestPath == "" || newTestPath == selectedTestPath;

            if( givenNameIsEmptyOrEqualsSelected && givenPathIsEmptyOrEqualsSelectedTestPath )
            {
                MessageBox.Show( "You gave the same parameters for the test as it were previously."
                    + Environment.NewLine + "Please add different parameter(s)." );
            }
            else if ( givenNameIsEmptyOrEqualsSelected && !string.IsNullOrEmpty( newTestPath ) )
            {
                TestRunnerGUI.testDictionary[ selectedTestName ] = newTestPath;
            }
            else if( !string.IsNullOrEmpty( newTestName ) )
            {
                TestRunnerGUI.testDictionary.Remove( selectedTestName );
                TestRunnerGUI.testDictionary.Add( newTestName, newTestPath );
            }
        }

        public bool AddLinkedTestWithBuildableDictionary( string currentSelectedTestName, string currentSelectedBuildablePath, Dictionary<string, string> testNameAndBuildableDictionary )
        {
            if ( !string.IsNullOrEmpty( currentSelectedTestName ) && !string.IsNullOrEmpty( currentSelectedBuildablePath ) && testNameAndBuildableDictionary != null )
            {
                if ( testNameAndBuildableDictionary.ContainsKey( currentSelectedTestName ) )
                {
                    testNameAndBuildableDictionary.Remove( currentSelectedTestName );
                }

                testNameAndBuildableDictionary.Add( currentSelectedTestName, currentSelectedBuildablePath );

                return true;
            }

            return false;
        }

        public bool AddToDictionary( RunOptionsEnums key, string value, Dictionary<RunOptionsEnums, string> runOptionsDictionary )
        {
            if( !string.IsNullOrEmpty( value ) )
            {
                if ( runOptionsDictionary.ContainsKey( key ) )
                {
                    if ( runOptionsDictionary[ key ] == value )
                    {
                        return false;
                    }

                    runOptionsDictionary.Remove( key );
                    runOptionsDictionary.Add( key, value );
                }
                else
                {
                    runOptionsDictionary.Add( key, value );
                }

                return true;
            }

            return false;
        }

    }
}
