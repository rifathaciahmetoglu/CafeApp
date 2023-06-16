namespace UI
{
    partial class OrderPage
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
            tableLayoutPanel1 = new TableLayoutPanel();
            OrderList = new ListBox();
            productList = new ListBox();
            button1 = new Button();
            Undo = new PictureBox();
            Exit = new PictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            btn1x = new Button();
            btn2x = new Button();
            btn3x = new Button();
            btnTakeOrder = new Button();
            btnPayment = new Button();
            labTotalPrice = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Undo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Exit).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.5263157F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.8421059F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.263158F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.8421059F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.5263157F));
            tableLayoutPanel1.Controls.Add(OrderList, 3, 1);
            tableLayoutPanel1.Controls.Add(productList, 1, 1);
            tableLayoutPanel1.Controls.Add(button1, 1, 2);
            tableLayoutPanel1.Controls.Add(Undo, 0, 0);
            tableLayoutPanel1.Controls.Add(Exit, 4, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 2, 1);
            tableLayoutPanel1.Controls.Add(btnTakeOrder, 3, 2);
            tableLayoutPanel1.Controls.Add(btnPayment, 4, 2);
            tableLayoutPanel1.Controls.Add(labTotalPrice, 4, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 66.66667F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.Size = new Size(960, 540);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // OrderList
            // 
            OrderList.Dock = DockStyle.Fill;
            OrderList.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            OrderList.FormattingEnabled = true;
            OrderList.ItemHeight = 31;
            OrderList.Location = new Point(507, 92);
            OrderList.Name = "OrderList";
            OrderList.Size = new Size(347, 353);
            OrderList.TabIndex = 1;
            OrderList.SelectedIndexChanged += OrderList_SelectedIndexChanged;
            // 
            // productList
            // 
            productList.Dock = DockStyle.Fill;
            productList.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            productList.FormattingEnabled = true;
            productList.ItemHeight = 31;
            productList.Location = new Point(104, 92);
            productList.Name = "productList";
            productList.Size = new Size(347, 353);
            productList.TabIndex = 2;
            productList.SelectedIndexChanged += productList_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(104, 451);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Undo
            // 
            Undo.Dock = DockStyle.Fill;
            Undo.Image = Properties.Resources.icons8_undo_80;
            Undo.Location = new Point(3, 3);
            Undo.Name = "Undo";
            Undo.Size = new Size(95, 83);
            Undo.SizeMode = PictureBoxSizeMode.AutoSize;
            Undo.TabIndex = 4;
            Undo.TabStop = false;
            Undo.Click += Undo_Click;
            // 
            // Exit
            // 
            Exit.Dock = DockStyle.Fill;
            Exit.Image = Properties.Resources.icons8_exit_80;
            Exit.Location = new Point(860, 3);
            Exit.Name = "Exit";
            Exit.Size = new Size(97, 83);
            Exit.TabIndex = 5;
            Exit.TabStop = false;
            Exit.Click += Exit_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(btn1x, 0, 1);
            tableLayoutPanel2.Controls.Add(btn2x, 0, 2);
            tableLayoutPanel2.Controls.Add(btn3x, 0, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(457, 92);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel2.Size = new Size(44, 353);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // btn1x
            // 
            btn1x.Dock = DockStyle.Fill;
            btn1x.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn1x.ForeColor = Color.OrangeRed;
            btn1x.Location = new Point(3, 20);
            btn1x.Name = "btn1x";
            btn1x.Size = new Size(38, 99);
            btn1x.TabIndex = 0;
            btn1x.Text = "x1";
            btn1x.UseVisualStyleBackColor = true;
            btn1x.Click += btn1x_Click;
            // 
            // btn2x
            // 
            btn2x.Dock = DockStyle.Fill;
            btn2x.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn2x.ForeColor = Color.OrangeRed;
            btn2x.Location = new Point(3, 125);
            btn2x.Name = "btn2x";
            btn2x.Size = new Size(38, 99);
            btn2x.TabIndex = 1;
            btn2x.Text = "x2";
            btn2x.UseVisualStyleBackColor = true;
            btn2x.Click += btn2x_Click;
            // 
            // btn3x
            // 
            btn3x.Dock = DockStyle.Fill;
            btn3x.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn3x.ForeColor = Color.OrangeRed;
            btn3x.Location = new Point(3, 230);
            btn3x.Name = "btn3x";
            btn3x.Size = new Size(38, 99);
            btn3x.TabIndex = 1;
            btn3x.Text = "x3";
            btn3x.UseVisualStyleBackColor = true;
            btn3x.Click += btn3x_Click;
            // 
            // btnTakeOrder
            // 
            btnTakeOrder.Location = new Point(507, 451);
            btnTakeOrder.Name = "btnTakeOrder";
            btnTakeOrder.Size = new Size(94, 29);
            btnTakeOrder.TabIndex = 7;
            btnTakeOrder.Text = "button2";
            btnTakeOrder.UseVisualStyleBackColor = true;
            btnTakeOrder.Click += btnTakeOrder_Click;
            // 
            // btnPayment
            // 
            btnPayment.Location = new Point(860, 451);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(88, 49);
            btnPayment.TabIndex = 8;
            btnPayment.Text = "button2";
            btnPayment.UseVisualStyleBackColor = true;
            btnPayment.Click += btnPayment_Click;
            // 
            // labTotalPrice
            // 
            labTotalPrice.AutoSize = true;
            labTotalPrice.Location = new Point(860, 89);
            labTotalPrice.Name = "labTotalPrice";
            labTotalPrice.Size = new Size(65, 40);
            labTotalPrice.TabIndex = 9;
            labTotalPrice.Text = "TOPLAM FIYAT:";
            labTotalPrice.TextAlign = ContentAlignment.BottomCenter;
            // 
            // OrderPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 540);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OrderPage";
            Text = "Order";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Undo).EndInit();
            ((System.ComponentModel.ISupportInitialize)Exit).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ListBox OrderList;
        private ListBox productList;
        private Button button1;
        private PictureBox Undo;
        private PictureBox Exit;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btn1x;
        private Button btn2x;
        private Button btn3x;
        private Button btnTakeOrder;
        private Button btnPayment;
        private Label labTotalPrice;
    }
}