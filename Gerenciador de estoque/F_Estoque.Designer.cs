namespace Gerenciador_de_estoque
{
    partial class F_Estoque
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
            this.p_editar = new System.Windows.Forms.Panel();
            this.cb_filtro = new System.Windows.Forms.ComboBox();
            this.tb_pesquisa = new System.Windows.Forms.TextBox();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.mtb_dataDeCompra = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_0 = new System.Windows.Forms.Label();
            this.tb_precoDeCompra = new System.Windows.Forms.TextBox();
            this.tb_fornecedor = new System.Windows.Forms.TextBox();
            this.tb_preco = new System.Windows.Forms.TextBox();
            this.tb_quantidade = new System.Windows.Forms.TextBox();
            this.tb_produto = new System.Windows.Forms.TextBox();
            this.tb_tipoDeProduto = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.p_editar.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_editar
            // 
            this.p_editar.BackColor = System.Drawing.SystemColors.Control;
            this.p_editar.Controls.Add(this.cb_filtro);
            this.p_editar.Controls.Add(this.tb_pesquisa);
            this.p_editar.Controls.Add(this.btn_pesquisar);
            this.p_editar.Controls.Add(this.btn_remover);
            this.p_editar.Controls.Add(this.btn_editar);
            this.p_editar.Controls.Add(this.btn_adicionar);
            this.p_editar.Controls.Add(this.mtb_dataDeCompra);
            this.p_editar.Controls.Add(this.label7);
            this.p_editar.Controls.Add(this.label6);
            this.p_editar.Controls.Add(this.label5);
            this.p_editar.Controls.Add(this.label4);
            this.p_editar.Controls.Add(this.label3);
            this.p_editar.Controls.Add(this.label2);
            this.p_editar.Controls.Add(this.label1);
            this.p_editar.Controls.Add(this.label_0);
            this.p_editar.Controls.Add(this.tb_precoDeCompra);
            this.p_editar.Controls.Add(this.tb_fornecedor);
            this.p_editar.Controls.Add(this.tb_preco);
            this.p_editar.Controls.Add(this.tb_quantidade);
            this.p_editar.Controls.Add(this.tb_produto);
            this.p_editar.Controls.Add(this.tb_tipoDeProduto);
            this.p_editar.Controls.Add(this.tb_id);
            this.p_editar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.p_editar.Location = new System.Drawing.Point(0, 734);
            this.p_editar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.p_editar.Name = "p_editar";
            this.p_editar.Size = new System.Drawing.Size(1920, 346);
            this.p_editar.TabIndex = 1;
            // 
            // cb_filtro
            // 
            this.cb_filtro.FormattingEnabled = true;
            this.cb_filtro.Items.AddRange(new object[] {
            "Tipo de Produto",
            "Produto",
            "Fornecedor",
            "Todos"});
            this.cb_filtro.Location = new System.Drawing.Point(258, 111);
            this.cb_filtro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_filtro.Name = "cb_filtro";
            this.cb_filtro.Size = new System.Drawing.Size(180, 28);
            this.cb_filtro.TabIndex = 24;
            this.cb_filtro.Text = "Tipo de Produto";
            // 
            // tb_pesquisa
            // 
            this.tb_pesquisa.Location = new System.Drawing.Point(456, 111);
            this.tb_pesquisa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_pesquisa.Name = "tb_pesquisa";
            this.tb_pesquisa.Size = new System.Drawing.Size(265, 26);
            this.tb_pesquisa.TabIndex = 23;
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Location = new System.Drawing.Point(21, 103);
            this.btn_pesquisar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(226, 43);
            this.btn_pesquisar.TabIndex = 21;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.Location = new System.Drawing.Point(20, 208);
            this.btn_remover.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(226, 43);
            this.btn_remover.TabIndex = 20;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(21, 260);
            this.btn_editar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(226, 43);
            this.btn_editar.TabIndex = 19;
            this.btn_editar.Text = "Salvar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(20, 155);
            this.btn_adicionar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(226, 43);
            this.btn_adicionar.TabIndex = 17;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // mtb_dataDeCompra
            // 
            this.mtb_dataDeCompra.Location = new System.Drawing.Point(1092, 42);
            this.mtb_dataDeCompra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mtb_dataDeCompra.Mask = "00/00/0000";
            this.mtb_dataDeCompra.Name = "mtb_dataDeCompra";
            this.mtb_dataDeCompra.Size = new System.Drawing.Size(169, 26);
            this.mtb_dataDeCompra.TabIndex = 16;
            this.mtb_dataDeCompra.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1268, 12);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Fornecedor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1506, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Preço de Compra";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(928, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Preço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1088, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Data de Compra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(786, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Quantidade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tipo de Produto";
            // 
            // label_0
            // 
            this.label_0.AutoSize = true;
            this.label_0.Location = new System.Drawing.Point(20, 12);
            this.label_0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_0.Name = "label_0";
            this.label_0.Size = new System.Drawing.Size(26, 20);
            this.label_0.TabIndex = 8;
            this.label_0.Text = "ID";
            // 
            // tb_precoDeCompra
            // 
            this.tb_precoDeCompra.Location = new System.Drawing.Point(1510, 42);
            this.tb_precoDeCompra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_precoDeCompra.Name = "tb_precoDeCompra";
            this.tb_precoDeCompra.Size = new System.Drawing.Size(157, 26);
            this.tb_precoDeCompra.TabIndex = 7;
            this.tb_precoDeCompra.Text = "R$";
            this.tb_precoDeCompra.MultilineChanged += new System.EventHandler(this.tb_precoDeCompra_MultilineChanged);
            // 
            // tb_fornecedor
            // 
            this.tb_fornecedor.Location = new System.Drawing.Point(1272, 42);
            this.tb_fornecedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_fornecedor.Name = "tb_fornecedor";
            this.tb_fornecedor.Size = new System.Drawing.Size(228, 26);
            this.tb_fornecedor.TabIndex = 6;
            // 
            // tb_preco
            // 
            this.tb_preco.Location = new System.Drawing.Point(933, 42);
            this.tb_preco.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_preco.Name = "tb_preco";
            this.tb_preco.Size = new System.Drawing.Size(148, 26);
            this.tb_preco.TabIndex = 4;
            this.tb_preco.Text = "R$ ";
            // 
            // tb_quantidade
            // 
            this.tb_quantidade.Location = new System.Drawing.Point(790, 42);
            this.tb_quantidade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_quantidade.Name = "tb_quantidade";
            this.tb_quantidade.Size = new System.Drawing.Size(132, 26);
            this.tb_quantidade.TabIndex = 3;
            // 
            // tb_produto
            // 
            this.tb_produto.Location = new System.Drawing.Point(411, 42);
            this.tb_produto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_produto.Name = "tb_produto";
            this.tb_produto.Size = new System.Drawing.Size(368, 26);
            this.tb_produto.TabIndex = 2;
            // 
            // tb_tipoDeProduto
            // 
            this.tb_tipoDeProduto.Location = new System.Drawing.Point(135, 42);
            this.tb_tipoDeProduto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_tipoDeProduto.Name = "tb_tipoDeProduto";
            this.tb_tipoDeProduto.Size = new System.Drawing.Size(265, 26);
            this.tb_tipoDeProduto.TabIndex = 1;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(24, 42);
            this.tb_id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(100, 26);
            this.tb_id.TabIndex = 0;
            // 
            // F_Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.ControlBox = false;
            this.Controls.Add(this.p_editar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "F_Estoque";
            this.ShowInTaskbar = false;
            this.Text = "F_Estoque";
            this.Load += new System.EventHandler(this.F_Estoque_Load);
            this.p_editar.ResumeLayout(false);
            this.p_editar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel p_editar;
        private System.Windows.Forms.TextBox tb_preco;
        private System.Windows.Forms.TextBox tb_quantidade;
        private System.Windows.Forms.TextBox tb_produto;
        private System.Windows.Forms.TextBox tb_tipoDeProduto;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_0;
        private System.Windows.Forms.TextBox tb_precoDeCompra;
        private System.Windows.Forms.TextBox tb_fornecedor;
        private System.Windows.Forms.MaskedTextBox mtb_dataDeCompra;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.TextBox tb_pesquisa;
        private System.Windows.Forms.ComboBox cb_filtro;
    }
}