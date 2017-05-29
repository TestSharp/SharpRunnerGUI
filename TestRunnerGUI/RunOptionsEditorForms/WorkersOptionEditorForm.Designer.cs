using System.Windows.Forms;

namespace TestRunnerGUI.RunOptionsEditorForms
{
    partial class WorkersOptionEditorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            this.groupBox1 = new GroupBox();
            this.maxNumberOfWorkersNumericSetter = new NumericUpDown();
            this.label9 = new Label();
            this.label6 = new Label();
            this.defaultNumberOfWorkersSetterInput = new NumericUpDown();
            this.label1 = new Label();
            this.saveWorkerOptionsButton = new Button();
            this.workersDefaultNumSuccessfullChangedMessageLabel = new Label();
            this.workersMaximumNumSuccessfullChangedMessageLabel = new Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxNumberOfWorkersNumericSetter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultNumberOfWorkersSetterInput)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maxNumberOfWorkersNumericSetter);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.defaultNumberOfWorkersSetterInput);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.groupBox1.Location = new System.Drawing.Point(21, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 200);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Workers options";
            // 
            // maxNumberOfWorkersNumericSetter
            // 
            this.maxNumberOfWorkersNumericSetter.BackColor = System.Drawing.Color.Black;
            this.maxNumberOfWorkersNumericSetter.Cursor = Cursors.Hand;
            this.maxNumberOfWorkersNumericSetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maxNumberOfWorkersNumericSetter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.maxNumberOfWorkersNumericSetter.Location = new System.Drawing.Point(360, 122);
            this.maxNumberOfWorkersNumericSetter.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.maxNumberOfWorkersNumericSetter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxNumberOfWorkersNumericSetter.Name = "maxNumberOfWorkersNumericSetter";
            this.maxNumberOfWorkersNumericSetter.Size = new System.Drawing.Size(45, 22);
            this.maxNumberOfWorkersNumericSetter.TabIndex = 30;
            this.maxNumberOfWorkersNumericSetter.TextAlign = HorizontalAlignment.Center;
            this.maxNumberOfWorkersNumericSetter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.label9.Location = new System.Drawing.Point(176, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 16);
            this.label9.TabIndex = 29;
            this.label9.Text = "Maximum number of workers";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.label6.Location = new System.Drawing.Point(183, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Default number of workers";
            // 
            // defaultNumberOfWorkersSetterInput
            // 
            this.defaultNumberOfWorkersSetterInput.BackColor = System.Drawing.Color.Black;
            this.defaultNumberOfWorkersSetterInput.Cursor = Cursors.Hand;
            this.defaultNumberOfWorkersSetterInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.defaultNumberOfWorkersSetterInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.defaultNumberOfWorkersSetterInput.Location = new System.Drawing.Point(350, 52);
            this.defaultNumberOfWorkersSetterInput.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.defaultNumberOfWorkersSetterInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.defaultNumberOfWorkersSetterInput.Name = "defaultNumberOfWorkersSetterInput";
            this.defaultNumberOfWorkersSetterInput.Size = new System.Drawing.Size(45, 22);
            this.defaultNumberOfWorkersSetterInput.TabIndex = 19;
            this.defaultNumberOfWorkersSetterInput.TextAlign = HorizontalAlignment.Center;
            this.defaultNumberOfWorkersSetterInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.label1.Location = new System.Drawing.Point(245, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Edit workers options:";
            // 
            // saveWorkerOptionsButton
            // 
            this.saveWorkerOptionsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.saveWorkerOptionsButton.Cursor = Cursors.Hand;
            this.saveWorkerOptionsButton.FlatAppearance.BorderSize = 0;
            this.saveWorkerOptionsButton.FlatStyle = FlatStyle.Flat;
            this.saveWorkerOptionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.saveWorkerOptionsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.saveWorkerOptionsButton.Location = new System.Drawing.Point(255, 340);
            this.saveWorkerOptionsButton.Name = "saveWorkerOptionsButton";
            this.saveWorkerOptionsButton.Size = new System.Drawing.Size(140, 40);
            this.saveWorkerOptionsButton.TabIndex = 34;
            this.saveWorkerOptionsButton.Text = "Save workers settings";
            this.saveWorkerOptionsButton.UseVisualStyleBackColor = false;
            this.saveWorkerOptionsButton.Click += new System.EventHandler(this.saveWorkerOptionsButton_Click);
            // 
            // workersDefaultNumSuccessfullChangedMessageLabel
            // 
            this.workersDefaultNumSuccessfullChangedMessageLabel.AutoSize = true;
            this.workersDefaultNumSuccessfullChangedMessageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(221)))), ((int)(((byte)(21)))));
            this.workersDefaultNumSuccessfullChangedMessageLabel.Location = new System.Drawing.Point(220, 416);
            this.workersDefaultNumSuccessfullChangedMessageLabel.Name = "workersDefaultNumSuccessfullChangedMessageLabel";
            this.workersDefaultNumSuccessfullChangedMessageLabel.Size = new System.Drawing.Size(0, 13);
            this.workersDefaultNumSuccessfullChangedMessageLabel.TabIndex = 35;
            // 
            // workersMaximumNumSuccessfullChangedMessageLabel
            // 
            this.workersMaximumNumSuccessfullChangedMessageLabel.AutoSize = true;
            this.workersMaximumNumSuccessfullChangedMessageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(221)))), ((int)(((byte)(21)))));
            this.workersMaximumNumSuccessfullChangedMessageLabel.Location = new System.Drawing.Point(215, 442);
            this.workersMaximumNumSuccessfullChangedMessageLabel.Name = "workersMaximumNumSuccessfullChangedMessageLabel";
            this.workersMaximumNumSuccessfullChangedMessageLabel.Size = new System.Drawing.Size(0, 13);
            this.workersMaximumNumSuccessfullChangedMessageLabel.TabIndex = 36;
            // 
            // WorkersOptionEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(650, 500);
            this.Controls.Add(this.workersMaximumNumSuccessfullChangedMessageLabel);
            this.Controls.Add(this.workersDefaultNumSuccessfullChangedMessageLabel);
            this.Controls.Add(this.saveWorkerOptionsButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.FormBorderStyle = FormBorderStyle.None;
            this.Name = "WorkersOptionEditorForm";
            this.Text = "WorkersOptionEditorForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxNumberOfWorkersNumericSetter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultNumberOfWorkersSetterInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private NumericUpDown maxNumberOfWorkersNumericSetter;
        private Label label9;
        private Label label6;
        private NumericUpDown defaultNumberOfWorkersSetterInput;
        private Label label1;
        private Button saveWorkerOptionsButton;
        private Label workersDefaultNumSuccessfullChangedMessageLabel;
        private Label workersMaximumNumSuccessfullChangedMessageLabel;
    }
}