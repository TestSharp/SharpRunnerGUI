using System.Windows.Forms;

namespace TestRunnerGUI
{
    partial class EditTestListBase
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
            this.editTestListSplitContainer = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.removeTestTabButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.editTestListTabButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.addNewTestTabButton = new System.Windows.Forms.Button();
            this.linkProjSolutionToTestButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.editTestListSplitContainer)).BeginInit();
            this.editTestListSplitContainer.Panel1.SuspendLayout();
            this.editTestListSplitContainer.Panel2.SuspendLayout();
            this.editTestListSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // editTestListSplitContainer
            // 
            this.editTestListSplitContainer.BackColor = System.Drawing.Color.Black;
            this.editTestListSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editTestListSplitContainer.IsSplitterFixed = true;
            this.editTestListSplitContainer.Location = new System.Drawing.Point(3, 3);
            this.editTestListSplitContainer.Name = "editTestListSplitContainer";
            // 
            // editTestListSplitContainer.Panel1
            // 
            this.editTestListSplitContainer.Panel1.Controls.Add(this.label1);
            this.editTestListSplitContainer.Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.splitContainer_MouseDown);
            // 
            // editTestListSplitContainer.Panel2
            // 
            this.editTestListSplitContainer.Panel2.Controls.Add(this.linkProjSolutionToTestButton);
            this.editTestListSplitContainer.Panel2.Controls.Add(this.removeTestTabButton);
            this.editTestListSplitContainer.Panel2.Controls.Add(this.closeButton);
            this.editTestListSplitContainer.Panel2.Controls.Add(this.editTestListTabButton);
            this.editTestListSplitContainer.Panel2.Controls.Add(this.helpButton);
            this.editTestListSplitContainer.Panel2.Controls.Add(this.addNewTestTabButton);
            this.editTestListSplitContainer.Panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.splitContainer_MouseDown);
            this.editTestListSplitContainer.Size = new System.Drawing.Size(800, 500);
            this.editTestListSplitContainer.SplitterDistance = 650;
            this.editTestListSplitContainer.SplitterWidth = 2;
            this.editTestListSplitContainer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.label1.Location = new System.Drawing.Point(144, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please select a menu option from the right side";
            // 
            // removeTestTabButton
            // 
            this.removeTestTabButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.removeTestTabButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeTestTabButton.FlatAppearance.BorderSize = 0;
            this.removeTestTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeTestTabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.removeTestTabButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.removeTestTabButton.Location = new System.Drawing.Point(47, 150);
            this.removeTestTabButton.Name = "removeTestTabButton";
            this.removeTestTabButton.Size = new System.Drawing.Size(100, 35);
            this.removeTestTabButton.TabIndex = 12;
            this.removeTestTabButton.Text = "Remove test";
            this.removeTestTabButton.UseVisualStyleBackColor = false;
            this.removeTestTabButton.Click += new System.EventHandler(this.removeTestTabButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.closeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.closeButton.Location = new System.Drawing.Point(117, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(30, 30);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // editTestListTabButton
            // 
            this.editTestListTabButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.editTestListTabButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editTestListTabButton.FlatAppearance.BorderSize = 0;
            this.editTestListTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editTestListTabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.editTestListTabButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.editTestListTabButton.Location = new System.Drawing.Point(47, 105);
            this.editTestListTabButton.Name = "editTestListTabButton";
            this.editTestListTabButton.Size = new System.Drawing.Size(100, 35);
            this.editTestListTabButton.TabIndex = 11;
            this.editTestListTabButton.Text = "Edit testlist";
            this.editTestListTabButton.UseVisualStyleBackColor = false;
            this.editTestListTabButton.Click += new System.EventHandler(this.editTestListTabButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.helpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helpButton.FlatAppearance.BorderSize = 0;
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.helpButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.helpButton.Location = new System.Drawing.Point(77, 0);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(30, 30);
            this.helpButton.TabIndex = 2;
            this.helpButton.Text = "?";
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // addNewTestTabButton
            // 
            this.addNewTestTabButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.addNewTestTabButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addNewTestTabButton.FlatAppearance.BorderSize = 0;
            this.addNewTestTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewTestTabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addNewTestTabButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.addNewTestTabButton.Location = new System.Drawing.Point(47, 60);
            this.addNewTestTabButton.Name = "addNewTestTabButton";
            this.addNewTestTabButton.Size = new System.Drawing.Size(100, 35);
            this.addNewTestTabButton.TabIndex = 10;
            this.addNewTestTabButton.Text = "Add test";
            this.addNewTestTabButton.UseVisualStyleBackColor = false;
            this.addNewTestTabButton.Click += new System.EventHandler(this.addNewTestTabButton_Click);
            // 
            // linkProjSolutionToTestButton
            // 
            this.linkProjSolutionToTestButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.linkProjSolutionToTestButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkProjSolutionToTestButton.FlatAppearance.BorderSize = 0;
            this.linkProjSolutionToTestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.linkProjSolutionToTestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkProjSolutionToTestButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.linkProjSolutionToTestButton.Location = new System.Drawing.Point(47, 195);
            this.linkProjSolutionToTestButton.Name = "linkProjSolutionToTestButton";
            this.linkProjSolutionToTestButton.Size = new System.Drawing.Size(100, 40);
            this.linkProjSolutionToTestButton.TabIndex = 13;
            this.linkProjSolutionToTestButton.Text = "Link project or solution to test";
            this.linkProjSolutionToTestButton.UseVisualStyleBackColor = false;
            this.linkProjSolutionToTestButton.Click += new System.EventHandler(this.linkProjSolutionToTestButton_Click);
            // 
            // EditTestListBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(806, 506);
            this.Controls.Add(this.editTestListSplitContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditTestListBase";
            this.editTestListSplitContainer.Panel1.ResumeLayout(false);
            this.editTestListSplitContainer.Panel1.PerformLayout();
            this.editTestListSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.editTestListSplitContainer)).EndInit();
            this.editTestListSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer editTestListSplitContainer;
        private Button closeButton;
        private Button helpButton;
        private Button removeTestTabButton;
        private Button editTestListTabButton;
        private Button addNewTestTabButton;
        private Label label1;
        private Button linkProjSolutionToTestButton;
    }
}