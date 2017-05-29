using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TestRunnerGUI.Controllers;
using TestRunnerGUI.Utilities;
using TestRunnerGUI.Utilities.Enums;

namespace TestRunnerGUI.RunOptionsEditorForms
{
    public partial class WorkersOptionEditorForm : Form
    {

        #region Fields

        private Dictionary<RunOptionsEnums, string> editWorkersRunOptionsDictionary = new Dictionary<RunOptionsEnums, string>();

        private decimal workersMaximumNumberInitial;
        private decimal workersDefaultNumberInitial;

        #endregion

        #region ctor

        public WorkersOptionEditorForm( )
        {
            InitializeComponent( );

            workersDefaultNumSuccessfullChangedMessageLabel.Text = string.Empty;
            workersMaximumNumSuccessfullChangedMessageLabel.Text = string.Empty;

            ButtonControl buttonControls = new ButtonControl( );

            saveWorkerOptionsButton.MouseEnter += buttonControls.controlButtons_MouseEnter;
            saveWorkerOptionsButton.MouseLeave += buttonControls.controlButtons_MouseLeave;
        }

        public WorkersOptionEditorForm( Dictionary<RunOptionsEnums, string> editWorkersRunOptionsDictionary )
            : this()
        {
            this.editWorkersRunOptionsDictionary = editWorkersRunOptionsDictionary;

            if ( this.editWorkersRunOptionsDictionary != null )
            {
                DataLoadHandlers loadDataHandler = new DataLoadHandlers( );

                loadDataHandler.SetWorkersMaxAndDefaultNumbers( maxNumberOfWorkersNumericSetter, defaultNumberOfWorkersSetterInput, this.editWorkersRunOptionsDictionary );
            }

            workersMaximumNumberInitial = maxNumberOfWorkersNumericSetter.Value;
            workersDefaultNumberInitial = defaultNumberOfWorkersSetterInput.Value;
        }

        #endregion

        #region Event handlers

        private void saveWorkerOptionsButton_Click( object sender, EventArgs e )
        {
            string maxWorkersNumberText = maxNumberOfWorkersNumericSetter.Value.ToString( );

            DictionaryManipulators handleRunOptionsDictionary = new DictionaryManipulators( );

            if( maxNumberOfWorkersNumericSetter.Value != workersMaximumNumberInitial )
            {
                handleRunOptionsDictionary.AddToDictionary( RunOptionsEnums.WorkersMaximumNumber, maxWorkersNumberText, editWorkersRunOptionsDictionary );

                 workersMaximumNumSuccessfullChangedMessageLabel.Text = $"The new workers maximum number is set to: {maxWorkersNumberText}";
            }

            string defaultWorkersNumberText = defaultNumberOfWorkersSetterInput.Value.ToString( );

            if( defaultNumberOfWorkersSetterInput.Value != workersDefaultNumberInitial )
            {
                handleRunOptionsDictionary.AddToDictionary( RunOptionsEnums.WorkersDefaultNumber, defaultWorkersNumberText, editWorkersRunOptionsDictionary );

                workersDefaultNumSuccessfullChangedMessageLabel.Text = $"The new workers default number is set to: {defaultWorkersNumberText}";
            }

            EditRunOptionsBase editReportRunOptionsBase = new EditRunOptionsBase( true );

            editReportRunOptionsBase.EditFormRunOptionsDictionary = editWorkersRunOptionsDictionary;
        }

        #endregion
    }
}
