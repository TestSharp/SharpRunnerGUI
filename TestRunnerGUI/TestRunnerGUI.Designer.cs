using System.Windows.Forms;

namespace TestRunnerGUI
{
    partial class TestRunnerGUI
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
            this.minimizeButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.testBuildablePathTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.selectTestBuildableFromFileExplorer = new System.Windows.Forms.Button();
            this.editDropdownButton = new System.Windows.Forms.Button();
            this.testExecPathTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.setCurrentTest = new System.Windows.Forms.Button();
            this.selectTestExecutableFromFileExplorer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.testSelectorDropdown = new System.Windows.Forms.ComboBox();
            this.currentSelectedPathTextLabel = new System.Windows.Forms.Label();
            this.currentSelectedPathTextBox = new System.Windows.Forms.TextBox();
            this.pathToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.runOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.rebuildTestCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.runBrowserSelector = new System.Windows.Forms.ComboBox();
            this.editRunOptionsButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.workersNumberSetterInput = new System.Windows.Forms.NumericUpDown();
            this.produceXmlReport = new System.Windows.Forms.CheckBox();
            this.produceTextReport = new System.Windows.Forms.CheckBox();
            this.runTestButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.runOptionsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workersNumberSetterInput)).BeginInit();
            this.SuspendLayout();
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.minimizeButton.Location = new System.Drawing.Point(780, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(30, 30);
            this.minimizeButton.TabIndex = 0;
            this.minimizeButton.Text = "_";
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.helpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helpButton.FlatAppearance.BorderSize = 0;
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.helpButton.Location = new System.Drawing.Point(740, 0);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(30, 30);
            this.helpButton.TabIndex = 1;
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
            this.closeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.closeButton.Location = new System.Drawing.Point(820, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(30, 30);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.titleLabel.Location = new System.Drawing.Point(30, 10);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(254, 25);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "TestRunner for NUnit 3";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.testBuildablePathTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.selectTestBuildableFromFileExplorer);
            this.groupBox1.Controls.Add(this.editDropdownButton);
            this.groupBox1.Controls.Add(this.testExecPathTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.setCurrentTest);
            this.groupBox1.Controls.Add(this.selectTestExecutableFromFileExplorer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.testSelectorDropdown);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.groupBox1.Location = new System.Drawing.Point(51, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(759, 281);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Test selector";
            // 
            // testBuildablePathTextBox
            // 
            this.testBuildablePathTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.testBuildablePathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.testBuildablePathTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.testBuildablePathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.testBuildablePathTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(221)))), ((int)(((byte)(21)))));
            this.testBuildablePathTextBox.Location = new System.Drawing.Point(186, 156);
            this.testBuildablePathTextBox.Multiline = true;
            this.testBuildablePathTextBox.Name = "testBuildablePathTextBox";
            this.testBuildablePathTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.testBuildablePathTextBox.Size = new System.Drawing.Size(330, 60);
            this.testBuildablePathTextBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(101)))), ((int)(((byte)(211)))));
            this.label5.Location = new System.Drawing.Point(35, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Test csproj or sln path";
            // 
            // selectTestBuildableFromFileExplorer
            // 
            this.selectTestBuildableFromFileExplorer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.selectTestBuildableFromFileExplorer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectTestBuildableFromFileExplorer.FlatAppearance.BorderSize = 0;
            this.selectTestBuildableFromFileExplorer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectTestBuildableFromFileExplorer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectTestBuildableFromFileExplorer.Location = new System.Drawing.Point(560, 167);
            this.selectTestBuildableFromFileExplorer.Name = "selectTestBuildableFromFileExplorer";
            this.selectTestBuildableFromFileExplorer.Size = new System.Drawing.Size(150, 40);
            this.selectTestBuildableFromFileExplorer.TabIndex = 10;
            this.selectTestBuildableFromFileExplorer.Text = "Select test buildable from file explorer";
            this.selectTestBuildableFromFileExplorer.UseVisualStyleBackColor = false;
            this.selectTestBuildableFromFileExplorer.Click += new System.EventHandler(this.selectTestBuildableFromFileExplorer_Click);
            // 
            // editDropdownButton
            // 
            this.editDropdownButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.editDropdownButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editDropdownButton.FlatAppearance.BorderSize = 0;
            this.editDropdownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editDropdownButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.editDropdownButton.Location = new System.Drawing.Point(575, 28);
            this.editDropdownButton.Name = "editDropdownButton";
            this.editDropdownButton.Size = new System.Drawing.Size(110, 30);
            this.editDropdownButton.TabIndex = 9;
            this.editDropdownButton.Text = "Edit dropdown";
            this.editDropdownButton.UseVisualStyleBackColor = false;
            this.editDropdownButton.Click += new System.EventHandler(this.editDropdownButton_Click);
            // 
            // testExecPathTextBox
            // 
            this.testExecPathTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.testExecPathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.testExecPathTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.testExecPathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.testExecPathTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(221)))), ((int)(((byte)(21)))));
            this.testExecPathTextBox.Location = new System.Drawing.Point(186, 77);
            this.testExecPathTextBox.Multiline = true;
            this.testExecPathTextBox.Name = "testExecPathTextBox";
            this.testExecPathTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.testExecPathTextBox.Size = new System.Drawing.Size(330, 60);
            this.testExecPathTextBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(101)))), ((int)(((byte)(211)))));
            this.label2.Location = new System.Drawing.Point(35, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Test executable path";
            // 
            // setCurrentTest
            // 
            this.setCurrentTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.setCurrentTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setCurrentTest.FlatAppearance.BorderSize = 0;
            this.setCurrentTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setCurrentTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.setCurrentTest.Location = new System.Drawing.Point(30, 207);
            this.setCurrentTest.Name = "setCurrentTest";
            this.setCurrentTest.Size = new System.Drawing.Size(125, 50);
            this.setCurrentTest.TabIndex = 6;
            this.setCurrentTest.Text = "Set current test";
            this.setCurrentTest.UseVisualStyleBackColor = false;
            this.setCurrentTest.Click += new System.EventHandler(this.setCurrentTest_Click);
            // 
            // selectTestExecutableFromFileExplorer
            // 
            this.selectTestExecutableFromFileExplorer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.selectTestExecutableFromFileExplorer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectTestExecutableFromFileExplorer.FlatAppearance.BorderSize = 0;
            this.selectTestExecutableFromFileExplorer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectTestExecutableFromFileExplorer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectTestExecutableFromFileExplorer.Location = new System.Drawing.Point(560, 87);
            this.selectTestExecutableFromFileExplorer.Name = "selectTestExecutableFromFileExplorer";
            this.selectTestExecutableFromFileExplorer.Size = new System.Drawing.Size(150, 40);
            this.selectTestExecutableFromFileExplorer.TabIndex = 5;
            this.selectTestExecutableFromFileExplorer.Text = "Select test executable from file explorer";
            this.selectTestExecutableFromFileExplorer.UseVisualStyleBackColor = false;
            this.selectTestExecutableFromFileExplorer.Click += new System.EventHandler(this.selectFromFileExplorer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(101)))), ((int)(((byte)(211)))));
            this.label1.Location = new System.Drawing.Point(18, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select test from dropdown";
            // 
            // testSelectorDropdown
            // 
            this.testSelectorDropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.testSelectorDropdown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.testSelectorDropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.testSelectorDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.testSelectorDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testSelectorDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.testSelectorDropdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(221)))), ((int)(((byte)(21)))));
            this.testSelectorDropdown.FormattingEnabled = true;
            this.testSelectorDropdown.Location = new System.Drawing.Point(186, 31);
            this.testSelectorDropdown.Name = "testSelectorDropdown";
            this.testSelectorDropdown.Size = new System.Drawing.Size(330, 23);
            this.testSelectorDropdown.TabIndex = 0;
            this.testSelectorDropdown.SelectedIndexChanged += new System.EventHandler(this.testSelectorDropdown_IndexChanged);
            this.testSelectorDropdown.DropDownClosed += new System.EventHandler(this.testSelectorDropdown_DropDownClosed);
            // 
            // currentSelectedPathTextLabel
            // 
            this.currentSelectedPathTextLabel.AutoSize = true;
            this.currentSelectedPathTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.currentSelectedPathTextLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.currentSelectedPathTextLabel.Location = new System.Drawing.Point(48, 355);
            this.currentSelectedPathTextLabel.Name = "currentSelectedPathTextLabel";
            this.currentSelectedPathTextLabel.Size = new System.Drawing.Size(147, 16);
            this.currentSelectedPathTextLabel.TabIndex = 5;
            this.currentSelectedPathTextLabel.Text = "Currently selected path:";
            // 
            // currentSelectedPathTextBox
            // 
            this.currentSelectedPathTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.currentSelectedPathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentSelectedPathTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.currentSelectedPathTextBox.Enabled = false;
            this.currentSelectedPathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.currentSelectedPathTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(221)))), ((int)(((byte)(21)))));
            this.currentSelectedPathTextBox.Location = new System.Drawing.Point(201, 350);
            this.currentSelectedPathTextBox.Multiline = true;
            this.currentSelectedPathTextBox.Name = "currentSelectedPathTextBox";
            this.currentSelectedPathTextBox.ReadOnly = true;
            this.currentSelectedPathTextBox.Size = new System.Drawing.Size(565, 29);
            this.currentSelectedPathTextBox.TabIndex = 6;
            // 
            // runOptionsGroupBox
            // 
            this.runOptionsGroupBox.Controls.Add(this.rebuildTestCheckBox);
            this.runOptionsGroupBox.Controls.Add(this.label4);
            this.runOptionsGroupBox.Controls.Add(this.runBrowserSelector);
            this.runOptionsGroupBox.Controls.Add(this.editRunOptionsButton);
            this.runOptionsGroupBox.Controls.Add(this.label3);
            this.runOptionsGroupBox.Controls.Add(this.workersNumberSetterInput);
            this.runOptionsGroupBox.Controls.Add(this.produceXmlReport);
            this.runOptionsGroupBox.Controls.Add(this.produceTextReport);
            this.runOptionsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.runOptionsGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.runOptionsGroupBox.Location = new System.Drawing.Point(51, 385);
            this.runOptionsGroupBox.Name = "runOptionsGroupBox";
            this.runOptionsGroupBox.Size = new System.Drawing.Size(581, 181);
            this.runOptionsGroupBox.TabIndex = 14;
            this.runOptionsGroupBox.TabStop = false;
            this.runOptionsGroupBox.Text = "Run options";
            // 
            // rebuildTestCheckBox
            // 
            this.rebuildTestCheckBox.AutoSize = true;
            this.rebuildTestCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rebuildTestCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rebuildTestCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rebuildTestCheckBox.Location = new System.Drawing.Point(30, 36);
            this.rebuildTestCheckBox.Name = "rebuildTestCheckBox";
            this.rebuildTestCheckBox.Size = new System.Drawing.Size(128, 19);
            this.rebuildTestCheckBox.TabIndex = 21;
            this.rebuildTestCheckBox.Text = "Rebuild before run";
            this.rebuildTestCheckBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Selected browser";
            // 
            // runBrowserSelector
            // 
            this.runBrowserSelector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.runBrowserSelector.Cursor = System.Windows.Forms.Cursors.Hand;
            this.runBrowserSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.runBrowserSelector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.runBrowserSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.runBrowserSelector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(221)))), ((int)(((byte)(21)))));
            this.runBrowserSelector.Location = new System.Drawing.Point(218, 84);
            this.runBrowserSelector.Name = "runBrowserSelector";
            this.runBrowserSelector.Size = new System.Drawing.Size(201, 24);
            this.runBrowserSelector.TabIndex = 9;
            // 
            // editRunOptionsButton
            // 
            this.editRunOptionsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.editRunOptionsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editRunOptionsButton.FlatAppearance.BorderSize = 0;
            this.editRunOptionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editRunOptionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.editRunOptionsButton.Location = new System.Drawing.Point(436, 75);
            this.editRunOptionsButton.Name = "editRunOptionsButton";
            this.editRunOptionsButton.Size = new System.Drawing.Size(118, 40);
            this.editRunOptionsButton.TabIndex = 13;
            this.editRunOptionsButton.Text = "Edit run options";
            this.editRunOptionsButton.UseVisualStyleBackColor = false;
            this.editRunOptionsButton.Click += new System.EventHandler(this.editRunOptionsButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Number of workers";
            // 
            // workersNumberSetterInput
            // 
            this.workersNumberSetterInput.BackColor = System.Drawing.Color.Black;
            this.workersNumberSetterInput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.workersNumberSetterInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.workersNumberSetterInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.workersNumberSetterInput.Location = new System.Drawing.Point(150, 135);
            this.workersNumberSetterInput.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.workersNumberSetterInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.workersNumberSetterInput.Name = "workersNumberSetterInput";
            this.workersNumberSetterInput.Size = new System.Drawing.Size(45, 22);
            this.workersNumberSetterInput.TabIndex = 18;
            this.workersNumberSetterInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.workersNumberSetterInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // produceXmlReport
            // 
            this.produceXmlReport.AutoSize = true;
            this.produceXmlReport.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.produceXmlReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.produceXmlReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.produceXmlReport.Location = new System.Drawing.Point(27, 99);
            this.produceXmlReport.Name = "produceXmlReport";
            this.produceXmlReport.Size = new System.Drawing.Size(141, 19);
            this.produceXmlReport.TabIndex = 17;
            this.produceXmlReport.Text = "Produce XML Report";
            this.produceXmlReport.UseVisualStyleBackColor = true;
            // 
            // produceTextReport
            // 
            this.produceTextReport.AutoSize = true;
            this.produceTextReport.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.produceTextReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.produceTextReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.produceTextReport.Location = new System.Drawing.Point(30, 74);
            this.produceTextReport.Name = "produceTextReport";
            this.produceTextReport.Size = new System.Drawing.Size(138, 19);
            this.produceTextReport.TabIndex = 16;
            this.produceTextReport.Text = "Produce Text Report";
            this.produceTextReport.UseVisualStyleBackColor = true;
            // 
            // runTestButton
            // 
            this.runTestButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.runTestButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.runTestButton.FlatAppearance.BorderSize = 0;
            this.runTestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.runTestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.runTestButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(209)))));
            this.runTestButton.Location = new System.Drawing.Point(669, 454);
            this.runTestButton.Name = "runTestButton";
            this.runTestButton.Size = new System.Drawing.Size(118, 74);
            this.runTestButton.TabIndex = 13;
            this.runTestButton.Text = "Run Test";
            this.runTestButton.UseVisualStyleBackColor = false;
            this.runTestButton.Click += new System.EventHandler(this.runTestButton_Click);
            // 
            // TestRunnerGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(850, 600);
            this.Controls.Add(this.runTestButton);
            this.Controls.Add(this.runOptionsGroupBox);
            this.Controls.Add(this.currentSelectedPathTextBox);
            this.Controls.Add(this.currentSelectedPathTextLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.minimizeButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.DarkGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "TestRunnerGUI";
            this.ShowIcon = false;
            this.Text = "TestRunnerGUI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.testRunnerGui_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.runOptionsGroupBox.ResumeLayout(false);
            this.runOptionsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workersNumberSetterInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        public NumericUpDown workersNumberSetterInput;
        public ComboBox runBrowserSelector;

        private Button minimizeButton;
        private Button helpButton;
        private Button closeButton;
        private Label titleLabel;
        private GroupBox groupBox1;
        private Label label1;
        private ComboBox testSelectorDropdown;
        private Button editDropdownButton;
        private TextBox testExecPathTextBox;
        private Label label2;
        private Button setCurrentTest;
        private Button selectTestExecutableFromFileExplorer;
        private Label currentSelectedPathTextLabel;
        private TextBox currentSelectedPathTextBox;
        private ToolTip pathToolTip;
        private GroupBox runOptionsGroupBox;
        private CheckBox produceXmlReport;
        private CheckBox produceTextReport;
        private Label label3;
        private Button editRunOptionsButton;
        private Label label4;
        private Button runTestButton;
        private CheckBox rebuildTestCheckBox;
        private TextBox testBuildablePathTextBox;
        private Label label5;
        private Button selectTestBuildableFromFileExplorer;
    }
}

