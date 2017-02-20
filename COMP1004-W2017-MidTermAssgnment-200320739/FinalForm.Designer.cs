namespace COMP1004_W2017_MidTermAssgnment_200320739
{
    partial class FinalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CharacterInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.JobLabel = new System.Windows.Forms.Label();
            this.RaceLabel = new System.Windows.Forms.Label();
            this.HealthPointsTextBox = new System.Windows.Forms.TextBox();
            this.HealthPointsLabel = new System.Windows.Forms.Label();
            this.JobTextBox = new System.Windows.Forms.TextBox();
            this.RaceTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.AbilitiesGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.CHATextBox = new System.Windows.Forms.TextBox();
            this.DEXTextBox = new System.Windows.Forms.TextBox();
            this.CHALabel = new System.Windows.Forms.Label();
            this.PERTextBox = new System.Windows.Forms.TextBox();
            this.STRLabel = new System.Windows.Forms.Label();
            this.INTTextBox = new System.Windows.Forms.TextBox();
            this.PERLabel = new System.Windows.Forms.Label();
            this.DEXLabel = new System.Windows.Forms.Label();
            this.ENDTextBox = new System.Windows.Forms.TextBox();
            this.INTLabel = new System.Windows.Forms.Label();
            this.ENDLabel = new System.Windows.Forms.Label();
            this.STRTextBox = new System.Windows.Forms.TextBox();
            this.FinalFormFontDialog = new System.Windows.Forms.FontDialog();
            this.CharacterPictureBox = new System.Windows.Forms.PictureBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.CharacterInformationGroupBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.AbilitiesGroupBox.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(641, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(189, 30);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.ClickPrintToolStripMenuItem);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(189, 30);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ClickExitToolStripMenuItem);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.editToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.F)));
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(227, 30);
            this.fontToolStripMenuItem.Text = "&Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.ClickFontToolStripMenuItem);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(205, 30);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.ClickAboutToolStripMenuItem);
            // 
            // CharacterInformationGroupBox
            // 
            this.CharacterInformationGroupBox.Controls.Add(this.tableLayoutPanel2);
            this.CharacterInformationGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.CharacterInformationGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CharacterInformationGroupBox.Location = new System.Drawing.Point(6, 36);
            this.CharacterInformationGroupBox.Name = "CharacterInformationGroupBox";
            this.CharacterInformationGroupBox.Size = new System.Drawing.Size(623, 137);
            this.CharacterInformationGroupBox.TabIndex = 1;
            this.CharacterInformationGroupBox.TabStop = false;
            this.CharacterInformationGroupBox.Text = "Character Information";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.97872F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.02128F));
            this.tableLayoutPanel2.Controls.Add(this.JobLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.RaceLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.HealthPointsTextBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.HealthPointsLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.JobTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.RaceTextBox, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(382, 34);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(235, 97);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // JobLabel
            // 
            this.JobLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.JobLabel.AutoSize = true;
            this.JobLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobLabel.Location = new System.Drawing.Point(44, 1);
            this.JobLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.JobLabel.Name = "JobLabel";
            this.JobLabel.Size = new System.Drawing.Size(59, 29);
            this.JobLabel.TabIndex = 20;
            this.JobLabel.Text = "Job:";
            this.JobLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // RaceLabel
            // 
            this.RaceLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RaceLabel.AutoSize = true;
            this.RaceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RaceLabel.Location = new System.Drawing.Point(36, 33);
            this.RaceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RaceLabel.Name = "RaceLabel";
            this.RaceLabel.Size = new System.Drawing.Size(75, 29);
            this.RaceLabel.TabIndex = 21;
            this.RaceLabel.Text = "Race:";
            this.RaceLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // HealthPointsTextBox
            // 
            this.HealthPointsTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HealthPointsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HealthPointsTextBox.Location = new System.Drawing.Point(151, 64);
            this.HealthPointsTextBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HealthPointsTextBox.Name = "HealthPointsTextBox";
            this.HealthPointsTextBox.ReadOnly = true;
            this.HealthPointsTextBox.Size = new System.Drawing.Size(80, 35);
            this.HealthPointsTextBox.TabIndex = 23;
            this.HealthPointsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HealthPointsLabel
            // 
            this.HealthPointsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HealthPointsLabel.AutoSize = true;
            this.HealthPointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HealthPointsLabel.Location = new System.Drawing.Point(32, 64);
            this.HealthPointsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HealthPointsLabel.Name = "HealthPointsLabel";
            this.HealthPointsLabel.Size = new System.Drawing.Size(82, 33);
            this.HealthPointsLabel.TabIndex = 22;
            this.HealthPointsLabel.Text = "Health Ponts:";
            this.HealthPointsLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // JobTextBox
            // 
            this.JobTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.JobTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobTextBox.Location = new System.Drawing.Point(151, 0);
            this.JobTextBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.JobTextBox.Name = "JobTextBox";
            this.JobTextBox.ReadOnly = true;
            this.JobTextBox.Size = new System.Drawing.Size(80, 35);
            this.JobTextBox.TabIndex = 23;
            this.JobTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RaceTextBox
            // 
            this.RaceTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RaceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RaceTextBox.Location = new System.Drawing.Point(151, 32);
            this.RaceTextBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RaceTextBox.Name = "RaceTextBox";
            this.RaceTextBox.ReadOnly = true;
            this.RaceTextBox.Size = new System.Drawing.Size(80, 35);
            this.RaceTextBox.TabIndex = 23;
            this.RaceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.69136F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.01235F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.38272F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.40741F));
            this.tableLayoutPanel1.Controls.Add(this.NameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.AgeLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.HeightTextBox, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.HeightLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.WeightLabel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.NameTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.AgeTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.WeightTextBox, 3, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-6, 34);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(382, 97);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(4, 9);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(84, 29);
            this.NameLabel.TabIndex = 17;
            this.NameLabel.Text = "Name:";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // AgeLabel
            // 
            this.AgeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeLabel.Location = new System.Drawing.Point(15, 58);
            this.AgeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(62, 29);
            this.AgeLabel.TabIndex = 18;
            this.AgeLabel.Text = "Age:";
            this.AgeLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HeightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightTextBox.Location = new System.Drawing.Point(294, 6);
            this.HeightTextBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HeightTextBox.MaxLength = 10;
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(70, 35);
            this.HeightTextBox.TabIndex = 23;
            this.HeightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateOnlyNumber);
            // 
            // HeightLabel
            // 
            this.HeightLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightLabel.Location = new System.Drawing.Point(176, 9);
            this.HeightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(89, 29);
            this.HeightLabel.TabIndex = 19;
            this.HeightLabel.Text = "Height:";
            this.HeightLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // WeightLabel
            // 
            this.WeightLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightLabel.Location = new System.Drawing.Point(173, 58);
            this.WeightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(94, 29);
            this.WeightLabel.TabIndex = 20;
            this.WeightLabel.Text = "Weight:";
            this.WeightLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.Location = new System.Drawing.Point(97, 6);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameTextBox.MaxLength = 50;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(64, 35);
            this.NameTextBox.TabIndex = 23;
            this.NameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AgeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeTextBox.Location = new System.Drawing.Point(97, 55);
            this.AgeTextBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AgeTextBox.MaxLength = 3;
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(64, 35);
            this.AgeTextBox.TabIndex = 23;
            this.AgeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AgeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateOnlyNumber);
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WeightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightTextBox.Location = new System.Drawing.Point(294, 55);
            this.WeightTextBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WeightTextBox.MaxLength = 10;
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(70, 35);
            this.WeightTextBox.TabIndex = 23;
            this.WeightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateOnlyNumber);
            // 
            // AbilitiesGroupBox
            // 
            this.AbilitiesGroupBox.Controls.Add(this.tableLayoutPanel3);
            this.AbilitiesGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AbilitiesGroupBox.Location = new System.Drawing.Point(6, 179);
            this.AbilitiesGroupBox.Name = "AbilitiesGroupBox";
            this.AbilitiesGroupBox.Size = new System.Drawing.Size(290, 327);
            this.AbilitiesGroupBox.TabIndex = 1;
            this.AbilitiesGroupBox.TabStop = false;
            this.AbilitiesGroupBox.Text = "Abilities";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.CHATextBox, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.DEXTextBox, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.CHALabel, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.PERTextBox, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.STRLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.INTTextBox, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.PERLabel, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.DEXLabel, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.ENDTextBox, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.INTLabel, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.ENDLabel, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.STRTextBox, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 36);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(268, 281);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // CHATextBox
            // 
            this.CHATextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CHATextBox.BackColor = System.Drawing.Color.White;
            this.CHATextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHATextBox.Location = new System.Drawing.Point(138, 238);
            this.CHATextBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CHATextBox.Name = "CHATextBox";
            this.CHATextBox.ReadOnly = true;
            this.CHATextBox.Size = new System.Drawing.Size(126, 35);
            this.CHATextBox.TabIndex = 35;
            this.CHATextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DEXTextBox
            // 
            this.DEXTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DEXTextBox.BackColor = System.Drawing.Color.White;
            this.DEXTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DEXTextBox.Location = new System.Drawing.Point(138, 51);
            this.DEXTextBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DEXTextBox.Name = "DEXTextBox";
            this.DEXTextBox.ReadOnly = true;
            this.DEXTextBox.Size = new System.Drawing.Size(126, 35);
            this.DEXTextBox.TabIndex = 25;
            this.DEXTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CHALabel
            // 
            this.CHALabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CHALabel.AutoSize = true;
            this.CHALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHALabel.Location = new System.Drawing.Point(36, 241);
            this.CHALabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CHALabel.Name = "CHALabel";
            this.CHALabel.Size = new System.Drawing.Size(62, 29);
            this.CHALabel.TabIndex = 31;
            this.CHALabel.Text = "CHA";
            this.CHALabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PERTextBox
            // 
            this.PERTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PERTextBox.BackColor = System.Drawing.Color.White;
            this.PERTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PERTextBox.Location = new System.Drawing.Point(138, 189);
            this.PERTextBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PERTextBox.Name = "PERTextBox";
            this.PERTextBox.ReadOnly = true;
            this.PERTextBox.Size = new System.Drawing.Size(126, 35);
            this.PERTextBox.TabIndex = 34;
            this.PERTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // STRLabel
            // 
            this.STRLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.STRLabel.AutoSize = true;
            this.STRLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STRLabel.Location = new System.Drawing.Point(36, 8);
            this.STRLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.STRLabel.Name = "STRLabel";
            this.STRLabel.Size = new System.Drawing.Size(62, 29);
            this.STRLabel.TabIndex = 17;
            this.STRLabel.Text = "STR";
            this.STRLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // INTTextBox
            // 
            this.INTTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.INTTextBox.BackColor = System.Drawing.Color.White;
            this.INTTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INTTextBox.Location = new System.Drawing.Point(138, 143);
            this.INTTextBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.INTTextBox.Name = "INTTextBox";
            this.INTTextBox.ReadOnly = true;
            this.INTTextBox.Size = new System.Drawing.Size(126, 35);
            this.INTTextBox.TabIndex = 33;
            this.INTTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PERLabel
            // 
            this.PERLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PERLabel.AutoSize = true;
            this.PERLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PERLabel.Location = new System.Drawing.Point(36, 192);
            this.PERLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PERLabel.Name = "PERLabel";
            this.PERLabel.Size = new System.Drawing.Size(62, 29);
            this.PERLabel.TabIndex = 30;
            this.PERLabel.Text = "PER";
            this.PERLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DEXLabel
            // 
            this.DEXLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DEXLabel.AutoSize = true;
            this.DEXLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DEXLabel.Location = new System.Drawing.Point(35, 54);
            this.DEXLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DEXLabel.Name = "DEXLabel";
            this.DEXLabel.Size = new System.Drawing.Size(63, 29);
            this.DEXLabel.TabIndex = 24;
            this.DEXLabel.Text = "DEX";
            this.DEXLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ENDTextBox
            // 
            this.ENDTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ENDTextBox.BackColor = System.Drawing.Color.White;
            this.ENDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ENDTextBox.Location = new System.Drawing.Point(138, 97);
            this.ENDTextBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ENDTextBox.Name = "ENDTextBox";
            this.ENDTextBox.ReadOnly = true;
            this.ENDTextBox.Size = new System.Drawing.Size(126, 35);
            this.ENDTextBox.TabIndex = 32;
            this.ENDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // INTLabel
            // 
            this.INTLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.INTLabel.AutoSize = true;
            this.INTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INTLabel.Location = new System.Drawing.Point(40, 146);
            this.INTLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.INTLabel.Name = "INTLabel";
            this.INTLabel.Size = new System.Drawing.Size(53, 29);
            this.INTLabel.TabIndex = 29;
            this.INTLabel.Text = "INT";
            this.INTLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ENDLabel
            // 
            this.ENDLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ENDLabel.AutoSize = true;
            this.ENDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ENDLabel.Location = new System.Drawing.Point(35, 100);
            this.ENDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ENDLabel.Name = "ENDLabel";
            this.ENDLabel.Size = new System.Drawing.Size(64, 29);
            this.ENDLabel.TabIndex = 28;
            this.ENDLabel.Text = "END";
            this.ENDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // STRTextBox
            // 
            this.STRTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.STRTextBox.BackColor = System.Drawing.Color.White;
            this.STRTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STRTextBox.Location = new System.Drawing.Point(138, 5);
            this.STRTextBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.STRTextBox.Name = "STRTextBox";
            this.STRTextBox.ReadOnly = true;
            this.STRTextBox.Size = new System.Drawing.Size(126, 35);
            this.STRTextBox.TabIndex = 23;
            this.STRTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FinalFormFontDialog
            // 
            this.FinalFormFontDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FinalFormFontDialog.MaxSize = 18;
            this.FinalFormFontDialog.MinSize = 10;
            // 
            // CharacterPictureBox
            // 
            this.CharacterPictureBox.Location = new System.Drawing.Point(318, 189);
            this.CharacterPictureBox.Name = "CharacterPictureBox";
            this.CharacterPictureBox.Size = new System.Drawing.Size(288, 261);
            this.CharacterPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CharacterPictureBox.TabIndex = 2;
            this.CharacterPictureBox.TabStop = false;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(506, 467);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(100, 28);
            this.ExitButton.TabIndex = 16;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ClickExitToolStripMenuItem);
            // 
            // FinalForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(641, 508);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CharacterPictureBox);
            this.Controls.Add(this.AbilitiesGroupBox);
            this.Controls.Add(this.CharacterInformationGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FinalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Your Character Selections";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClosingFinalForm);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.CharacterInformationGroupBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.AbilitiesGroupBox.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox CharacterInformationGroupBox;
        private System.Windows.Forms.GroupBox AbilitiesGroupBox;
        private System.Windows.Forms.PictureBox CharacterPictureBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label STRLabel;
        private System.Windows.Forms.TextBox STRTextBox;
        private System.Windows.Forms.TextBox DEXTextBox;
        private System.Windows.Forms.Label DEXLabel;
        private System.Windows.Forms.TextBox CHATextBox;
        private System.Windows.Forms.Label CHALabel;
        private System.Windows.Forms.TextBox PERTextBox;
        private System.Windows.Forms.TextBox INTTextBox;
        private System.Windows.Forms.Label PERLabel;
        private System.Windows.Forms.TextBox ENDTextBox;
        private System.Windows.Forms.Label INTLabel;
        private System.Windows.Forms.Label ENDLabel;
        private System.Windows.Forms.Label JobLabel;
        private System.Windows.Forms.Label RaceLabel;
        private System.Windows.Forms.TextBox HealthPointsTextBox;
        private System.Windows.Forms.Label HealthPointsLabel;
        private System.Windows.Forms.TextBox JobTextBox;
        private System.Windows.Forms.TextBox RaceTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.FontDialog FinalFormFontDialog;
        private System.Windows.Forms.TextBox WeightTextBox;
        internal System.Windows.Forms.Button ExitButton;
    }
}