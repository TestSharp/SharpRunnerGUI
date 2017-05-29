using System.Windows.Forms;

namespace TestRunnerGUI
{
    partial class RemoveDropdown
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
            this.testListDropdown = new ComboBox();
            this.removeDropdownButton = new Button();
            this.label1 = new Label();
            this.pathToolTip = new ToolTip(this.components);
            this.successfullRemovalLabel = new Label();
            this.SuspendLayout();
            // 
            // testListDropdown
            // 
            this.testListDropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.testListDropdown.Cursor = Cursors.Hand;
            this.testListDropdown.DrawMode = DrawMode.OwnerDrawFixed;
            this.testListDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            this.testListDropdown.FlatStyle = FlatStyle.Flat;
            this.testListDropdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(221)))), ((int)(((byte)(21)))));
            this.testListDropdown.FormattingEnabled = true;
            this.testListDropdown.Location = new System.Drawing.Point(125, 200);
            this.testListDropdown.Name = "testListDropdown";
            this.testListDropdown.Size = new System.Drawing.Size(400, 21);
            this.testListDropdown.TabIndex = 8;
            this.testListDropdown.DropDownClosed += new System.EventHandler(this.testListDropdown_DropDownClosed);
            // 
            // removeDropdownButton
            // 
            this.removeDropdownButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.removeDropdownButton.Cursor = Cursors.Hand;
            this.removeDropdownButton.FlatAppearance.BorderSize = 0;
            this.removeDropdownButton.FlatStyle = FlatStyle.Flat;
            this.removeDropdownButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.removeDropdownButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.removeDropdownButton.Location = new System.Drawing.Point(285, 350);
            this.removeDropdownButton.Name = "removeDropdownButton";
            this.removeDropdownButton.Size = new System.Drawing.Size(80, 50);
            this.removeDropdownButton.TabIndex = 11;
            this.removeDropdownButton.Text = "Remove";
            this.removeDropdownButton.UseVisualStyleBackColor = false;
            this.removeDropdownButton.Click += new System.EventHandler(this.removeDropdownButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.label1.Location = new System.Drawing.Point(143, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Select test you\'d like to remove from the list:";
            // 
            // successfullRemovalLabel
            // 
            this.successfullRemovalLabel.AutoSize = true;
            this.successfullRemovalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(221)))), ((int)(((byte)(21)))));
            this.successfullRemovalLabel.Location = new System.Drawing.Point(200, 440);
            this.successfullRemovalLabel.Name = "successfullRemovalLabel";
            this.successfullRemovalLabel.Size = new System.Drawing.Size(0, 13);
            this.successfullRemovalLabel.TabIndex = 14;
            // 
            // RemoveDropdown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(650, 500);
            this.Controls.Add(this.successfullRemovalLabel);
            this.Controls.Add(this.removeDropdownButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.testListDropdown);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Name = "RemoveDropdown";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox testListDropdown;
        private Button removeDropdownButton;
        private Label label1;
        private ToolTip pathToolTip;
        private Label successfullRemovalLabel;
    }
}