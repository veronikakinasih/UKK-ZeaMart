namespace ZeaMart
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            tb_search = new TextBox();
            label7 = new Label();
            label2 = new Label();
            tb_id = new TextBox();
            label3 = new Label();
            label4 = new Label();
            tb_harga = new TextBox();
            label5 = new Label();
            label6 = new Label();
            tb_kategori = new TextBox();
            panel3 = new Panel();
            tb_nama = new TextBox();
            tb_stok = new TextBox();
            btn_add = new Button();
            btn_delete = new Button();
            btn_update = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumOrchid;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(867, 57);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(25, 19);
            label1.Name = "label1";
            label1.Size = new Size(151, 19);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Zeamart";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(19, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(426, 254);
            dataGridView1.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Thistle;
            panel2.Controls.Add(tb_search);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(375, 86);
            panel2.Name = "panel2";
            panel2.Size = new Size(459, 332);
            panel2.TabIndex = 12;
            // 
            // tb_search
            // 
            tb_search.Location = new Point(74, 21);
            tb_search.Name = "tb_search";
            tb_search.Size = new Size(371, 23);
            tb_search.TabIndex = 14;
            tb_search.TextChanged += tb_search_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 29);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 13;
            label7.Text = "Search";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 51);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 1;
            label2.Text = "Id";
            // 
            // tb_id
            // 
            tb_id.Location = new Point(87, 43);
            tb_id.Name = "tb_id";
            tb_id.Size = new Size(222, 23);
            tb_id.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 92);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 3;
            label3.Text = "Nama";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 138);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 5;
            label4.Text = "Kategori";
            // 
            // tb_harga
            // 
            tb_harga.Location = new Point(87, 214);
            tb_harga.Name = "tb_harga";
            tb_harga.Size = new Size(222, 23);
            tb_harga.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 179);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 7;
            label5.Text = "Stok";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 222);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 9;
            label6.Text = "Harga";
            // 
            // tb_kategori
            // 
            tb_kategori.Location = new Point(87, 130);
            tb_kategori.Name = "tb_kategori";
            tb_kategori.Size = new Size(222, 23);
            tb_kategori.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Thistle;
            panel3.Controls.Add(tb_nama);
            panel3.Controls.Add(tb_stok);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(tb_harga);
            panel3.Controls.Add(tb_id);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(tb_kategori);
            panel3.Location = new Point(25, 86);
            panel3.Name = "panel3";
            panel3.Size = new Size(333, 292);
            panel3.TabIndex = 15;
            // 
            // tb_nama
            // 
            tb_nama.Location = new Point(87, 89);
            tb_nama.Name = "tb_nama";
            tb_nama.Size = new Size(222, 23);
            tb_nama.TabIndex = 11;
            // 
            // tb_stok
            // 
            tb_stok.Location = new Point(87, 171);
            tb_stok.Name = "tb_stok";
            tb_stok.Size = new Size(222, 23);
            tb_stok.TabIndex = 8;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.MediumPurple;
            btn_add.FlatStyle = FlatStyle.Popup;
            btn_add.Location = new Point(25, 395);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(100, 23);
            btn_add.TabIndex = 16;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.MediumPurple;
            btn_delete.FlatStyle = FlatStyle.Popup;
            btn_delete.Location = new Point(251, 395);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(107, 23);
            btn_delete.TabIndex = 19;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.MediumPurple;
            btn_update.FlatStyle = FlatStyle.Popup;
            btn_update.Location = new Point(138, 395);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(104, 23);
            btn_update.TabIndex = 18;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(867, 454);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private TextBox tb_search;
        private Label label7;
        private Label label2;
        private TextBox tb_id;
        private Label label3;
        private Label label4;
        private TextBox tb_harga;
        private Label label5;
        private Label label6;
        private TextBox tb_kategori;
        private Panel panel3;
        private TextBox tb_stok;
        private TextBox tb_nama;
        private Button btn_add;
        private Button btn_delete;
        private Button btn_update;
    }
}