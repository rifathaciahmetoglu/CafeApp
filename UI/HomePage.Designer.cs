namespace UI
{
    partial class HomePage
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
            panelTop = new Panel();
            TableTopPanel = new TableLayoutPanel();
            btnLogOut = new PictureBox();
            labUsername = new Label();
            btnClose = new PictureBox();
            labLogo = new Label();
            labCafeText = new Label();
            panel1 = new Panel();
            TableDeskPanel = new TableLayoutPanel();
            btnDis1 = new Button();
            btnDis2 = new Button();
            btnDis3 = new Button();
            btnDis4 = new Button();
            btnDis5 = new Button();
            btnMasa10 = new Button();
            btnMasa11 = new Button();
            btnMasa12 = new Button();
            btnMasa13 = new Button();
            btnMasa14 = new Button();
            btnMasa15 = new Button();
            btnMasa16 = new Button();
            btnMasa17 = new Button();
            btnMasa18 = new Button();
            btnMasa2 = new Button();
            btnMasa3 = new Button();
            btnMasa4 = new Button();
            btnMasa5 = new Button();
            btnMasa6 = new Button();
            btnMasa7 = new Button();
            btnMasa8 = new Button();
            btnMasa9 = new Button();
            btnMasa1 = new Button();
            TableButtonsPanel = new TableLayoutPanel();
            btnSales = new Button();
            btnProducts = new Button();
            PanelBottom = new TableLayoutPanel();
            labDateTime = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnPersons = new Button();
            panelTop.SuspendLayout();
            TableTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnLogOut).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            panel1.SuspendLayout();
            TableDeskPanel.SuspendLayout();
            TableButtonsPanel.SuspendLayout();
            PanelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.Gray;
            panelTop.Controls.Add(TableTopPanel);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(960, 50);
            panelTop.TabIndex = 0;
            // 
            // TableTopPanel
            // 
            TableTopPanel.ColumnCount = 4;
            TableTopPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.992874F));
            TableTopPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.0000038F));
            TableTopPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.206646F));
            TableTopPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.80047512F));
            TableTopPanel.Controls.Add(btnLogOut, 0, 1);
            TableTopPanel.Controls.Add(labUsername, 1, 1);
            TableTopPanel.Controls.Add(btnClose, 3, 1);
            TableTopPanel.Dock = DockStyle.Top;
            TableTopPanel.Location = new Point(0, 0);
            TableTopPanel.Name = "TableTopPanel";
            TableTopPanel.RowCount = 2;
            TableTopPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            TableTopPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            TableTopPanel.Size = new Size(960, 50);
            TableTopPanel.TabIndex = 0;
            TableTopPanel.Paint += TableTopPanel_Paint;
            // 
            // btnLogOut
            // 
            btnLogOut.Dock = DockStyle.Right;
            btnLogOut.Image = Properties.Resources.door__1_;
            btnLogOut.Location = new Point(3, 8);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(22, 39);
            btnLogOut.SizeMode = PictureBoxSizeMode.AutoSize;
            btnLogOut.TabIndex = 3;
            btnLogOut.TabStop = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // labUsername
            // 
            labUsername.AutoSize = true;
            labUsername.Dock = DockStyle.Left;
            labUsername.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labUsername.ForeColor = Color.DarkOrange;
            labUsername.Location = new Point(31, 5);
            labUsername.Name = "labUsername";
            labUsername.Size = new Size(145, 45);
            labUsername.TabIndex = 2;
            labUsername.Text = "kullanıcı adı";
            // 
            // btnClose
            // 
            btnClose.Dock = DockStyle.Fill;
            btnClose.Image = Properties.Resources.close;
            btnClose.Location = new Point(925, 8);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(32, 39);
            btnClose.SizeMode = PictureBoxSizeMode.AutoSize;
            btnClose.TabIndex = 0;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // labLogo
            // 
            labLogo.AutoSize = true;
            labLogo.Dock = DockStyle.Right;
            labLogo.Font = new Font("Harlow Solid Italic", 19.8000011F, FontStyle.Italic, GraphicsUnit.Point);
            labLogo.ForeColor = Color.Red;
            labLogo.Location = new Point(843, 0);
            labLogo.Name = "labLogo";
            labLogo.Size = new Size(114, 50);
            labLogo.TabIndex = 2;
            labLogo.Text = "R.I.P";
            // 
            // labCafeText
            // 
            labCafeText.AutoSize = true;
            labCafeText.Dock = DockStyle.Fill;
            labCafeText.Font = new Font("Mistral", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            labCafeText.ForeColor = Color.DarkOrange;
            labCafeText.Location = new Point(3, 0);
            labCafeText.Name = "labCafeText";
            labCafeText.Size = new Size(234, 50);
            labCafeText.TabIndex = 0;
            labCafeText.Text = "RIP CAFE";
            // 
            // panel1
            // 
            panel1.Controls.Add(TableDeskPanel);
            panel1.Controls.Add(TableButtonsPanel);
            panel1.Controls.Add(PanelBottom);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(960, 490);
            panel1.TabIndex = 3;
            // 
            // TableDeskPanel
            // 
            TableDeskPanel.ColumnCount = 9;
            TableDeskPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1F));
            TableDeskPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1F));
            TableDeskPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1F));
            TableDeskPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1F));
            TableDeskPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1F));
            TableDeskPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1F));
            TableDeskPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1F));
            TableDeskPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1F));
            TableDeskPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.2000008F));
            TableDeskPanel.Controls.Add(btnDis1, 2, 3);
            TableDeskPanel.Controls.Add(btnDis2, 3, 3);
            TableDeskPanel.Controls.Add(btnDis3, 4, 3);
            TableDeskPanel.Controls.Add(btnDis4, 5, 3);
            TableDeskPanel.Controls.Add(btnDis5, 6, 3);
            TableDeskPanel.Controls.Add(btnMasa10, 0, 2);
            TableDeskPanel.Controls.Add(btnMasa11, 1, 2);
            TableDeskPanel.Controls.Add(btnMasa12, 2, 2);
            TableDeskPanel.Controls.Add(btnMasa13, 3, 2);
            TableDeskPanel.Controls.Add(btnMasa14, 4, 2);
            TableDeskPanel.Controls.Add(btnMasa15, 5, 2);
            TableDeskPanel.Controls.Add(btnMasa16, 6, 2);
            TableDeskPanel.Controls.Add(btnMasa17, 7, 2);
            TableDeskPanel.Controls.Add(btnMasa18, 8, 2);
            TableDeskPanel.Controls.Add(btnMasa2, 1, 1);
            TableDeskPanel.Controls.Add(btnMasa3, 2, 1);
            TableDeskPanel.Controls.Add(btnMasa4, 3, 1);
            TableDeskPanel.Controls.Add(btnMasa5, 4, 1);
            TableDeskPanel.Controls.Add(btnMasa6, 5, 1);
            TableDeskPanel.Controls.Add(btnMasa7, 6, 1);
            TableDeskPanel.Controls.Add(btnMasa8, 7, 1);
            TableDeskPanel.Controls.Add(btnMasa9, 8, 1);
            TableDeskPanel.Controls.Add(btnMasa1, 0, 1);
            TableDeskPanel.Dock = DockStyle.Fill;
            TableDeskPanel.Location = new Point(0, 50);
            TableDeskPanel.Name = "TableDeskPanel";
            TableDeskPanel.RowCount = 5;
            TableDeskPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            TableDeskPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            TableDeskPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            TableDeskPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            TableDeskPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            TableDeskPanel.Size = new Size(960, 390);
            TableDeskPanel.TabIndex = 52;
            // 
            // btnDis1
            // 
            btnDis1.Dock = DockStyle.Fill;
            btnDis1.FlatStyle = FlatStyle.Flat;
            btnDis1.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDis1.ForeColor = Color.FromArgb(255, 128, 0);
            btnDis1.Image = Properties.Resources.coffee_table__1_;
            btnDis1.Location = new Point(215, 256);
            btnDis1.Name = "btnDis1";
            btnDis1.Size = new Size(100, 111);
            btnDis1.TabIndex = 35;
            btnDis1.Text = "DIŞ-1";
            btnDis1.TextAlign = ContentAlignment.BottomCenter;
            btnDis1.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDis1.UseVisualStyleBackColor = true;
            btnDis1.Click += btnDis1_Click;
            // 
            // btnDis2
            // 
            btnDis2.Dock = DockStyle.Fill;
            btnDis2.FlatStyle = FlatStyle.Flat;
            btnDis2.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDis2.ForeColor = Color.FromArgb(255, 128, 0);
            btnDis2.Image = Properties.Resources.coffee_table__1_;
            btnDis2.Location = new Point(321, 256);
            btnDis2.Name = "btnDis2";
            btnDis2.Size = new Size(100, 111);
            btnDis2.TabIndex = 38;
            btnDis2.Text = "DIŞ-2";
            btnDis2.TextAlign = ContentAlignment.BottomCenter;
            btnDis2.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDis2.UseVisualStyleBackColor = true;
            btnDis2.Click += btnDis2_Click;
            // 
            // btnDis3
            // 
            btnDis3.Dock = DockStyle.Fill;
            btnDis3.FlatStyle = FlatStyle.Flat;
            btnDis3.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDis3.ForeColor = Color.FromArgb(255, 128, 0);
            btnDis3.Image = Properties.Resources.coffee_table__1_;
            btnDis3.Location = new Point(427, 256);
            btnDis3.Name = "btnDis3";
            btnDis3.Size = new Size(100, 111);
            btnDis3.TabIndex = 50;
            btnDis3.Text = "DIŞ-3";
            btnDis3.TextAlign = ContentAlignment.BottomCenter;
            btnDis3.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDis3.UseVisualStyleBackColor = true;
            btnDis3.Click += btnDis3_Click;
            // 
            // btnDis4
            // 
            btnDis4.Dock = DockStyle.Fill;
            btnDis4.FlatStyle = FlatStyle.Flat;
            btnDis4.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDis4.ForeColor = Color.FromArgb(255, 128, 0);
            btnDis4.Image = Properties.Resources.coffee_table__1_;
            btnDis4.Location = new Point(533, 256);
            btnDis4.Name = "btnDis4";
            btnDis4.Size = new Size(100, 111);
            btnDis4.TabIndex = 43;
            btnDis4.Text = "DIŞ-4";
            btnDis4.TextAlign = ContentAlignment.BottomCenter;
            btnDis4.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDis4.UseVisualStyleBackColor = true;
            btnDis4.Click += btnDis4_Click;
            // 
            // btnDis5
            // 
            btnDis5.Dock = DockStyle.Fill;
            btnDis5.FlatStyle = FlatStyle.Flat;
            btnDis5.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDis5.ForeColor = Color.FromArgb(255, 128, 0);
            btnDis5.Image = Properties.Resources.coffee_table__1_;
            btnDis5.Location = new Point(639, 256);
            btnDis5.Name = "btnDis5";
            btnDis5.Size = new Size(100, 111);
            btnDis5.TabIndex = 46;
            btnDis5.Text = "DIŞ-5";
            btnDis5.TextAlign = ContentAlignment.BottomCenter;
            btnDis5.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDis5.UseVisualStyleBackColor = true;
            btnDis5.Click += btnDis5_Click;
            // 
            // btnMasa10
            // 
            btnMasa10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnMasa10.FlatStyle = FlatStyle.Flat;
            btnMasa10.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnMasa10.ForeColor = Color.FromArgb(255, 128, 0);
            btnMasa10.Image = Properties.Resources.coffee_table__1_;
            btnMasa10.Location = new Point(3, 139);
            btnMasa10.Name = "btnMasa10";
            btnMasa10.Size = new Size(100, 111);
            btnMasa10.TabIndex = 30;
            btnMasa10.Text = "MASA-10";
            btnMasa10.TextAlign = ContentAlignment.BottomCenter;
            btnMasa10.TextImageRelation = TextImageRelation.ImageAboveText;
            btnMasa10.UseVisualStyleBackColor = true;
            btnMasa10.Click += btnMasa10_Click;
            // 
            // btnMasa11
            // 
            btnMasa11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnMasa11.FlatStyle = FlatStyle.Flat;
            btnMasa11.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnMasa11.ForeColor = Color.FromArgb(255, 128, 0);
            btnMasa11.Image = Properties.Resources.coffee_table__1_;
            btnMasa11.Location = new Point(109, 139);
            btnMasa11.Name = "btnMasa11";
            btnMasa11.Size = new Size(100, 111);
            btnMasa11.TabIndex = 32;
            btnMasa11.Text = "MASA-11";
            btnMasa11.TextAlign = ContentAlignment.BottomCenter;
            btnMasa11.TextImageRelation = TextImageRelation.ImageAboveText;
            btnMasa11.UseVisualStyleBackColor = true;
            btnMasa11.Click += btnMasa11_Click;
            // 
            // btnMasa12
            // 
            btnMasa12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnMasa12.FlatStyle = FlatStyle.Flat;
            btnMasa12.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnMasa12.ForeColor = Color.FromArgb(255, 128, 0);
            btnMasa12.Image = Properties.Resources.coffee_table__1_;
            btnMasa12.Location = new Point(215, 139);
            btnMasa12.Name = "btnMasa12";
            btnMasa12.Size = new Size(100, 111);
            btnMasa12.TabIndex = 33;
            btnMasa12.Text = "MASA-12";
            btnMasa12.TextAlign = ContentAlignment.BottomCenter;
            btnMasa12.TextImageRelation = TextImageRelation.ImageAboveText;
            btnMasa12.UseVisualStyleBackColor = true;
            btnMasa12.Click += btnMasa12_Click;
            // 
            // btnMasa13
            // 
            btnMasa13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnMasa13.FlatStyle = FlatStyle.Flat;
            btnMasa13.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnMasa13.ForeColor = Color.FromArgb(255, 128, 0);
            btnMasa13.Image = Properties.Resources.coffee_table__1_;
            btnMasa13.Location = new Point(321, 139);
            btnMasa13.Name = "btnMasa13";
            btnMasa13.Size = new Size(100, 111);
            btnMasa13.TabIndex = 36;
            btnMasa13.Text = "MASA-13";
            btnMasa13.TextAlign = ContentAlignment.BottomCenter;
            btnMasa13.TextImageRelation = TextImageRelation.ImageAboveText;
            btnMasa13.UseVisualStyleBackColor = true;
            btnMasa13.Click += btnMasa13_Click;
            // 
            // btnMasa14
            // 
            btnMasa14.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnMasa14.FlatStyle = FlatStyle.Flat;
            btnMasa14.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnMasa14.ForeColor = Color.FromArgb(255, 128, 0);
            btnMasa14.Image = Properties.Resources.coffee_table__1_;
            btnMasa14.Location = new Point(427, 139);
            btnMasa14.Name = "btnMasa14";
            btnMasa14.Size = new Size(100, 111);
            btnMasa14.TabIndex = 40;
            btnMasa14.Text = "MASA-14";
            btnMasa14.TextAlign = ContentAlignment.BottomCenter;
            btnMasa14.TextImageRelation = TextImageRelation.ImageAboveText;
            btnMasa14.UseVisualStyleBackColor = true;
            btnMasa14.Click += btnMasa14_Click;
            // 
            // btnMasa15
            // 
            btnMasa15.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnMasa15.FlatStyle = FlatStyle.Flat;
            btnMasa15.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnMasa15.ForeColor = Color.FromArgb(255, 128, 0);
            btnMasa15.Image = Properties.Resources.coffee_table__1_;
            btnMasa15.Location = new Point(533, 139);
            btnMasa15.Name = "btnMasa15";
            btnMasa15.Size = new Size(100, 111);
            btnMasa15.TabIndex = 42;
            btnMasa15.Text = "MASA-15";
            btnMasa15.TextAlign = ContentAlignment.BottomCenter;
            btnMasa15.TextImageRelation = TextImageRelation.ImageAboveText;
            btnMasa15.UseVisualStyleBackColor = true;
            btnMasa15.Click += btnMasa15_Click;
            // 
            // btnMasa16
            // 
            btnMasa16.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnMasa16.FlatStyle = FlatStyle.Flat;
            btnMasa16.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnMasa16.ForeColor = Color.FromArgb(255, 128, 0);
            btnMasa16.Image = Properties.Resources.coffee_table__1_;
            btnMasa16.Location = new Point(639, 139);
            btnMasa16.Name = "btnMasa16";
            btnMasa16.Size = new Size(100, 111);
            btnMasa16.TabIndex = 45;
            btnMasa16.Text = "MASA-16";
            btnMasa16.TextAlign = ContentAlignment.BottomCenter;
            btnMasa16.TextImageRelation = TextImageRelation.ImageAboveText;
            btnMasa16.UseVisualStyleBackColor = true;
            btnMasa16.Click += btnMasa16_Click;
            // 
            // btnMasa17
            // 
            btnMasa17.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnMasa17.FlatStyle = FlatStyle.Flat;
            btnMasa17.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnMasa17.ForeColor = Color.FromArgb(255, 128, 0);
            btnMasa17.Image = Properties.Resources.coffee_table__1_;
            btnMasa17.Location = new Point(745, 139);
            btnMasa17.Name = "btnMasa17";
            btnMasa17.Size = new Size(100, 111);
            btnMasa17.TabIndex = 48;
            btnMasa17.Text = "MASA-17";
            btnMasa17.TextAlign = ContentAlignment.BottomCenter;
            btnMasa17.TextImageRelation = TextImageRelation.ImageAboveText;
            btnMasa17.UseVisualStyleBackColor = true;
            btnMasa17.Click += btnMasa17_Click;
            // 
            // btnMasa18
            // 
            btnMasa18.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnMasa18.FlatStyle = FlatStyle.Flat;
            btnMasa18.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnMasa18.ForeColor = Color.FromArgb(255, 128, 0);
            btnMasa18.Image = Properties.Resources.coffee_table__1_;
            btnMasa18.Location = new Point(851, 139);
            btnMasa18.Name = "btnMasa18";
            btnMasa18.Size = new Size(106, 111);
            btnMasa18.TabIndex = 29;
            btnMasa18.Text = "MASA-18";
            btnMasa18.TextAlign = ContentAlignment.BottomCenter;
            btnMasa18.TextImageRelation = TextImageRelation.ImageAboveText;
            btnMasa18.UseVisualStyleBackColor = true;
            btnMasa18.Click += btnMasa18_Click;
            // 
            // btnMasa2
            // 
            btnMasa2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnMasa2.FlatStyle = FlatStyle.Flat;
            btnMasa2.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnMasa2.ForeColor = Color.FromArgb(255, 128, 0);
            btnMasa2.Image = Properties.Resources.coffee_table__1_;
            btnMasa2.Location = new Point(109, 22);
            btnMasa2.Name = "btnMasa2";
            btnMasa2.Size = new Size(100, 111);
            btnMasa2.TabIndex = 39;
            btnMasa2.Text = "MASA-2";
            btnMasa2.TextAlign = ContentAlignment.BottomCenter;
            btnMasa2.TextImageRelation = TextImageRelation.ImageAboveText;
            btnMasa2.UseVisualStyleBackColor = true;
            btnMasa2.Click += btnMasa2_Click;
            // 
            // btnMasa3
            // 
            btnMasa3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnMasa3.FlatStyle = FlatStyle.Flat;
            btnMasa3.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnMasa3.ForeColor = Color.FromArgb(255, 128, 0);
            btnMasa3.Image = Properties.Resources.coffee_table__1_;
            btnMasa3.Location = new Point(215, 22);
            btnMasa3.Name = "btnMasa3";
            btnMasa3.Size = new Size(100, 111);
            btnMasa3.TabIndex = 31;
            btnMasa3.Text = "MASA-3";
            btnMasa3.TextAlign = ContentAlignment.BottomCenter;
            btnMasa3.TextImageRelation = TextImageRelation.ImageAboveText;
            btnMasa3.UseVisualStyleBackColor = true;
            btnMasa3.Click += btnMasa3_Click;
            // 
            // btnMasa4
            // 
            btnMasa4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnMasa4.FlatStyle = FlatStyle.Flat;
            btnMasa4.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnMasa4.ForeColor = Color.FromArgb(255, 128, 0);
            btnMasa4.Image = Properties.Resources.coffee_table__1_;
            btnMasa4.Location = new Point(321, 22);
            btnMasa4.Name = "btnMasa4";
            btnMasa4.Size = new Size(100, 111);
            btnMasa4.TabIndex = 34;
            btnMasa4.Text = "MASA-4";
            btnMasa4.TextAlign = ContentAlignment.BottomCenter;
            btnMasa4.TextImageRelation = TextImageRelation.ImageAboveText;
            btnMasa4.UseVisualStyleBackColor = true;
            btnMasa4.Click += btnMasa4_Click;
            // 
            // btnMasa5
            // 
            btnMasa5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnMasa5.FlatStyle = FlatStyle.Flat;
            btnMasa5.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnMasa5.ForeColor = Color.FromArgb(255, 128, 0);
            btnMasa5.Image = Properties.Resources.coffee_table__1_;
            btnMasa5.Location = new Point(427, 22);
            btnMasa5.Name = "btnMasa5";
            btnMasa5.Size = new Size(100, 111);
            btnMasa5.TabIndex = 37;
            btnMasa5.Text = "MASA-5";
            btnMasa5.TextAlign = ContentAlignment.BottomCenter;
            btnMasa5.TextImageRelation = TextImageRelation.ImageAboveText;
            btnMasa5.UseVisualStyleBackColor = true;
            btnMasa5.Click += btnMasa5_Click;
            // 
            // btnMasa6
            // 
            btnMasa6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnMasa6.FlatStyle = FlatStyle.Flat;
            btnMasa6.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnMasa6.ForeColor = Color.FromArgb(255, 128, 0);
            btnMasa6.Image = Properties.Resources.coffee_table__1_;
            btnMasa6.Location = new Point(533, 22);
            btnMasa6.Name = "btnMasa6";
            btnMasa6.Size = new Size(100, 111);
            btnMasa6.TabIndex = 41;
            btnMasa6.Text = "MASA-6";
            btnMasa6.TextAlign = ContentAlignment.BottomCenter;
            btnMasa6.TextImageRelation = TextImageRelation.ImageAboveText;
            btnMasa6.UseVisualStyleBackColor = true;
            btnMasa6.Click += btnMasa6_Click;
            // 
            // btnMasa7
            // 
            btnMasa7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnMasa7.FlatStyle = FlatStyle.Flat;
            btnMasa7.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnMasa7.ForeColor = Color.FromArgb(255, 128, 0);
            btnMasa7.Image = Properties.Resources.coffee_table__1_;
            btnMasa7.Location = new Point(639, 22);
            btnMasa7.Name = "btnMasa7";
            btnMasa7.Size = new Size(100, 111);
            btnMasa7.TabIndex = 44;
            btnMasa7.Text = "MASA-7";
            btnMasa7.TextAlign = ContentAlignment.BottomCenter;
            btnMasa7.TextImageRelation = TextImageRelation.ImageAboveText;
            btnMasa7.UseVisualStyleBackColor = true;
            btnMasa7.Click += btnMasa7_Click;
            // 
            // btnMasa8
            // 
            btnMasa8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnMasa8.FlatStyle = FlatStyle.Flat;
            btnMasa8.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnMasa8.ForeColor = Color.FromArgb(255, 128, 0);
            btnMasa8.Image = Properties.Resources.coffee_table__1_;
            btnMasa8.Location = new Point(745, 22);
            btnMasa8.Name = "btnMasa8";
            btnMasa8.Size = new Size(100, 111);
            btnMasa8.TabIndex = 47;
            btnMasa8.Text = "MASA-8";
            btnMasa8.TextAlign = ContentAlignment.BottomCenter;
            btnMasa8.TextImageRelation = TextImageRelation.ImageAboveText;
            btnMasa8.UseVisualStyleBackColor = true;
            btnMasa8.Click += btnMasa8_Click;
            // 
            // btnMasa9
            // 
            btnMasa9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnMasa9.FlatStyle = FlatStyle.Flat;
            btnMasa9.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnMasa9.ForeColor = Color.FromArgb(255, 128, 0);
            btnMasa9.Image = Properties.Resources.coffee_table__1_;
            btnMasa9.Location = new Point(851, 22);
            btnMasa9.Name = "btnMasa9";
            btnMasa9.Size = new Size(106, 111);
            btnMasa9.TabIndex = 49;
            btnMasa9.Text = "MASA-9";
            btnMasa9.TextAlign = ContentAlignment.BottomCenter;
            btnMasa9.TextImageRelation = TextImageRelation.ImageAboveText;
            btnMasa9.UseVisualStyleBackColor = true;
            btnMasa9.Click += btnMasa9_Click;
            // 
            // btnMasa1
            // 
            btnMasa1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnMasa1.FlatStyle = FlatStyle.Flat;
            btnMasa1.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnMasa1.ForeColor = Color.FromArgb(255, 128, 0);
            btnMasa1.Image = Properties.Resources.coffee_table__1_;
            btnMasa1.Location = new Point(3, 22);
            btnMasa1.Name = "btnMasa1";
            btnMasa1.Size = new Size(100, 111);
            btnMasa1.TabIndex = 51;
            btnMasa1.Text = "MASA-1";
            btnMasa1.TextAlign = ContentAlignment.BottomCenter;
            btnMasa1.TextImageRelation = TextImageRelation.ImageAboveText;
            btnMasa1.UseVisualStyleBackColor = true;
            btnMasa1.Click += btnMasa1_Click;
            // 
            // TableButtonsPanel
            // 
            TableButtonsPanel.BackColor = Color.Silver;
            TableButtonsPanel.ColumnCount = 5;
            TableButtonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            TableButtonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            TableButtonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            TableButtonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            TableButtonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8F));
            TableButtonsPanel.Controls.Add(btnSales, 1, 0);
            TableButtonsPanel.Controls.Add(btnProducts, 2, 0);
            TableButtonsPanel.Controls.Add(btnPersons, 3, 0);
            TableButtonsPanel.Dock = DockStyle.Top;
            TableButtonsPanel.Location = new Point(0, 0);
            TableButtonsPanel.Name = "TableButtonsPanel";
            TableButtonsPanel.RowCount = 1;
            TableButtonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableButtonsPanel.Size = new Size(960, 50);
            TableButtonsPanel.TabIndex = 28;
            TableButtonsPanel.Visible = false;
            // 
            // btnSales
            // 
            btnSales.BackColor = Color.Transparent;
            btnSales.FlatStyle = FlatStyle.Flat;
            btnSales.ForeColor = Color.OrangeRed;
            btnSales.Image = Properties.Resources.shopping_cart__1_;
            btnSales.Location = new Point(23, 3);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(124, 44);
            btnSales.TabIndex = 41;
            btnSales.Text = "Satışlar";
            btnSales.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSales.UseVisualStyleBackColor = false;
            btnSales.Click += btnSales_Click;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = Color.Transparent;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.ForeColor = Color.OrangeRed;
            btnProducts.Image = Properties.Resources.package;
            btnProducts.Location = new Point(153, 3);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(124, 44);
            btnProducts.TabIndex = 42;
            btnProducts.Text = "Ürünler";
            btnProducts.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProducts.UseVisualStyleBackColor = false;
            btnProducts.Click += btnProducts_Click;
            // 
            // PanelBottom
            // 
            PanelBottom.BackColor = Color.Silver;
            PanelBottom.ColumnCount = 3;
            PanelBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            PanelBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            PanelBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            PanelBottom.Controls.Add(labCafeText, 0, 0);
            PanelBottom.Controls.Add(labLogo, 3, 0);
            PanelBottom.Controls.Add(labDateTime, 1, 0);
            PanelBottom.Dock = DockStyle.Bottom;
            PanelBottom.Location = new Point(0, 440);
            PanelBottom.Name = "PanelBottom";
            PanelBottom.RowCount = 1;
            PanelBottom.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            PanelBottom.Size = new Size(960, 50);
            PanelBottom.TabIndex = 27;
            // 
            // labDateTime
            // 
            labDateTime.AutoSize = true;
            labDateTime.Dock = DockStyle.Fill;
            labDateTime.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            labDateTime.ForeColor = Color.DarkOrange;
            labDateTime.Location = new Point(243, 0);
            labDateTime.Name = "labDateTime";
            labDateTime.Size = new Size(474, 50);
            labDateTime.TabIndex = 3;
            labDateTime.Text = "DateTime";
            labDateTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 9;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 106.6F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 106.6F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 106.6F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 106.6F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 106.6F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 106.6F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 106.6F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 106.6F));
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // btnPersons
            // 
            btnPersons.BackColor = Color.Transparent;
            btnPersons.FlatStyle = FlatStyle.Flat;
            btnPersons.ForeColor = Color.OrangeRed;
            btnPersons.Image = Properties.Resources.user;
            btnPersons.Location = new Point(283, 3);
            btnPersons.Name = "btnPersons";
            btnPersons.Size = new Size(124, 44);
            btnPersons.TabIndex = 43;
            btnPersons.Text = "Personel";
            btnPersons.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPersons.UseVisualStyleBackColor = false;
            btnPersons.Click += btnPersons_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(960, 540);
            Controls.Add(panel1);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomePage";
            Text = "HomePage";
            Load += HomePage_Load;
            panelTop.ResumeLayout(false);
            TableTopPanel.ResumeLayout(false);
            TableTopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnLogOut).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            panel1.ResumeLayout(false);
            TableDeskPanel.ResumeLayout(false);
            TableButtonsPanel.ResumeLayout(false);
            PanelBottom.ResumeLayout(false);
            PanelBottom.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Panel panelBottom;
        private Label labLogo;
        private Label labCafeText;
        private Panel panel1;
        private PictureBox btnClose;
        private TableLayoutPanel PanelBottom;
        private TableLayoutPanel TableButtonsPanel;
        private Button btnMasa18;
        private Button btnMasa9;
        private Button btnMasa10;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel TableTopPanel;
        private TableLayoutPanel TableDeskPanel;
        private Button btnMasa1;
        private Label labUsername;
        private Button btnDis1;
        private Button btnDis2;
        private Button btnDis3;
        private Button btnDis4;
        private Button btnDis5;
        private Button btnMasa11;
        private Button btnMasa12;
        private Button btnMasa13;
        private Button btnMasa14;
        private Button btnMasa15;
        private Button btnMasa16;
        private Button btnMasa17;
        private Button btnMasa2;
        private Button btnMasa3;
        private Button btnMasa4;
        private Button btnMasa5;
        private Button btnMasa6;
        private Button btnMasa7;
        private Button btnMasa8;
        private Label labDateTime;
        private Button btnSales;
        private Button btnProducts;
        private PictureBox btnLogOut;
        private Button btnPersons;
    }
}