namespace A062
{
    partial class F_listView
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
            ColumnHeader col_id;
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "0", "Mouse", "120", "19.99" }, -1);
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "1", "Teclado", "85", "39.99" }, -1);
            ListViewItem listViewItem3 = new ListViewItem(new string[] { "2", "Monitor", "38", "500.00" }, -1);
            lv_produtos = new ListView();
            col_produto = new ColumnHeader();
            col_quantidade = new ColumnHeader();
            col_preco = new ColumnHeader();
            tb_id = new TextBox();
            tb_produto = new TextBox();
            tb_qtde = new TextBox();
            tb_preco = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btn_adicionar = new Button();
            btn_remover = new Button();
            col_id = new ColumnHeader();
            SuspendLayout();
            // 
            // col_id
            // 
            col_id.Text = "ID";
            col_id.Width = 40;
            // 
            // lv_produtos
            // 
            lv_produtos.Columns.AddRange(new ColumnHeader[] { col_id, col_produto, col_quantidade, col_preco });
            lv_produtos.FullRowSelect = true;
            lv_produtos.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3 });
            lv_produtos.Location = new Point(12, 12);
            lv_produtos.MultiSelect = false;
            lv_produtos.Name = "lv_produtos";
            lv_produtos.Size = new Size(494, 97);
            lv_produtos.TabIndex = 0;
            lv_produtos.UseCompatibleStateImageBehavior = false;
            lv_produtos.View = View.Details;
            lv_produtos.SelectedIndexChanged += Lv_produtos_SelectedIndexChanged;
            // 
            // col_produto
            // 
            col_produto.Text = "Produto";
            col_produto.Width = 250;
            // 
            // col_quantidade
            // 
            col_quantidade.Text = "Quantidade";
            col_quantidade.Width = 80;
            // 
            // col_preco
            // 
            col_preco.Text = "Preço";
            col_preco.Width = 120;
            // 
            // tb_id
            // 
            tb_id.Location = new Point(12, 152);
            tb_id.Name = "tb_id";
            tb_id.Size = new Size(32, 23);
            tb_id.TabIndex = 1;
            // 
            // tb_produto
            // 
            tb_produto.Location = new Point(50, 152);
            tb_produto.Name = "tb_produto";
            tb_produto.Size = new Size(259, 23);
            tb_produto.TabIndex = 2;
            // 
            // tb_qtde
            // 
            tb_qtde.Location = new Point(315, 152);
            tb_qtde.Name = "tb_qtde";
            tb_qtde.Size = new Size(67, 23);
            tb_qtde.TabIndex = 3;
            // 
            // tb_preco
            // 
            tb_preco.Location = new Point(388, 152);
            tb_preco.Name = "tb_preco";
            tb_preco.Size = new Size(116, 23);
            tb_preco.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 134);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 5;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 134);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 6;
            label2.Text = "Produto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(313, 134);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 7;
            label3.Text = "Quantidade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(388, 134);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 8;
            label4.Text = "Preço";
            // 
            // btn_adicionar
            // 
            btn_adicionar.Location = new Point(25, 200);
            btn_adicionar.Name = "btn_adicionar";
            btn_adicionar.Size = new Size(75, 23);
            btn_adicionar.TabIndex = 9;
            btn_adicionar.Text = "Adicionar";
            btn_adicionar.UseVisualStyleBackColor = true;
            btn_adicionar.Click += Btn_adicionar_Click;
            // 
            // btn_remover
            // 
            btn_remover.Location = new Point(25, 229);
            btn_remover.Name = "btn_remover";
            btn_remover.Size = new Size(75, 23);
            btn_remover.TabIndex = 10;
            btn_remover.Text = "Remover";
            btn_remover.UseVisualStyleBackColor = true;
            btn_remover.Click += Btn_remover_Click;
            // 
            // F_listView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 334);
            Controls.Add(btn_remover);
            Controls.Add(btn_adicionar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_preco);
            Controls.Add(tb_qtde);
            Controls.Add(tb_produto);
            Controls.Add(tb_id);
            Controls.Add(lv_produtos);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "F_listView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "F_listView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lv_produtos;
        private ColumnHeader col_produto;
        private ColumnHeader col_quantidade;
        private ColumnHeader col_preco;
        private TextBox tb_id;
        private TextBox tb_produto;
        private TextBox tb_qtde;
        private TextBox tb_preco;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_adicionar;
        private Button btn_remover;
    }
}