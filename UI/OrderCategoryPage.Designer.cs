namespace UI
{
    partial class OrderCategoryPage
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
            CategoryPanel = new TableLayoutPanel();
            btnDrinks = new PictureBox();
            btnFood = new PictureBox();
            labDrinks = new Label();
            label1 = new Label();
            btnUndo = new PictureBox();
            btnExit = new PictureBox();
            CategoryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnDrinks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnFood).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnUndo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
            SuspendLayout();
            // 
            // CategoryPanel
            // 
            CategoryPanel.ColumnCount = 4;
            CategoryPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            CategoryPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            CategoryPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            CategoryPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            CategoryPanel.Controls.Add(btnDrinks, 1, 1);
            CategoryPanel.Controls.Add(btnFood, 2, 1);
            CategoryPanel.Controls.Add(labDrinks, 1, 2);
            CategoryPanel.Controls.Add(label1, 2, 2);
            CategoryPanel.Controls.Add(btnUndo, 0, 0);
            CategoryPanel.Controls.Add(btnExit, 3, 0);
            CategoryPanel.Dock = DockStyle.Fill;
            CategoryPanel.Location = new Point(0, 0);
            CategoryPanel.Name = "CategoryPanel";
            CategoryPanel.RowCount = 4;
            CategoryPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            CategoryPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 66.66666F));
            CategoryPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            CategoryPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            CategoryPanel.Size = new Size(960, 540);
            CategoryPanel.TabIndex = 0;
            // 
            // btnDrinks
            // 
            btnDrinks.Dock = DockStyle.Fill;
            btnDrinks.Image = Properties.Resources._377251;
            btnDrinks.Location = new Point(99, 86);
            btnDrinks.Name = "btnDrinks";
            btnDrinks.Size = new Size(378, 325);
            btnDrinks.SizeMode = PictureBoxSizeMode.Zoom;
            btnDrinks.TabIndex = 0;
            btnDrinks.TabStop = false;
            btnDrinks.Click += btnDrinks_Click;
            // 
            // btnFood
            // 
            btnFood.Dock = DockStyle.Fill;
            btnFood.Image = Properties.Resources.images2;
            btnFood.Location = new Point(483, 86);
            btnFood.Name = "btnFood";
            btnFood.Size = new Size(378, 325);
            btnFood.SizeMode = PictureBoxSizeMode.Zoom;
            btnFood.TabIndex = 1;
            btnFood.TabStop = false;
            btnFood.Click += btnFood_Click;
            // 
            // labDrinks
            // 
            labDrinks.AutoSize = true;
            labDrinks.Dock = DockStyle.Fill;
            labDrinks.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            labDrinks.ForeColor = Color.OrangeRed;
            labDrinks.Location = new Point(99, 414);
            labDrinks.Name = "labDrinks";
            labDrinks.Size = new Size(378, 42);
            labDrinks.TabIndex = 2;
            labDrinks.Text = "İçecekler";
            labDrinks.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(483, 414);
            label1.Name = "label1";
            label1.Size = new Size(378, 42);
            label1.TabIndex = 2;
            label1.Text = "Yiyecekler";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnUndo
            // 
            btnUndo.Dock = DockStyle.Fill;
            btnUndo.Image = Properties.Resources.icons8_undo_80;
            btnUndo.Location = new Point(3, 3);
            btnUndo.Name = "btnUndo";
            btnUndo.Size = new Size(90, 77);
            btnUndo.TabIndex = 3;
            btnUndo.TabStop = false;
            btnUndo.Click += btnUndo_Click;
            // 
            // btnExit
            // 
            btnExit.Dock = DockStyle.Fill;
            btnExit.Image = Properties.Resources.icons8_exit_80;
            btnExit.Location = new Point(867, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(90, 77);
            btnExit.TabIndex = 4;
            btnExit.TabStop = false;
            btnExit.Click += btnExit_Click;
            // 
            // OrderCategoryPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 540);
            Controls.Add(CategoryPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OrderCategoryPage";
            Text = "OrderCategoryPage";
            CategoryPanel.ResumeLayout(false);
            CategoryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnDrinks).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnFood).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnUndo).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel CategoryPanel;
        private PictureBox btnDrinks;
        private PictureBox btnFood;
        private Label labDrinks;
        private Label label1;
        private PictureBox btnUndo;
        private PictureBox btnExit;
    }
}