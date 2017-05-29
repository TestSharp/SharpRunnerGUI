using System.Windows.Forms;

namespace TestRunnerGUI
{
    partial class AddToDropdown
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
            this.label1 = new Label();
            this.currentPathTextBox = new TextBox();
            this.givenNameLabel = new Label();
            this.givenNameTextBox = new TextBox();
            this.addToDropdownButton = new Button();
            this.label2 = new Label();
            this.successfullyAddedText = new Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.label1.Location = new System.Drawing.Point(105, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Current path: ";
            // 
            // currentPathTextBox
            // 
            this.currentPathTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.currentPathTextBox.BorderStyle = BorderStyle.None;
            this.currentPathTextBox.Cursor = Cursors.Default;
            this.currentPathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.currentPathTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(221)))), ((int)(((byte)(21)))));
            this.currentPathTextBox.Location = new System.Drawing.Point(200, 100);
            this.currentPathTextBox.Multiline = true;
            this.currentPathTextBox.Name = "currentPathTextBox";
            this.currentPathTextBox.ReadOnly = true;
            this.currentPathTextBox.Size = new System.Drawing.Size(345, 100);
            this.currentPathTextBox.TabIndex = 7;
            // 
            // givenNameLabel
            // 
            this.givenNameLabel.AutoSize = true;
            this.givenNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.givenNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.givenNameLabel.Location = new System.Drawing.Point(55, 250);
            this.givenNameLabel.Name = "givenNameLabel";
            this.givenNameLabel.Size = new System.Drawing.Size(135, 16);
            this.givenNameLabel.TabIndex = 8;
            this.givenNameLabel.Text = "Name you would like:";
            // 
            // givenNameTextBox
            // 
            this.givenNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.givenNameTextBox.BorderStyle = BorderStyle.None;
            this.givenNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.givenNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(221)))), ((int)(((byte)(21)))));
            this.givenNameTextBox.Location = new System.Drawing.Point(200, 250);
            this.givenNameTextBox.Name = "givenNameTextBox";
            this.givenNameTextBox.Size = new System.Drawing.Size(345, 14);
            this.givenNameTextBox.TabIndex = 9;
            // 
            // addToDropdownButton
            // 
            this.addToDropdownButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.addToDropdownButton.Cursor = Cursors.Hand;
            this.addToDropdownButton.FlatAppearance.BorderSize = 0;
            this.addToDropdownButton.FlatStyle = FlatStyle.Flat;
            this.addToDropdownButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addToDropdownButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.addToDropdownButton.Location = new System.Drawing.Point(285, 350);
            this.addToDropdownButton.Name = "addToDropdownButton";
            this.addToDropdownButton.Size = new System.Drawing.Size(80, 50);
            this.addToDropdownButton.TabIndex = 10;
            this.addToDropdownButton.Text = "Add";
            this.addToDropdownButton.UseVisualStyleBackColor = false;
            this.addToDropdownButton.Click += new System.EventHandler(this.addToDropdownButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.label2.Location = new System.Drawing.Point(225, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Add new test to the list:";
            // 
            // successfullyAddedText
            // 
            this.successfullyAddedText.AutoSize = true;
            this.successfullyAddedText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(221)))), ((int)(((byte)(21)))));
            this.successfullyAddedText.Location = new System.Drawing.Point(200, 420);
            this.successfullyAddedText.Name = "successfullyAddedText";
            this.successfullyAddedText.Size = new System.Drawing.Size(0, 13);
            this.successfullyAddedText.TabIndex = 15;
            this.successfullyAddedText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddToDropdown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(650, 500);
            this.Controls.Add(this.successfullyAddedText);
            this.Controls.Add(this.givenNameTextBox);
            this.Controls.Add(this.addToDropdownButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.givenNameLabel);
            this.Controls.Add(this.currentPathTextBox);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Name = "AddToDropdown";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public TextBox currentPathTextBox;

        private Label label1;
        private Label givenNameLabel;
        private TextBox givenNameTextBox;
        private Button addToDropdownButton;
        private Label label2;
        private Label successfullyAddedText;
    }
}