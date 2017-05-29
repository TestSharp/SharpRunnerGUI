using System.Windows.Forms;

namespace TestRunnerGUI
{
    partial class EditDropdown
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
            this.label1 = new Label();
            this.saveDropdownChangesButton = new Button();
            this.testListDropdown = new ComboBox();
            this.label2 = new Label();
            this.currentPathTextBox = new TextBox();
            this.label3 = new Label();
            this.label4 = new Label();
            this.givenNameTextBox = new TextBox();
            this.label5 = new Label();
            this.label6 = new Label();
            this.pathToolTip = new ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.label1.Location = new System.Drawing.Point(210, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Edit previously added tests:";
            // 
            // saveDropdownChangesButton
            // 
            this.saveDropdownChangesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.saveDropdownChangesButton.Cursor = Cursors.Hand;
            this.saveDropdownChangesButton.FlatAppearance.BorderSize = 0;
            this.saveDropdownChangesButton.FlatStyle = FlatStyle.Flat;
            this.saveDropdownChangesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.saveDropdownChangesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.saveDropdownChangesButton.Location = new System.Drawing.Point(271, 350);
            this.saveDropdownChangesButton.Name = "saveDropdownChangesButton";
            this.saveDropdownChangesButton.Size = new System.Drawing.Size(80, 50);
            this.saveDropdownChangesButton.TabIndex = 15;
            this.saveDropdownChangesButton.Text = "Save";
            this.saveDropdownChangesButton.UseVisualStyleBackColor = false;
            this.saveDropdownChangesButton.Click += new System.EventHandler(this.saveDropdownChangesButton_Click);
            // 
            // testListDropdown
            // 
            this.testListDropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.testListDropdown.Cursor = Cursors.Hand;
            this.testListDropdown.DrawMode = DrawMode.OwnerDrawFixed;
            this.testListDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            this.testListDropdown.FlatStyle = FlatStyle.Flat;
            this.testListDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.testListDropdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(221)))), ((int)(((byte)(21)))));
            this.testListDropdown.FormattingEnabled = true;
            this.testListDropdown.Location = new System.Drawing.Point(271, 100);
            this.testListDropdown.Name = "testListDropdown";
            this.testListDropdown.Size = new System.Drawing.Size(314, 23);
            this.testListDropdown.TabIndex = 17;
            this.testListDropdown.DropDownClosed += new System.EventHandler(this.testListDropdown_DropDownClosed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(101)))), ((int)(((byte)(211)))));
            this.label2.Location = new System.Drawing.Point(65, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Select test you would like to edit";
            // 
            // currentPathTextBox
            // 
            this.currentPathTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.currentPathTextBox.BorderStyle = BorderStyle.None;
            this.currentPathTextBox.Cursor = Cursors.Default;
            this.currentPathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.currentPathTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(221)))), ((int)(((byte)(21)))));
            this.currentPathTextBox.Location = new System.Drawing.Point(271, 220);
            this.currentPathTextBox.Multiline = true;
            this.currentPathTextBox.Name = "currentPathTextBox";
            this.currentPathTextBox.Size = new System.Drawing.Size(314, 90);
            this.currentPathTextBox.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(101)))), ((int)(((byte)(211)))));
            this.label3.Location = new System.Drawing.Point(96, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Add new path";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(101)))), ((int)(((byte)(211)))));
            this.label4.Location = new System.Drawing.Point(38, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "(Leave it blank to keep the previous)";
            // 
            // givenNameTextBox
            // 
            this.givenNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.givenNameTextBox.BorderStyle = BorderStyle.None;
            this.givenNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.givenNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(221)))), ((int)(((byte)(21)))));
            this.givenNameTextBox.Location = new System.Drawing.Point(271, 169);
            this.givenNameTextBox.Name = "givenNameTextBox";
            this.givenNameTextBox.Size = new System.Drawing.Size(314, 15);
            this.givenNameTextBox.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(101)))), ((int)(((byte)(211)))));
            this.label5.Location = new System.Drawing.Point(96, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Add new name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(101)))), ((int)(((byte)(211)))));
            this.label6.Location = new System.Drawing.Point(38, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(223, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "(Leave it blank to keep the previous)";
            // 
            // EditDropdown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(650, 500);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveDropdownChangesButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.givenNameTextBox);
            this.Controls.Add(this.testListDropdown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.currentPathTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Name = "EditDropdown";
            this.Text = "EditDropdown";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Button saveDropdownChangesButton;
        private ComboBox testListDropdown;
        private Label label2;
        private TextBox currentPathTextBox;
        private Label label3;
        private Label label4;
        private TextBox givenNameTextBox;
        private Label label5;
        private Label label6;
        private ToolTip pathToolTip;
    }
}