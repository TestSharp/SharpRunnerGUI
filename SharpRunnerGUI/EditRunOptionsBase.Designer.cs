using System.Windows.Forms;

namespace TestRunnerGUI
{
    partial class EditRunOptionsBase
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
            this.editRunOptionsSplitContainer = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.generalSettingsButton = new System.Windows.Forms.Button();
            this.workersOptionsButton = new System.Windows.Forms.Button();
            this.browserOptionsButton = new System.Windows.Forms.Button();
            this.reportOptionsButton = new System.Windows.Forms.Button();
            this.saveSettingsButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.editRunOptionsSplitContainer)).BeginInit();
            this.editRunOptionsSplitContainer.Panel1.SuspendLayout();
            this.editRunOptionsSplitContainer.Panel2.SuspendLayout();
            this.editRunOptionsSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // editRunOptionsSplitContainer
            // 
            this.editRunOptionsSplitContainer.BackColor = System.Drawing.Color.Black;
            this.editRunOptionsSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editRunOptionsSplitContainer.IsSplitterFixed = true;
            this.editRunOptionsSplitContainer.Location = new System.Drawing.Point(3, 3);
            this.editRunOptionsSplitContainer.Name = "editRunOptionsSplitContainer";
            // 
            // editRunOptionsSplitContainer.Panel1
            // 
            this.editRunOptionsSplitContainer.Panel1.Controls.Add(this.label1);
            this.editRunOptionsSplitContainer.Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.splitContainer_MouseDown);
            // 
            // editRunOptionsSplitContainer.Panel2
            // 
            this.editRunOptionsSplitContainer.Panel2.Controls.Add(this.generalSettingsButton);
            this.editRunOptionsSplitContainer.Panel2.Controls.Add(this.workersOptionsButton);
            this.editRunOptionsSplitContainer.Panel2.Controls.Add(this.browserOptionsButton);
            this.editRunOptionsSplitContainer.Panel2.Controls.Add(this.reportOptionsButton);
            this.editRunOptionsSplitContainer.Panel2.Controls.Add(this.saveSettingsButton);
            this.editRunOptionsSplitContainer.Panel2.Controls.Add(this.helpButton);
            this.editRunOptionsSplitContainer.Panel2.Controls.Add(this.closeButton);
            this.editRunOptionsSplitContainer.Panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.splitContainer_MouseDown);
            this.editRunOptionsSplitContainer.Size = new System.Drawing.Size(800, 500);
            this.editRunOptionsSplitContainer.SplitterDistance = 650;
            this.editRunOptionsSplitContainer.SplitterWidth = 2;
            this.editRunOptionsSplitContainer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.label1.Location = new System.Drawing.Point(143, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please select a menu option from the right side";
            // 
            // generalSettingsButton
            // 
            this.generalSettingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.generalSettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generalSettingsButton.FlatAppearance.BorderSize = 0;
            this.generalSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generalSettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.generalSettingsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.generalSettingsButton.Location = new System.Drawing.Point(17, 60);
            this.generalSettingsButton.Name = "generalSettingsButton";
            this.generalSettingsButton.Size = new System.Drawing.Size(130, 35);
            this.generalSettingsButton.TabIndex = 33;
            this.generalSettingsButton.Text = "General settings";
            this.generalSettingsButton.UseVisualStyleBackColor = false;
            this.generalSettingsButton.Click += new System.EventHandler(this.generalSettingsButton_Click);
            // 
            // workersOptionsButton
            // 
            this.workersOptionsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.workersOptionsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.workersOptionsButton.FlatAppearance.BorderSize = 0;
            this.workersOptionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.workersOptionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.workersOptionsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.workersOptionsButton.Location = new System.Drawing.Point(17, 195);
            this.workersOptionsButton.Name = "workersOptionsButton";
            this.workersOptionsButton.Size = new System.Drawing.Size(130, 35);
            this.workersOptionsButton.TabIndex = 32;
            this.workersOptionsButton.Text = "Workers options";
            this.workersOptionsButton.UseVisualStyleBackColor = false;
            this.workersOptionsButton.Click += new System.EventHandler(this.workersOptionsButton_Click);
            // 
            // browserOptionsButton
            // 
            this.browserOptionsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.browserOptionsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browserOptionsButton.FlatAppearance.BorderSize = 0;
            this.browserOptionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browserOptionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.browserOptionsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.browserOptionsButton.Location = new System.Drawing.Point(17, 150);
            this.browserOptionsButton.Name = "browserOptionsButton";
            this.browserOptionsButton.Size = new System.Drawing.Size(130, 35);
            this.browserOptionsButton.TabIndex = 31;
            this.browserOptionsButton.Text = "Browser options";
            this.browserOptionsButton.UseVisualStyleBackColor = false;
            this.browserOptionsButton.Click += new System.EventHandler(this.browserOptionsButton_Click);
            // 
            // reportOptionsButton
            // 
            this.reportOptionsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.reportOptionsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reportOptionsButton.FlatAppearance.BorderSize = 0;
            this.reportOptionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportOptionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.reportOptionsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.reportOptionsButton.Location = new System.Drawing.Point(17, 105);
            this.reportOptionsButton.Name = "reportOptionsButton";
            this.reportOptionsButton.Size = new System.Drawing.Size(130, 35);
            this.reportOptionsButton.TabIndex = 30;
            this.reportOptionsButton.Text = "Report options";
            this.reportOptionsButton.UseVisualStyleBackColor = false;
            this.reportOptionsButton.Click += new System.EventHandler(this.reportOptionsButton_Click);
            // 
            // saveSettingsButton
            // 
            this.saveSettingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.saveSettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveSettingsButton.FlatAppearance.BorderSize = 0;
            this.saveSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveSettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.saveSettingsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.saveSettingsButton.Location = new System.Drawing.Point(18, 391);
            this.saveSettingsButton.Name = "saveSettingsButton";
            this.saveSettingsButton.Size = new System.Drawing.Size(110, 40);
            this.saveSettingsButton.TabIndex = 29;
            this.saveSettingsButton.Text = "Save settings";
            this.saveSettingsButton.UseVisualStyleBackColor = false;
            this.saveSettingsButton.Click += new System.EventHandler(this.saveSettingsButton_Click);
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
            this.helpButton.TabIndex = 5;
            this.helpButton.Text = "?";
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
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
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // EditRunOptionsBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(806, 506);
            this.Controls.Add(this.editRunOptionsSplitContainer);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditRunOptionsBase";
            this.Text = "EditRunOptionsBase";
            this.editRunOptionsSplitContainer.Panel1.ResumeLayout(false);
            this.editRunOptionsSplitContainer.Panel1.PerformLayout();
            this.editRunOptionsSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.editRunOptionsSplitContainer)).EndInit();
            this.editRunOptionsSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer editRunOptionsSplitContainer;
        private Button closeButton;
        private Button helpButton;
        private Button saveSettingsButton;
        private Button workersOptionsButton;
        private Button browserOptionsButton;
        private Button reportOptionsButton;
        private Label label1;
        private Button generalSettingsButton;
    }
}