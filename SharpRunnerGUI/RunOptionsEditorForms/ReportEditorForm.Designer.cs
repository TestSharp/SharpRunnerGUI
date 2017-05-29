using System.Windows.Forms;

namespace TestRunnerGUI.RunOptionsEditorForms
{
    partial class ReportEditorForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textReportFileName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.saveReportOptionsButton = new System.Windows.Forms.Button();
            this.reportOptionsSuccessfulEditedLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reportOutputPathTextBox = new System.Windows.Forms.TextBox();
            this.reportOutputPathSetterButton = new System.Windows.Forms.Button();
            this.nunitThreeStyleRadioButton = new System.Windows.Forms.RadioButton();
            this.nunitTwoStyleRadioButton = new System.Windows.Forms.RadioButton();
            this.xmlReportFileName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.label1.Location = new System.Drawing.Point(247, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit report options:";
            // 
            // textReportFileName
            // 
            this.textReportFileName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.textReportFileName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textReportFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textReportFileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(221)))), ((int)(((byte)(21)))));
            this.textReportFileName.Location = new System.Drawing.Point(127, 79);
            this.textReportFileName.Name = "textReportFileName";
            this.textReportFileName.Size = new System.Drawing.Size(380, 14);
            this.textReportFileName.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Text report name";
            // 
            // saveReportOptionsButton
            // 
            this.saveReportOptionsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.saveReportOptionsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveReportOptionsButton.FlatAppearance.BorderSize = 0;
            this.saveReportOptionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveReportOptionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.saveReportOptionsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.saveReportOptionsButton.Location = new System.Drawing.Point(255, 400);
            this.saveReportOptionsButton.Name = "saveReportOptionsButton";
            this.saveReportOptionsButton.Size = new System.Drawing.Size(140, 40);
            this.saveReportOptionsButton.TabIndex = 32;
            this.saveReportOptionsButton.Text = "Save report settings";
            this.saveReportOptionsButton.UseVisualStyleBackColor = false;
            this.saveReportOptionsButton.Click += new System.EventHandler(this.saveReportOptionsButton_Click);
            // 
            // reportOptionsSuccessfulEditedLabel
            // 
            this.reportOptionsSuccessfulEditedLabel.AutoSize = true;
            this.reportOptionsSuccessfulEditedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(221)))), ((int)(((byte)(21)))));
            this.reportOptionsSuccessfulEditedLabel.Location = new System.Drawing.Point(217, 466);
            this.reportOptionsSuccessfulEditedLabel.Name = "reportOptionsSuccessfulEditedLabel";
            this.reportOptionsSuccessfulEditedLabel.Size = new System.Drawing.Size(0, 13);
            this.reportOptionsSuccessfulEditedLabel.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.label2.Location = new System.Drawing.Point(34, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Report folder";
            // 
            // reportOutputPathTextBox
            // 
            this.reportOutputPathTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.reportOutputPathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportOutputPathTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.reportOutputPathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.reportOutputPathTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(221)))), ((int)(((byte)(21)))));
            this.reportOutputPathTextBox.Location = new System.Drawing.Point(126, 215);
            this.reportOutputPathTextBox.Multiline = true;
            this.reportOutputPathTextBox.Name = "reportOutputPathTextBox";
            this.reportOutputPathTextBox.ReadOnly = true;
            this.reportOutputPathTextBox.Size = new System.Drawing.Size(380, 90);
            this.reportOutputPathTextBox.TabIndex = 34;
            // 
            // reportOutputPathSetterButton
            // 
            this.reportOutputPathSetterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.reportOutputPathSetterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reportOutputPathSetterButton.FlatAppearance.BorderSize = 0;
            this.reportOutputPathSetterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportOutputPathSetterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.reportOutputPathSetterButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.reportOutputPathSetterButton.Location = new System.Drawing.Point(520, 240);
            this.reportOutputPathSetterButton.Name = "reportOutputPathSetterButton";
            this.reportOutputPathSetterButton.Size = new System.Drawing.Size(118, 40);
            this.reportOutputPathSetterButton.TabIndex = 36;
            this.reportOutputPathSetterButton.Text = "Set with folder browser";
            this.reportOutputPathSetterButton.UseVisualStyleBackColor = false;
            this.reportOutputPathSetterButton.Click += new System.EventHandler(this.reportOutputPathSetterButton_Click);
            // 
            // nunitThreeStyleRadioButton
            // 
            this.nunitThreeStyleRadioButton.AutoSize = true;
            this.nunitThreeStyleRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nunitThreeStyleRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.nunitThreeStyleRadioButton.Location = new System.Drawing.Point(343, 156);
            this.nunitThreeStyleRadioButton.Name = "nunitThreeStyleRadioButton";
            this.nunitThreeStyleRadioButton.Size = new System.Drawing.Size(85, 17);
            this.nunitThreeStyleRadioButton.TabIndex = 40;
            this.nunitThreeStyleRadioButton.Text = "NUnit 3 style";
            this.nunitThreeStyleRadioButton.UseVisualStyleBackColor = true;
            // 
            // nunitTwoStyleRadioButton
            // 
            this.nunitTwoStyleRadioButton.AutoSize = true;
            this.nunitTwoStyleRadioButton.Checked = true;
            this.nunitTwoStyleRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nunitTwoStyleRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.nunitTwoStyleRadioButton.Location = new System.Drawing.Point(212, 156);
            this.nunitTwoStyleRadioButton.Name = "nunitTwoStyleRadioButton";
            this.nunitTwoStyleRadioButton.Size = new System.Drawing.Size(85, 17);
            this.nunitTwoStyleRadioButton.TabIndex = 39;
            this.nunitTwoStyleRadioButton.TabStop = true;
            this.nunitTwoStyleRadioButton.Text = "NUnit 2 style";
            this.nunitTwoStyleRadioButton.UseVisualStyleBackColor = true;
            // 
            // xmlReportFileName
            // 
            this.xmlReportFileName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.xmlReportFileName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.xmlReportFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.xmlReportFileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(221)))), ((int)(((byte)(21)))));
            this.xmlReportFileName.Location = new System.Drawing.Point(126, 124);
            this.xmlReportFileName.Name = "xmlReportFileName";
            this.xmlReportFileName.Size = new System.Drawing.Size(380, 14);
            this.xmlReportFileName.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.label5.Location = new System.Drawing.Point(12, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 37;
            this.label5.Text = "XML report name";
            // 
            // ReportEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(650, 500);
            this.Controls.Add(this.textReportFileName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nunitThreeStyleRadioButton);
            this.Controls.Add(this.nunitTwoStyleRadioButton);
            this.Controls.Add(this.xmlReportFileName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reportOutputPathTextBox);
            this.Controls.Add(this.reportOutputPathSetterButton);
            this.Controls.Add(this.reportOptionsSuccessfulEditedLabel);
            this.Controls.Add(this.saveReportOptionsButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportEditorForm";
            this.Text = "ReportEditorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textReportFileName;
        private Label label3;
        private Button saveReportOptionsButton;
        private Label reportOptionsSuccessfulEditedLabel;
        private Label label2;
        private TextBox reportOutputPathTextBox;
        private Button reportOutputPathSetterButton;
        private RadioButton nunitThreeStyleRadioButton;
        private RadioButton nunitTwoStyleRadioButton;
        private TextBox xmlReportFileName;
        private Label label5;
    }
}