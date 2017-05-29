namespace TestRunnerGUI.TestListEditorForms
{
    partial class LinkBuildableForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.testListDropdown = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pathToBuildableTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.selectBuildablePathButton = new System.Windows.Forms.Button();
            this.saveBuildableLinkedButton = new System.Windows.Forms.Button();
            this.testBuildableSuccessfulLinkedMessage = new System.Windows.Forms.Label();
            this.removedLinkButton = new System.Windows.Forms.Button();
            this.buildablePathTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.label1.Location = new System.Drawing.Point(179, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Link project or solution file to a test";
            // 
            // testListDropdown
            // 
            this.testListDropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.testListDropdown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.testListDropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.testListDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.testListDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testListDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.testListDropdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(221)))), ((int)(((byte)(21)))));
            this.testListDropdown.FormattingEnabled = true;
            this.testListDropdown.Location = new System.Drawing.Point(260, 78);
            this.testListDropdown.Name = "testListDropdown";
            this.testListDropdown.Size = new System.Drawing.Size(314, 23);
            this.testListDropdown.TabIndex = 34;
            this.testListDropdown.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.testListDropdown_DrawItem);
            this.testListDropdown.DropDownClosed += new System.EventHandler(this.testListDropdown_DropDownClosed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(101)))), ((int)(((byte)(211)))));
            this.label2.Location = new System.Drawing.Point(25, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Select the test you would like to link to";
            // 
            // pathToBuildableTextBox
            // 
            this.pathToBuildableTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pathToBuildableTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pathToBuildableTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pathToBuildableTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pathToBuildableTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(221)))), ((int)(((byte)(21)))));
            this.pathToBuildableTextBox.Location = new System.Drawing.Point(260, 144);
            this.pathToBuildableTextBox.Multiline = true;
            this.pathToBuildableTextBox.Name = "pathToBuildableTextBox";
            this.pathToBuildableTextBox.Size = new System.Drawing.Size(314, 90);
            this.pathToBuildableTextBox.TabIndex = 36;
            this.pathToBuildableTextBox.DoubleClick += new System.EventHandler(this.pathToBuildableTextBox_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(101)))), ((int)(((byte)(211)))));
            this.label3.Location = new System.Drawing.Point(25, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "Set a path to a solution or project file";
            // 
            // selectBuildablePathButton
            // 
            this.selectBuildablePathButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.selectBuildablePathButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectBuildablePathButton.FlatAppearance.BorderSize = 0;
            this.selectBuildablePathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectBuildablePathButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectBuildablePathButton.Location = new System.Drawing.Point(266, 260);
            this.selectBuildablePathButton.Name = "selectBuildablePathButton";
            this.selectBuildablePathButton.Size = new System.Drawing.Size(118, 58);
            this.selectBuildablePathButton.TabIndex = 40;
            this.selectBuildablePathButton.Text = "Select buildable path from File explorer";
            this.selectBuildablePathButton.UseVisualStyleBackColor = false;
            this.selectBuildablePathButton.Click += new System.EventHandler(this.selectBuildablePathButton_Click);
            // 
            // saveBuildableLinkedButton
            // 
            this.saveBuildableLinkedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.saveBuildableLinkedButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBuildableLinkedButton.FlatAppearance.BorderSize = 0;
            this.saveBuildableLinkedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBuildableLinkedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.saveBuildableLinkedButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.saveBuildableLinkedButton.Location = new System.Drawing.Point(225, 350);
            this.saveBuildableLinkedButton.Name = "saveBuildableLinkedButton";
            this.saveBuildableLinkedButton.Size = new System.Drawing.Size(80, 50);
            this.saveBuildableLinkedButton.TabIndex = 41;
            this.saveBuildableLinkedButton.Text = "Save";
            this.saveBuildableLinkedButton.UseVisualStyleBackColor = false;
            this.saveBuildableLinkedButton.Click += new System.EventHandler(this.saveBuildableLinkedButton_Click);
            // 
            // testBuildableSuccessfulLinkedMessage
            // 
            this.testBuildableSuccessfulLinkedMessage.AutoSize = true;
            this.testBuildableSuccessfulLinkedMessage.Location = new System.Drawing.Point(250, 420);
            this.testBuildableSuccessfulLinkedMessage.Name = "testBuildableSuccessfulLinkedMessage";
            this.testBuildableSuccessfulLinkedMessage.Size = new System.Drawing.Size(35, 13);
            this.testBuildableSuccessfulLinkedMessage.TabIndex = 42;
            this.testBuildableSuccessfulLinkedMessage.Text = "label4";
            // 
            // removedLinkButton
            // 
            this.removedLinkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.removedLinkButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removedLinkButton.FlatAppearance.BorderSize = 0;
            this.removedLinkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removedLinkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.removedLinkButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.removedLinkButton.Location = new System.Drawing.Point(345, 350);
            this.removedLinkButton.Name = "removedLinkButton";
            this.removedLinkButton.Size = new System.Drawing.Size(80, 50);
            this.removedLinkButton.TabIndex = 43;
            this.removedLinkButton.Text = "Remove link";
            this.removedLinkButton.UseVisualStyleBackColor = false;
            this.removedLinkButton.Click += new System.EventHandler(this.removedLinkButton_Click);
            // 
            // LinkBuildableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(650, 500);
            this.Controls.Add(this.removedLinkButton);
            this.Controls.Add(this.testBuildableSuccessfulLinkedMessage);
            this.Controls.Add(this.saveBuildableLinkedButton);
            this.Controls.Add(this.selectBuildablePathButton);
            this.Controls.Add(this.pathToBuildableTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.testListDropdown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LinkBuildableForm";
            this.Text = "LinkBuildableForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox pathToBuildableTextBox;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox testListDropdown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button selectBuildablePathButton;
        private System.Windows.Forms.Button saveBuildableLinkedButton;
        private System.Windows.Forms.Label testBuildableSuccessfulLinkedMessage;
        private System.Windows.Forms.Button removedLinkButton;
        private System.Windows.Forms.ToolTip buildablePathTooltip;
    }
}