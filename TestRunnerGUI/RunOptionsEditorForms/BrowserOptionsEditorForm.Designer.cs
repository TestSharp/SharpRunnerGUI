using System.Windows.Forms;

namespace TestRunnerGUI.RunOptionsEditorForms
{
    partial class BrowserOptionsEditorForm
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
            this.browserOptionsGroupBox = new GroupBox();
            this.removeBrowserFromListButton = new Button();
            this.addNewBrowserButton = new Button();
            this.label8 = new Label();
            this.defaultBrowserSelector = new ComboBox();
            this.label7 = new Label();
            this.newBrowserTextBox = new TextBox();
            this.label1 = new Label();
            this.saveBrowserOptionsButton = new Button();
            this.browserOptionsSuccessfullChangeMessageLabel = new Label();
            this.label2 = new Label();
            this.browserListToRemoveBrowser = new ComboBox();
            this.browserOptionsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // browserOptionsGroupBox
            // 
            this.browserOptionsGroupBox.Controls.Add(this.browserListToRemoveBrowser);
            this.browserOptionsGroupBox.Controls.Add(this.label2);
            this.browserOptionsGroupBox.Controls.Add(this.removeBrowserFromListButton);
            this.browserOptionsGroupBox.Controls.Add(this.addNewBrowserButton);
            this.browserOptionsGroupBox.Controls.Add(this.label8);
            this.browserOptionsGroupBox.Controls.Add(this.defaultBrowserSelector);
            this.browserOptionsGroupBox.Controls.Add(this.label7);
            this.browserOptionsGroupBox.Controls.Add(this.newBrowserTextBox);
            this.browserOptionsGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.browserOptionsGroupBox.Location = new System.Drawing.Point(33, 69);
            this.browserOptionsGroupBox.Name = "browserOptionsGroupBox";
            this.browserOptionsGroupBox.Size = new System.Drawing.Size(586, 300);
            this.browserOptionsGroupBox.TabIndex = 30;
            this.browserOptionsGroupBox.TabStop = false;
            this.browserOptionsGroupBox.Text = "Browser options";
            // 
            // removeBrowserFromListButton
            // 
            this.removeBrowserFromListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.removeBrowserFromListButton.Cursor = Cursors.Hand;
            this.removeBrowserFromListButton.FlatAppearance.BorderSize = 0;
            this.removeBrowserFromListButton.FlatStyle = FlatStyle.Flat;
            this.removeBrowserFromListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.removeBrowserFromListButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.removeBrowserFromListButton.Location = new System.Drawing.Point(341, 171);
            this.removeBrowserFromListButton.Name = "removeBrowserFromListButton";
            this.removeBrowserFromListButton.Size = new System.Drawing.Size(72, 29);
            this.removeBrowserFromListButton.TabIndex = 31;
            this.removeBrowserFromListButton.Text = "Remove";
            this.removeBrowserFromListButton.UseVisualStyleBackColor = false;
            this.removeBrowserFromListButton.Click += new System.EventHandler(this.removeBrowserFromListButton_Click);
            // 
            // addNewBrowserButton
            // 
            this.addNewBrowserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.addNewBrowserButton.Cursor = Cursors.Hand;
            this.addNewBrowserButton.FlatAppearance.BorderSize = 0;
            this.addNewBrowserButton.FlatStyle = FlatStyle.Flat;
            this.addNewBrowserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addNewBrowserButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.addNewBrowserButton.Location = new System.Drawing.Point(341, 69);
            this.addNewBrowserButton.Name = "addNewBrowserButton";
            this.addNewBrowserButton.Size = new System.Drawing.Size(72, 29);
            this.addNewBrowserButton.TabIndex = 28;
            this.addNewBrowserButton.Text = "Add";
            this.addNewBrowserButton.UseVisualStyleBackColor = false;
            this.addNewBrowserButton.Click += new System.EventHandler(this.addNewBrowserButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.label8.Location = new System.Drawing.Point(72, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 16);
            this.label8.TabIndex = 30;
            this.label8.Text = "Select default browser";
            // 
            // defaultBrowserSelector
            // 
            this.defaultBrowserSelector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.defaultBrowserSelector.Cursor = Cursors.Hand;
            this.defaultBrowserSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            this.defaultBrowserSelector.FlatStyle = FlatStyle.Flat;
            this.defaultBrowserSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.defaultBrowserSelector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(221)))), ((int)(((byte)(21)))));
            this.defaultBrowserSelector.Location = new System.Drawing.Point(217, 222);
            this.defaultBrowserSelector.Name = "defaultBrowserSelector";
            this.defaultBrowserSelector.Size = new System.Drawing.Size(326, 24);
            this.defaultBrowserSelector.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.label7.Location = new System.Drawing.Point(72, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "Add browser to the list";
            // 
            // newBrowserTextBox
            // 
            this.newBrowserTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.newBrowserTextBox.BorderStyle = BorderStyle.None;
            this.newBrowserTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newBrowserTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(221)))), ((int)(((byte)(21)))));
            this.newBrowserTextBox.Location = new System.Drawing.Point(222, 39);
            this.newBrowserTextBox.Name = "newBrowserTextBox";
            this.newBrowserTextBox.Size = new System.Drawing.Size(326, 14);
            this.newBrowserTextBox.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.label1.Location = new System.Drawing.Point(246, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Edit browser options:";
            // 
            // saveBrowserOptionsButton
            // 
            this.saveBrowserOptionsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.saveBrowserOptionsButton.Cursor = Cursors.Hand;
            this.saveBrowserOptionsButton.FlatAppearance.BorderSize = 0;
            this.saveBrowserOptionsButton.FlatStyle = FlatStyle.Flat;
            this.saveBrowserOptionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.saveBrowserOptionsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.saveBrowserOptionsButton.Location = new System.Drawing.Point(255, 410);
            this.saveBrowserOptionsButton.Name = "saveBrowserOptionsButton";
            this.saveBrowserOptionsButton.Size = new System.Drawing.Size(140, 40);
            this.saveBrowserOptionsButton.TabIndex = 33;
            this.saveBrowserOptionsButton.Text = "Save browser settings";
            this.saveBrowserOptionsButton.UseVisualStyleBackColor = false;
            this.saveBrowserOptionsButton.Click += new System.EventHandler(this.saveBrowserOptionsButton_Click);
            // 
            // browserOptionsSuccessfullChangeMessageLabel
            // 
            this.browserOptionsSuccessfullChangeMessageLabel.AutoSize = true;
            this.browserOptionsSuccessfullChangeMessageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(221)))), ((int)(((byte)(21)))));
            this.browserOptionsSuccessfullChangeMessageLabel.Location = new System.Drawing.Point(210, 466);
            this.browserOptionsSuccessfullChangeMessageLabel.Name = "browserOptionsSuccessfullChangeMessageLabel";
            this.browserOptionsSuccessfullChangeMessageLabel.Size = new System.Drawing.Size(0, 13);
            this.browserOptionsSuccessfullChangeMessageLabel.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.label2.Location = new System.Drawing.Point(32, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Remove browser from the list";
            // 
            // browserListToRemoveBrowser
            // 
            this.browserListToRemoveBrowser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.browserListToRemoveBrowser.Cursor = Cursors.Hand;
            this.browserListToRemoveBrowser.DropDownStyle = ComboBoxStyle.DropDownList;
            this.browserListToRemoveBrowser.FlatStyle = FlatStyle.Flat;
            this.browserListToRemoveBrowser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.browserListToRemoveBrowser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(221)))), ((int)(((byte)(21)))));
            this.browserListToRemoveBrowser.Location = new System.Drawing.Point(217, 128);
            this.browserListToRemoveBrowser.Name = "browserListToRemoveBrowser";
            this.browserListToRemoveBrowser.Size = new System.Drawing.Size(326, 24);
            this.browserListToRemoveBrowser.TabIndex = 33;
            // 
            // BrowserOptionsEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(650, 500);
            this.Controls.Add(this.browserOptionsSuccessfullChangeMessageLabel);
            this.Controls.Add(this.saveBrowserOptionsButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.browserOptionsGroupBox);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.FormBorderStyle = FormBorderStyle.None;
            this.Name = "BrowserOptionsEditorForm";
            this.Text = "BrowserOptionsEditorForm";
            this.browserOptionsGroupBox.ResumeLayout(false);
            this.browserOptionsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox browserOptionsGroupBox;
        private Button removeBrowserFromListButton;
        private Button addNewBrowserButton;
        private Label label8;
        private ComboBox defaultBrowserSelector;
        private Label label7;
        private TextBox newBrowserTextBox;
        private Label label1;
        private Button saveBrowserOptionsButton;
        private Label browserOptionsSuccessfullChangeMessageLabel;
        private ComboBox browserListToRemoveBrowser;
        private Label label2;
    }
}