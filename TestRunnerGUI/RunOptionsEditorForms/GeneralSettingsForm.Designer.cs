namespace TestRunnerGUI.RunOptionsEditorForms
{
    partial class GeneralSettingsForm
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
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.msBuildPathTextBox = new System.Windows.Forms.TextBox();
            this.nunitPathTextBox = new System.Windows.Forms.TextBox();
            this.selectMsBuildPathButton = new System.Windows.Forms.Button();
            this.selectNunitPathButton = new System.Windows.Forms.Button();
            this.saveGeneralSettingsButton = new System.Windows.Forms.Button();
            this.msBuildPathChangeMessageLabel1 = new System.Windows.Forms.Label();
            this.nunitPathChangeMessageLabel1 = new System.Windows.Forms.Label();
            this.msBuildPathChangeMessageLabel2 = new System.Windows.Forms.Label();
            this.nunitPathChangeMessageLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.label1.Location = new System.Drawing.Point(253, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "General Settings";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.label7.Location = new System.Drawing.Point(12, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 16);
            this.label7.TabIndex = 33;
            this.label7.Text = "Set MSBuild\'s path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.label2.Location = new System.Drawing.Point(8, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Set NUnit\'s path:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.label3.Location = new System.Drawing.Point(8, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "(nunit3-console.exe)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.label4.Location = new System.Drawing.Point(12, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "(MSBuild.exe)";
            // 
            // msBuildPathTextBox
            // 
            this.msBuildPathTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.msBuildPathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.msBuildPathTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.msBuildPathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.msBuildPathTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(221)))), ((int)(((byte)(21)))));
            this.msBuildPathTextBox.Location = new System.Drawing.Point(141, 138);
            this.msBuildPathTextBox.Multiline = true;
            this.msBuildPathTextBox.Name = "msBuildPathTextBox";
            this.msBuildPathTextBox.Size = new System.Drawing.Size(360, 60);
            this.msBuildPathTextBox.TabIndex = 37;
            this.msBuildPathTextBox.DoubleClick += new System.EventHandler(this.msBuildPathTextBox_DoubleClick);
            // 
            // nunitPathTextBox
            // 
            this.nunitPathTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.nunitPathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nunitPathTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nunitPathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nunitPathTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(221)))), ((int)(((byte)(21)))));
            this.nunitPathTextBox.Location = new System.Drawing.Point(141, 260);
            this.nunitPathTextBox.Multiline = true;
            this.nunitPathTextBox.Name = "nunitPathTextBox";
            this.nunitPathTextBox.Size = new System.Drawing.Size(360, 60);
            this.nunitPathTextBox.TabIndex = 38;
            this.nunitPathTextBox.DoubleClick += new System.EventHandler(this.nunitPathTextBox_DoubleClick);
            // 
            // selectMsBuildPathButton
            // 
            this.selectMsBuildPathButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.selectMsBuildPathButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectMsBuildPathButton.FlatAppearance.BorderSize = 0;
            this.selectMsBuildPathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectMsBuildPathButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectMsBuildPathButton.Location = new System.Drawing.Point(520, 138);
            this.selectMsBuildPathButton.Name = "selectMsBuildPathButton";
            this.selectMsBuildPathButton.Size = new System.Drawing.Size(118, 58);
            this.selectMsBuildPathButton.TabIndex = 39;
            this.selectMsBuildPathButton.Text = "Select MSBuild Path from File explorer";
            this.selectMsBuildPathButton.UseVisualStyleBackColor = false;
            this.selectMsBuildPathButton.Click += new System.EventHandler(this.selectMsBuildPathButton_Click);
            // 
            // selectNunitPathButton
            // 
            this.selectNunitPathButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.selectNunitPathButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectNunitPathButton.FlatAppearance.BorderSize = 0;
            this.selectNunitPathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectNunitPathButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectNunitPathButton.Location = new System.Drawing.Point(520, 260);
            this.selectNunitPathButton.Name = "selectNunitPathButton";
            this.selectNunitPathButton.Size = new System.Drawing.Size(118, 58);
            this.selectNunitPathButton.TabIndex = 41;
            this.selectNunitPathButton.Text = "Select NUnit Path from File explorer";
            this.selectNunitPathButton.UseVisualStyleBackColor = false;
            this.selectNunitPathButton.Click += new System.EventHandler(this.selectNunitPathButton_Click);
            // 
            // saveGeneralSettingsButton
            // 
            this.saveGeneralSettingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.saveGeneralSettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveGeneralSettingsButton.FlatAppearance.BorderSize = 0;
            this.saveGeneralSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveGeneralSettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.saveGeneralSettingsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.saveGeneralSettingsButton.Location = new System.Drawing.Point(255, 340);
            this.saveGeneralSettingsButton.Name = "saveGeneralSettingsButton";
            this.saveGeneralSettingsButton.Size = new System.Drawing.Size(140, 40);
            this.saveGeneralSettingsButton.TabIndex = 42;
            this.saveGeneralSettingsButton.Text = "Save general settings";
            this.saveGeneralSettingsButton.UseVisualStyleBackColor = false;
            this.saveGeneralSettingsButton.Click += new System.EventHandler(this.saveBrowserOptionsButton_Click);
            // 
            // msBuildPathChangeMessageLabel1
            // 
            this.msBuildPathChangeMessageLabel1.AutoSize = true;
            this.msBuildPathChangeMessageLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.msBuildPathChangeMessageLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.msBuildPathChangeMessageLabel1.Location = new System.Drawing.Point(110, 400);
            this.msBuildPathChangeMessageLabel1.Name = "msBuildPathChangeMessageLabel1";
            this.msBuildPathChangeMessageLabel1.Size = new System.Drawing.Size(0, 16);
            this.msBuildPathChangeMessageLabel1.TabIndex = 43;
            // 
            // nunitPathChangeMessageLabel1
            // 
            this.nunitPathChangeMessageLabel1.AutoSize = true;
            this.nunitPathChangeMessageLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nunitPathChangeMessageLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.nunitPathChangeMessageLabel1.Location = new System.Drawing.Point(225, 450);
            this.nunitPathChangeMessageLabel1.Name = "nunitPathChangeMessageLabel1";
            this.nunitPathChangeMessageLabel1.Size = new System.Drawing.Size(0, 16);
            this.nunitPathChangeMessageLabel1.TabIndex = 44;
            // 
            // msBuildPathChangeMessageLabel2
            // 
            this.msBuildPathChangeMessageLabel2.AutoSize = true;
            this.msBuildPathChangeMessageLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.msBuildPathChangeMessageLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.msBuildPathChangeMessageLabel2.Location = new System.Drawing.Point(239, 416);
            this.msBuildPathChangeMessageLabel2.Name = "msBuildPathChangeMessageLabel2";
            this.msBuildPathChangeMessageLabel2.Size = new System.Drawing.Size(0, 16);
            this.msBuildPathChangeMessageLabel2.TabIndex = 45;
            // 
            // nunitPathChangeMessageLabel2
            // 
            this.nunitPathChangeMessageLabel2.AutoSize = true;
            this.nunitPathChangeMessageLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nunitPathChangeMessageLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.nunitPathChangeMessageLabel2.Location = new System.Drawing.Point(221, 466);
            this.nunitPathChangeMessageLabel2.Name = "nunitPathChangeMessageLabel2";
            this.nunitPathChangeMessageLabel2.Size = new System.Drawing.Size(0, 16);
            this.nunitPathChangeMessageLabel2.TabIndex = 46;
            // 
            // GeneralSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(650, 500);
            this.Controls.Add(this.nunitPathChangeMessageLabel2);
            this.Controls.Add(this.msBuildPathChangeMessageLabel2);
            this.Controls.Add(this.nunitPathChangeMessageLabel1);
            this.Controls.Add(this.msBuildPathChangeMessageLabel1);
            this.Controls.Add(this.saveGeneralSettingsButton);
            this.Controls.Add(this.selectNunitPathButton);
            this.Controls.Add(this.selectMsBuildPathButton);
            this.Controls.Add(this.nunitPathTextBox);
            this.Controls.Add(this.msBuildPathTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GeneralSettingsForm";
            this.Text = "GeneralSettingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox msBuildPathTextBox;
        private System.Windows.Forms.TextBox nunitPathTextBox;
        private System.Windows.Forms.Button selectMsBuildPathButton;
        private System.Windows.Forms.Button selectNunitPathButton;
        private System.Windows.Forms.Button saveGeneralSettingsButton;
        private System.Windows.Forms.Label msBuildPathChangeMessageLabel1;
        private System.Windows.Forms.Label nunitPathChangeMessageLabel1;
        private System.Windows.Forms.Label msBuildPathChangeMessageLabel2;
        private System.Windows.Forms.Label nunitPathChangeMessageLabel2;
    }
}