namespace UI
{
    partial class AdminPage
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPage));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            TableTopPanel = new TableLayoutPanel();
            btnUndoPage = new PictureBox();
            labMenuName = new Label();
            btnClose = new PictureBox();
            PanelBottom = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            labDateTime = new Label();
            labCafeText = new Label();
            labLogo = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dataGridProduct = new DataGridView();
            sidePanelProduct = new TableLayoutPanel();
            btnProductEdit = new PictureBox();
            btnProductDelete = new PictureBox();
            btnProductAdd = new PictureBox();
            panelProduct = new TableLayoutPanel();
            dataGridPersons = new DataGridView();
            panelAction = new Panel();
            txtProductName = new TextBox();
            pictureBox2 = new PictureBox();
            btnAction = new Button();
            txtSalePrice = new TextBox();
            cmbKind = new ComboBox();
            cmbSubCategory = new ComboBox();
            cmbCategory = new ComboBox();
            panelFilters = new Panel();
            pictureBox1 = new PictureBox();
            btnFilter = new Button();
            cmbFilterKind = new ComboBox();
            cmbFilterSubCategory = new ComboBox();
            cmbFilterCategory = new ComboBox();
            panelPersons = new Panel();
            panelPerson = new Panel();
            txtPersonFirstName = new TextBox();
            pictureBox3 = new PictureBox();
            btnPersonAction = new Button();
            txtPersonUserName = new TextBox();
            txtPersonLastName = new TextBox();
            txtPersonPassword = new TextBox();
            cmbRole = new ComboBox();
            sidePanelPerson = new TableLayoutPanel();
            btnPersonEdit = new PictureBox();
            btnPersonDel = new PictureBox();
            btnPersonAdd = new PictureBox();
            dataGridSales = new DataGridView();
            panelSales = new Panel();
            TableTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnUndoPage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            PanelBottom.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridProduct).BeginInit();
            sidePanelProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnProductEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnProductDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnProductAdd).BeginInit();
            panelProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridPersons).BeginInit();
            panelAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelPersons.SuspendLayout();
            panelPerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            sidePanelPerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnPersonEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnPersonDel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnPersonAdd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridSales).BeginInit();
            panelSales.SuspendLayout();
            SuspendLayout();
            // 
            // TableTopPanel
            // 
            TableTopPanel.BackColor = Color.Gray;
            TableTopPanel.ColumnCount = 5;
            TableTopPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.992874F));
            TableTopPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            TableTopPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            TableTopPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.20665F));
            TableTopPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.800475F));
            TableTopPanel.Controls.Add(btnUndoPage, 0, 1);
            TableTopPanel.Controls.Add(labMenuName, 1, 1);
            TableTopPanel.Controls.Add(btnClose, 4, 1);
            TableTopPanel.Dock = DockStyle.Top;
            TableTopPanel.Location = new Point(0, 0);
            TableTopPanel.Name = "TableTopPanel";
            TableTopPanel.RowCount = 2;
            TableTopPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            TableTopPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            TableTopPanel.Size = new Size(960, 50);
            TableTopPanel.TabIndex = 1;
            // 
            // btnUndoPage
            // 
            btnUndoPage.Dock = DockStyle.Right;
            btnUndoPage.Image = Properties.Resources.door__1_;
            btnUndoPage.Location = new Point(3, 8);
            btnUndoPage.Name = "btnUndoPage";
            btnUndoPage.Size = new Size(13, 39);
            btnUndoPage.SizeMode = PictureBoxSizeMode.AutoSize;
            btnUndoPage.TabIndex = 1;
            btnUndoPage.TabStop = false;
            btnUndoPage.Click += btnUndoPage_Click;
            // 
            // labMenuName
            // 
            labMenuName.AutoSize = true;
            labMenuName.Dock = DockStyle.Left;
            labMenuName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labMenuName.ForeColor = Color.DarkOrange;
            labMenuName.Location = new Point(22, 5);
            labMenuName.Name = "labMenuName";
            labMenuName.Size = new Size(104, 45);
            labMenuName.TabIndex = 2;
            labMenuName.Text = "Menüler";
            // 
            // btnClose
            // 
            btnClose.Dock = DockStyle.Fill;
            btnClose.Image = Properties.Resources.close;
            btnClose.Location = new Point(937, 8);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(20, 39);
            btnClose.SizeMode = PictureBoxSizeMode.AutoSize;
            btnClose.TabIndex = 0;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // PanelBottom
            // 
            PanelBottom.BackColor = Color.Silver;
            PanelBottom.ColumnCount = 3;
            PanelBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            PanelBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            PanelBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            PanelBottom.Controls.Add(tableLayoutPanel1, 0, 0);
            PanelBottom.Controls.Add(labCafeText, 0, 0);
            PanelBottom.Location = new Point(0, 0);
            PanelBottom.Name = "PanelBottom";
            PanelBottom.RowCount = 1;
            PanelBottom.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            PanelBottom.Size = new Size(200, 100);
            PanelBottom.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Silver;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 3, 0);
            tableLayoutPanel1.Controls.Add(labDateTime, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(53, 47);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(94, 50);
            tableLayoutPanel1.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Mistral", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkOrange;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(17, 50);
            label1.TabIndex = 0;
            label1.Text = "RIP CAFE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Right;
            label2.Font = new Font("Harlow Solid Italic", 19.8000011F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(73, 0);
            label2.Name = "label2";
            label2.Size = new Size(18, 50);
            label2.TabIndex = 2;
            label2.Text = "R.I.P";
            // 
            // labDateTime
            // 
            labDateTime.AutoSize = true;
            labDateTime.Dock = DockStyle.Fill;
            labDateTime.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            labDateTime.ForeColor = Color.DarkOrange;
            labDateTime.Location = new Point(26, 0);
            labDateTime.Name = "labDateTime";
            labDateTime.Size = new Size(41, 50);
            labDateTime.TabIndex = 3;
            labDateTime.Text = "DateTime";
            labDateTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labCafeText
            // 
            labCafeText.AutoSize = true;
            labCafeText.Dock = DockStyle.Fill;
            labCafeText.Font = new Font("Mistral", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            labCafeText.ForeColor = Color.DarkOrange;
            labCafeText.Location = new Point(3, 0);
            labCafeText.Name = "labCafeText";
            labCafeText.Size = new Size(44, 100);
            labCafeText.TabIndex = 0;
            labCafeText.Text = "RIP CAFE";
            // 
            // labLogo
            // 
            labLogo.AutoSize = true;
            labLogo.Dock = DockStyle.Right;
            labLogo.Font = new Font("Harlow Solid Italic", 19.8000011F, FontStyle.Italic, GraphicsUnit.Point);
            labLogo.ForeColor = Color.Red;
            labLogo.Location = new Point(153, 0);
            labLogo.Name = "labLogo";
            labLogo.Size = new Size(44, 308);
            labLogo.TabIndex = 2;
            labLogo.Text = "R.I.P";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.Silver;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(label3, 0, 0);
            tableLayoutPanel2.Controls.Add(label4, 3, 0);
            tableLayoutPanel2.Controls.Add(label5, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Bottom;
            tableLayoutPanel2.Location = new Point(0, 490);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(960, 50);
            tableLayoutPanel2.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Mistral", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkOrange;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(234, 50);
            label3.TabIndex = 0;
            label3.Text = "RIP CAFE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Right;
            label4.Font = new Font("Harlow Solid Italic", 19.8000011F, FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(843, 0);
            label4.Name = "label4";
            label4.Size = new Size(114, 50);
            label4.TabIndex = 2;
            label4.Text = "R.I.P";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkOrange;
            label5.Location = new Point(243, 0);
            label5.Name = "label5";
            label5.Size = new Size(474, 50);
            label5.TabIndex = 3;
            label5.Text = "DateTime";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridProduct
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.DarkOrange;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkOrange;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridProduct.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridProduct.ColumnHeadersHeight = 29;
            dataGridProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.DarkOrange;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkOrange;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridProduct.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridProduct.Dock = DockStyle.Fill;
            dataGridProduct.Location = new Point(3, 3);
            dataGridProduct.Name = "dataGridProduct";
            dataGridProduct.RowHeadersWidth = 51;
            dataGridProduct.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridProduct.RowTemplate.Height = 29;
            dataGridProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridProduct.Size = new Size(181, 94);
            dataGridProduct.TabIndex = 0;
            dataGridProduct.CellEnter += dataGridProduct_CellEnter;
            // 
            // sidePanelProduct
            // 
            sidePanelProduct.AllowDrop = true;
            sidePanelProduct.ColumnCount = 1;
            sidePanelProduct.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            sidePanelProduct.Controls.Add(btnProductEdit, 0, 2);
            sidePanelProduct.Controls.Add(btnProductDelete, 0, 4);
            sidePanelProduct.Controls.Add(btnProductAdd, 0, 0);
            sidePanelProduct.Dock = DockStyle.Right;
            sidePanelProduct.Location = new Point(899, 50);
            sidePanelProduct.Name = "sidePanelProduct";
            sidePanelProduct.RowCount = 6;
            sidePanelProduct.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            sidePanelProduct.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            sidePanelProduct.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            sidePanelProduct.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            sidePanelProduct.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            sidePanelProduct.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            sidePanelProduct.Size = new Size(61, 440);
            sidePanelProduct.TabIndex = 1;
            sidePanelProduct.Visible = false;
            // 
            // btnProductEdit
            // 
            btnProductEdit.Dock = DockStyle.Right;
            btnProductEdit.Image = (Image)resources.GetObject("btnProductEdit.Image");
            btnProductEdit.Location = new Point(10, 63);
            btnProductEdit.Name = "btnProductEdit";
            btnProductEdit.Size = new Size(48, 49);
            btnProductEdit.SizeMode = PictureBoxSizeMode.AutoSize;
            btnProductEdit.TabIndex = 1;
            btnProductEdit.TabStop = false;
            btnProductEdit.Click += btnProductEdit_Click;
            // 
            // btnProductDelete
            // 
            btnProductDelete.Dock = DockStyle.Right;
            btnProductDelete.Image = Properties.Resources.icons8_delete_key_50;
            btnProductDelete.Location = new Point(8, 123);
            btnProductDelete.Name = "btnProductDelete";
            btnProductDelete.Size = new Size(50, 49);
            btnProductDelete.SizeMode = PictureBoxSizeMode.AutoSize;
            btnProductDelete.TabIndex = 2;
            btnProductDelete.TabStop = false;
            btnProductDelete.Click += btnProductDelete_Click;
            // 
            // btnProductAdd
            // 
            btnProductAdd.Dock = DockStyle.Right;
            btnProductAdd.Image = Properties.Resources.icons8_add_new_50;
            btnProductAdd.Location = new Point(8, 3);
            btnProductAdd.Name = "btnProductAdd";
            btnProductAdd.Size = new Size(50, 49);
            btnProductAdd.SizeMode = PictureBoxSizeMode.AutoSize;
            btnProductAdd.TabIndex = 0;
            btnProductAdd.TabStop = false;
            btnProductAdd.Click += btnProductAdd_Click;
            // 
            // panelProduct
            // 
            panelProduct.ColumnCount = 2;
            panelProduct.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 98.5267F));
            panelProduct.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.47329652F));
            panelProduct.Controls.Add(dataGridProduct, 0, 0);
            panelProduct.Location = new Point(12, 71);
            panelProduct.Name = "panelProduct";
            panelProduct.RowCount = 1;
            panelProduct.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            panelProduct.Size = new Size(190, 100);
            panelProduct.TabIndex = 1;
            panelProduct.Visible = false;
            // 
            // dataGridPersons
            // 
            dataGridViewCellStyle3.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.DarkOrange;
            dataGridViewCellStyle3.SelectionBackColor = Color.DarkOrange;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridPersons.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridPersons.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridPersons.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridPersons.ColumnHeadersHeight = 29;
            dataGridPersons.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.DarkOrange;
            dataGridViewCellStyle4.SelectionBackColor = Color.DarkOrange;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridPersons.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridPersons.Dock = DockStyle.Fill;
            dataGridPersons.Location = new Point(0, 0);
            dataGridPersons.Name = "dataGridPersons";
            dataGridPersons.RowHeadersWidth = 51;
            dataGridPersons.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridPersons.RowTemplate.Height = 29;
            dataGridPersons.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridPersons.Size = new Size(250, 125);
            dataGridPersons.TabIndex = 1;
            dataGridPersons.CellContentClick += dataGridPersons_CellContentClick;
            dataGridPersons.CellEnter += dataGridPersons_CellEnter;
            // 
            // panelAction
            // 
            panelAction.Controls.Add(txtProductName);
            panelAction.Controls.Add(pictureBox2);
            panelAction.Controls.Add(btnAction);
            panelAction.Controls.Add(txtSalePrice);
            panelAction.Controls.Add(cmbKind);
            panelAction.Controls.Add(cmbSubCategory);
            panelAction.Controls.Add(cmbCategory);
            panelAction.Dock = DockStyle.Right;
            panelAction.Location = new Point(691, 50);
            panelAction.Name = "panelAction";
            panelAction.Size = new Size(208, 440);
            panelAction.TabIndex = 30;
            panelAction.Visible = false;
            // 
            // txtProductName
            // 
            txtProductName.BackColor = Color.Silver;
            txtProductName.BorderStyle = BorderStyle.None;
            txtProductName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtProductName.ForeColor = Color.OrangeRed;
            txtProductName.HideSelection = false;
            txtProductName.Location = new Point(13, 195);
            txtProductName.Multiline = true;
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(174, 25);
            txtProductName.TabIndex = 4;
            txtProductName.Text = "Ürün Adı";
            txtProductName.TextAlign = HorizontalAlignment.Center;
            txtProductName.Enter += txtProductName_Enter;
            txtProductName.Leave += txtProductName_Leave;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-223, 344);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(620, 500);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // btnAction
            // 
            btnAction.BackColor = Color.Transparent;
            btnAction.FlatStyle = FlatStyle.Flat;
            btnAction.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAction.ForeColor = Color.OrangeRed;
            btnAction.Location = new Point(19, 299);
            btnAction.Name = "btnAction";
            btnAction.Size = new Size(162, 37);
            btnAction.TabIndex = 2;
            btnAction.Text = "btnAction";
            btnAction.UseVisualStyleBackColor = false;
            btnAction.Click += btnAction_Click;
            // 
            // txtSalePrice
            // 
            txtSalePrice.BackColor = Color.Silver;
            txtSalePrice.BorderStyle = BorderStyle.None;
            txtSalePrice.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtSalePrice.ForeColor = Color.OrangeRed;
            txtSalePrice.HideSelection = false;
            txtSalePrice.Location = new Point(13, 247);
            txtSalePrice.Multiline = true;
            txtSalePrice.Name = "txtSalePrice";
            txtSalePrice.Size = new Size(174, 25);
            txtSalePrice.TabIndex = 1;
            txtSalePrice.Text = "Satış Fiyatı";
            txtSalePrice.TextAlign = HorizontalAlignment.Center;
            txtSalePrice.Enter += txtSalePrice_Enter;
            txtSalePrice.Leave += txtSalePrice_Leave;
            // 
            // cmbKind
            // 
            cmbKind.BackColor = Color.Silver;
            cmbKind.FlatStyle = FlatStyle.Flat;
            cmbKind.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cmbKind.ForeColor = Color.OrangeRed;
            cmbKind.FormattingEnabled = true;
            cmbKind.Items.AddRange(new object[] { "Espresso", "Mocha", "Cappuccino", "Macchiato", "Americano", "Doubleshot", "Latte", "Filtre Kahveler", "Türk Kahvesi", "RIP Refresha® Drinks", "Teavana™ Sıcak Çaylar", "Teavana™ Tea Latte", "Kahve Bazlı Frappuccino®", "Krema Bazlı Frappuccino®", "Sıcak Çikolatalar", "Şişelenmiş İçecekler", "Pasta ve Kekler", "Cheesecakeler", "Muffin & Cookie", "Kahvaltılık Ürünler", "Sandviçler", "Salata Ve Parfeler", "Atıştırmalıklar" });
            cmbKind.Location = new Point(3, 137);
            cmbKind.Name = "cmbKind";
            cmbKind.Size = new Size(194, 31);
            cmbKind.TabIndex = 0;
            cmbKind.Text = "Kategori";
            // 
            // cmbSubCategory
            // 
            cmbSubCategory.BackColor = Color.Silver;
            cmbSubCategory.FlatStyle = FlatStyle.Flat;
            cmbSubCategory.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cmbSubCategory.ForeColor = Color.OrangeRed;
            cmbSubCategory.FormattingEnabled = true;
            cmbSubCategory.Location = new Point(3, 79);
            cmbSubCategory.Name = "cmbSubCategory";
            cmbSubCategory.Size = new Size(194, 31);
            cmbSubCategory.TabIndex = 0;
            cmbSubCategory.Text = "Kategori";
            cmbSubCategory.SelectedIndexChanged += cmbSubCategory_SelectedIndexChanged;
            // 
            // cmbCategory
            // 
            cmbCategory.BackColor = Color.Silver;
            cmbCategory.FlatStyle = FlatStyle.Flat;
            cmbCategory.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cmbCategory.ForeColor = Color.OrangeRed;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "İçecekler", "Yiyecekler" });
            cmbCategory.Location = new Point(3, 21);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(194, 31);
            cmbCategory.TabIndex = 0;
            cmbCategory.Text = "Kategori";
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // panelFilters
            // 
            panelFilters.Controls.Add(pictureBox1);
            panelFilters.Controls.Add(btnFilter);
            panelFilters.Controls.Add(cmbFilterKind);
            panelFilters.Controls.Add(cmbFilterSubCategory);
            panelFilters.Controls.Add(cmbFilterCategory);
            panelFilters.Dock = DockStyle.Right;
            panelFilters.Location = new Point(488, 50);
            panelFilters.Name = "panelFilters";
            panelFilters.Size = new Size(203, 440);
            panelFilters.TabIndex = 31;
            panelFilters.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-223, 344);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(620, 500);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.Transparent;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnFilter.ForeColor = Color.OrangeRed;
            btnFilter.Location = new Point(26, 235);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(151, 37);
            btnFilter.TabIndex = 2;
            btnFilter.Text = "Filtreyi Uygula";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // cmbFilterKind
            // 
            cmbFilterKind.BackColor = Color.Silver;
            cmbFilterKind.FlatStyle = FlatStyle.Flat;
            cmbFilterKind.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cmbFilterKind.ForeColor = Color.OrangeRed;
            cmbFilterKind.FormattingEnabled = true;
            cmbFilterKind.Items.AddRange(new object[] { "Espresso", "Mocha", "Cappuccino", "Macchiato", "Americano", "Doubleshot", "Latte", "Filtre Kahveler", "Türk Kahvesi", "RIP Refresha® Drinks", "Teavana™ Sıcak Çaylar", "Teavana™ Tea Latte", "Kahve Bazlı Frappuccino®", "Krema Bazlı Frappuccino®", "Sıcak Çikolatalar", "Şişelenmiş İçecekler", "Pasta ve Kekler", "Cheesecakeler", "Muffin & Cookie", "Kahvaltılık Ürünler", "Sandviçler", "Salata Ve Parfeler", "Atıştırmalıklar" });
            cmbFilterKind.Location = new Point(26, 174);
            cmbFilterKind.Name = "cmbFilterKind";
            cmbFilterKind.Size = new Size(151, 31);
            cmbFilterKind.TabIndex = 0;
            cmbFilterKind.Text = "Tür Seç";
            // 
            // cmbFilterSubCategory
            // 
            cmbFilterSubCategory.BackColor = Color.Silver;
            cmbFilterSubCategory.FlatStyle = FlatStyle.Flat;
            cmbFilterSubCategory.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cmbFilterSubCategory.ForeColor = Color.OrangeRed;
            cmbFilterSubCategory.FormattingEnabled = true;
            cmbFilterSubCategory.Location = new Point(26, 113);
            cmbFilterSubCategory.Name = "cmbFilterSubCategory";
            cmbFilterSubCategory.Size = new Size(151, 31);
            cmbFilterSubCategory.TabIndex = 0;
            cmbFilterSubCategory.Text = "Alt Kategori Seç";
            cmbFilterSubCategory.SelectedIndexChanged += cmbFilterSubCategory_SelectedIndexChanged;
            // 
            // cmbFilterCategory
            // 
            cmbFilterCategory.BackColor = Color.Silver;
            cmbFilterCategory.FlatStyle = FlatStyle.Flat;
            cmbFilterCategory.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cmbFilterCategory.ForeColor = Color.OrangeRed;
            cmbFilterCategory.FormattingEnabled = true;
            cmbFilterCategory.Items.AddRange(new object[] { "Tümü", "İçecekler", "Yiyecekler" });
            cmbFilterCategory.Location = new Point(26, 52);
            cmbFilterCategory.Name = "cmbFilterCategory";
            cmbFilterCategory.Size = new Size(151, 31);
            cmbFilterCategory.TabIndex = 0;
            cmbFilterCategory.Text = "Kategori Seç";
            cmbFilterCategory.SelectedIndexChanged += cmbFilterCategory_SelectedIndexChanged;
            // 
            // panelPersons
            // 
            panelPersons.Controls.Add(dataGridPersons);
            panelPersons.Location = new Point(15, 224);
            panelPersons.Name = "panelPersons";
            panelPersons.Size = new Size(250, 125);
            panelPersons.TabIndex = 32;
            panelPersons.Visible = false;
            // 
            // panelPerson
            // 
            panelPerson.Controls.Add(txtPersonFirstName);
            panelPerson.Controls.Add(pictureBox3);
            panelPerson.Controls.Add(btnPersonAction);
            panelPerson.Controls.Add(txtPersonUserName);
            panelPerson.Controls.Add(txtPersonLastName);
            panelPerson.Controls.Add(txtPersonPassword);
            panelPerson.Controls.Add(cmbRole);
            panelPerson.Dock = DockStyle.Right;
            panelPerson.Location = new Point(280, 50);
            panelPerson.Name = "panelPerson";
            panelPerson.Size = new Size(208, 440);
            panelPerson.TabIndex = 33;
            panelPerson.Visible = false;
            panelPerson.Paint += panelPerson_Paint;
            // 
            // txtPersonFirstName
            // 
            txtPersonFirstName.BackColor = Color.Silver;
            txtPersonFirstName.BorderStyle = BorderStyle.None;
            txtPersonFirstName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtPersonFirstName.ForeColor = Color.OrangeRed;
            txtPersonFirstName.HideSelection = false;
            txtPersonFirstName.Location = new Point(16, 98);
            txtPersonFirstName.Multiline = true;
            txtPersonFirstName.Name = "txtPersonFirstName";
            txtPersonFirstName.Size = new Size(174, 25);
            txtPersonFirstName.TabIndex = 4;
            txtPersonFirstName.Text = "Adı";
            txtPersonFirstName.TextAlign = HorizontalAlignment.Center;
            txtPersonFirstName.Enter += txtPersonFirstName_Enter;
            txtPersonFirstName.Leave += txtPersonFirstName_Leave;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-233, 416);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(620, 500);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // btnPersonAction
            // 
            btnPersonAction.BackColor = Color.Transparent;
            btnPersonAction.FlatStyle = FlatStyle.Flat;
            btnPersonAction.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnPersonAction.ForeColor = Color.OrangeRed;
            btnPersonAction.Location = new Point(22, 369);
            btnPersonAction.Name = "btnPersonAction";
            btnPersonAction.Size = new Size(162, 37);
            btnPersonAction.TabIndex = 2;
            btnPersonAction.Text = "Kullanıcı Ekle";
            btnPersonAction.UseVisualStyleBackColor = false;
            btnPersonAction.Click += btnPersonAction_Click;
            // 
            // txtPersonUserName
            // 
            txtPersonUserName.BackColor = Color.Silver;
            txtPersonUserName.BorderStyle = BorderStyle.None;
            txtPersonUserName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtPersonUserName.ForeColor = Color.OrangeRed;
            txtPersonUserName.HideSelection = false;
            txtPersonUserName.Location = new Point(16, 240);
            txtPersonUserName.Multiline = true;
            txtPersonUserName.Name = "txtPersonUserName";
            txtPersonUserName.Size = new Size(174, 25);
            txtPersonUserName.TabIndex = 1;
            txtPersonUserName.Text = "Kullanıcı Adı";
            txtPersonUserName.TextAlign = HorizontalAlignment.Center;
            txtPersonUserName.Enter += txtPersonUserName_Enter;
            txtPersonUserName.Leave += txtPersonUserName_Leave;
            // 
            // txtPersonLastName
            // 
            txtPersonLastName.BackColor = Color.Silver;
            txtPersonLastName.BorderStyle = BorderStyle.None;
            txtPersonLastName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtPersonLastName.ForeColor = Color.OrangeRed;
            txtPersonLastName.HideSelection = false;
            txtPersonLastName.Location = new Point(16, 169);
            txtPersonLastName.Multiline = true;
            txtPersonLastName.Name = "txtPersonLastName";
            txtPersonLastName.Size = new Size(174, 25);
            txtPersonLastName.TabIndex = 1;
            txtPersonLastName.Text = "Soyadı";
            txtPersonLastName.TextAlign = HorizontalAlignment.Center;
            txtPersonLastName.Enter += txtPersonLastName_Enter;
            txtPersonLastName.Leave += txtPersonLastName_Leave;
            // 
            // txtPersonPassword
            // 
            txtPersonPassword.BackColor = Color.Silver;
            txtPersonPassword.BorderStyle = BorderStyle.None;
            txtPersonPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtPersonPassword.ForeColor = Color.OrangeRed;
            txtPersonPassword.HideSelection = false;
            txtPersonPassword.Location = new Point(16, 311);
            txtPersonPassword.Multiline = true;
            txtPersonPassword.Name = "txtPersonPassword";
            txtPersonPassword.Size = new Size(174, 25);
            txtPersonPassword.TabIndex = 1;
            txtPersonPassword.Text = "Şifre";
            txtPersonPassword.TextAlign = HorizontalAlignment.Center;
            txtPersonPassword.Enter += txtPersonPassword_Enter;
            txtPersonPassword.Leave += txtPersonPassword_Leave;
            // 
            // cmbRole
            // 
            cmbRole.BackColor = Color.Silver;
            cmbRole.FlatStyle = FlatStyle.Flat;
            cmbRole.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cmbRole.ForeColor = Color.OrangeRed;
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Kasa", "Garson" });
            cmbRole.Location = new Point(6, 21);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(194, 31);
            cmbRole.TabIndex = 0;
            cmbRole.Text = "Yetki Seç";
            cmbRole.SelectedIndexChanged += cmbRole_SelectedIndexChanged;
            // 
            // sidePanelPerson
            // 
            sidePanelPerson.AllowDrop = true;
            sidePanelPerson.ColumnCount = 1;
            sidePanelPerson.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            sidePanelPerson.Controls.Add(btnPersonEdit, 0, 2);
            sidePanelPerson.Controls.Add(btnPersonDel, 0, 4);
            sidePanelPerson.Controls.Add(btnPersonAdd, 0, 0);
            sidePanelPerson.Dock = DockStyle.Right;
            sidePanelPerson.Location = new Point(219, 50);
            sidePanelPerson.Name = "sidePanelPerson";
            sidePanelPerson.RowCount = 6;
            sidePanelPerson.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            sidePanelPerson.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            sidePanelPerson.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            sidePanelPerson.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            sidePanelPerson.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            sidePanelPerson.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            sidePanelPerson.Size = new Size(61, 440);
            sidePanelPerson.TabIndex = 34;
            sidePanelPerson.Visible = false;
            // 
            // btnPersonEdit
            // 
            btnPersonEdit.Dock = DockStyle.Right;
            btnPersonEdit.Image = Properties.Resources.icons8_edit_profile_50;
            btnPersonEdit.Location = new Point(8, 63);
            btnPersonEdit.Name = "btnPersonEdit";
            btnPersonEdit.Size = new Size(50, 49);
            btnPersonEdit.SizeMode = PictureBoxSizeMode.AutoSize;
            btnPersonEdit.TabIndex = 1;
            btnPersonEdit.TabStop = false;
            btnPersonEdit.Click += btnPersonEdit_Click;
            // 
            // btnPersonDel
            // 
            btnPersonDel.Dock = DockStyle.Right;
            btnPersonDel.Image = Properties.Resources.icons8_delete_50;
            btnPersonDel.Location = new Point(8, 123);
            btnPersonDel.Name = "btnPersonDel";
            btnPersonDel.Size = new Size(50, 49);
            btnPersonDel.SizeMode = PictureBoxSizeMode.AutoSize;
            btnPersonDel.TabIndex = 2;
            btnPersonDel.TabStop = false;
            btnPersonDel.Click += btnPersonDel_Click;
            // 
            // btnPersonAdd
            // 
            btnPersonAdd.Dock = DockStyle.Right;
            btnPersonAdd.Image = Properties.Resources.icons8_add_administrator_50;
            btnPersonAdd.Location = new Point(8, 3);
            btnPersonAdd.Name = "btnPersonAdd";
            btnPersonAdd.Size = new Size(50, 49);
            btnPersonAdd.SizeMode = PictureBoxSizeMode.AutoSize;
            btnPersonAdd.TabIndex = 0;
            btnPersonAdd.TabStop = false;
            btnPersonAdd.Click += btnPersonAdd_Click;
            // 
            // dataGridSales
            // 
            dataGridSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridSales.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridSales.ColumnHeadersHeight = 29;
            dataGridSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridSales.Location = new Point(-1, 18);
            dataGridSales.Name = "dataGridSales";
            dataGridSales.RowHeadersWidth = 51;
            dataGridSales.RowTemplate.Height = 29;
            dataGridSales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridSales.Size = new Size(191, 101);
            dataGridSales.TabIndex = 35;
            dataGridSales.CellContentClick += dataGridSales_CellContentClick;
            // 
            // panelSales
            // 
            panelSales.Controls.Add(dataGridSales);
            panelSales.Location = new Point(47, 365);
            panelSales.Name = "panelSales";
            panelSales.Size = new Size(134, 125);
            panelSales.TabIndex = 36;
            panelSales.Visible = false;
            // 
            // AdminPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(960, 540);
            Controls.Add(panelSales);
            Controls.Add(sidePanelPerson);
            Controls.Add(panelPerson);
            Controls.Add(panelPersons);
            Controls.Add(panelFilters);
            Controls.Add(panelAction);
            Controls.Add(sidePanelProduct);
            Controls.Add(panelProduct);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(TableTopPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminPage";
            Text = "AdminPage";
            Load += AdminPage_Load;
            TableTopPanel.ResumeLayout(false);
            TableTopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnUndoPage).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            PanelBottom.ResumeLayout(false);
            PanelBottom.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridProduct).EndInit();
            sidePanelProduct.ResumeLayout(false);
            sidePanelProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnProductEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnProductDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnProductAdd).EndInit();
            panelProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridPersons).EndInit();
            panelAction.ResumeLayout(false);
            panelAction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelFilters.ResumeLayout(false);
            panelFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelPersons.ResumeLayout(false);
            panelPerson.ResumeLayout(false);
            panelPerson.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            sidePanelPerson.ResumeLayout(false);
            sidePanelPerson.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnPersonEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnPersonDel).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnPersonAdd).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridSales).EndInit();
            panelSales.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TableTopPanel;
        private PictureBox btnUndoPage;
        private Label labMenuName;
        private PictureBox btnClose;
        private TableLayoutPanel PanelBottom;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label labDateTime;
        private Label labCafeText;
        private Label labLogo;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TableLayoutPanel panelProduct;
        private DataGridView dataGridProduct;
        private TableLayoutPanel sidePanelProduct;
        private PictureBox btnProductAdd;
        private PictureBox btnProductEdit;
        private PictureBox btnProductDelete;
        private Panel panelAction;
        private Button btnAction;
        private ComboBox cmbCategory;
        private PictureBox pictureBox2;
        private TextBox txtProductName;
        private Panel panelFilters;
        private PictureBox pictureBox1;
        private Button btnFilter;
        private ComboBox cmbFilterKind;
        private ComboBox cmbFilterSubCategory;
        private ComboBox cmbFilterCategory;
        private TextBox txtSalePrice;
        private ComboBox cmbKind;
        private ComboBox cmbSubCategory;
        private DataGridView dataGridPersons;
        private Panel panelPersons;
        private Panel panelPerson;
        private TextBox txtPersonFirstName;
        private PictureBox pictureBox3;
        private Button btnPersonAction;
        private TextBox txtPersonUserName;
        private TextBox txtPersonLastName;
        private TextBox txtPersonPassword;
        private ComboBox cmbRole;
        private TableLayoutPanel sidePanelPerson;
        private PictureBox btnPersonEdit;
        private PictureBox btnPersonDel;
        private PictureBox btnPersonAdd;
        private DataGridView dataGridSales;
        private Panel panelSales;
    }
}