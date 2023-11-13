namespace Gerenciador_de_estoque
{
    partial class F_Clientes
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.mtb_dataDeCompra = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_0 = new System.Windows.Forms.Label();
            this.tb_precoDeCompra = new System.Windows.Forms.TextBox();
            this.tb_fornecedor = new System.Windows.Forms.TextBox();
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
            this.p_editar.Controls.Add(this.button4);
            this.p_editar.Controls.Add(this.button3);
            this.p_editar.Controls.Add(this.button1);
            this.p_editar.Controls.Add(this.mtb_dataDeCompra);
            this.p_editar.Controls.Add(this.label7);
            this.p_editar.Controls.Add(this.label6);
            this.p_editar.Controls.Add(this.label4);
            this.p_editar.Controls.Add(this.label3);
            this.p_editar.Controls.Add(this.label2);
            this.p_editar.Controls.Add(this.label1);
            this.p_editar.Controls.Add(this.label_0);
            this.p_editar.Controls.Add(this.tb_precoDeCompra);
            this.p_editar.Controls.Add(this.tb_fornecedor);
            this.p_editar.Controls.Add(this.tb_quantidade);
            this.p_editar.Controls.Add(this.tb_produto);
            this.p_editar.Controls.Add(this.tb_tipoDeProduto);
            this.p_editar.Controls.Add(this.tb_id);
            this.p_editar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.p_editar.Location = new System.Drawing.Point(0, 618);
            this.p_editar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.p_editar.Name = "p_editar";
            this.p_editar.Size = new System.Drawing.Size(1704, 328);
            this.p_editar.TabIndex = 2;
            // 
            // cb_filtro
            // 
            this.cb_filtro.FormattingEnabled = true;
            this.cb_filtro.Items.AddRange(new object[] {
            "Nome",
            "Telefone",
            "CPF",
            "Produto",
            "Data de Compra",
            "Garantia",
            "Preço de Compra"});
            this.cb_filtro.Location = new System.Drawing.Point(258, 111);
            this.cb_filtro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_filtro.Name = "cb_filtro";
            this.cb_filtro.Size = new System.Drawing.Size(180, 28);
            this.cb_filtro.TabIndex = 24;
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
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(20, 208);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(226, 43);
            this.button4.TabIndex = 20;
            this.button4.Text = "Remover";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(21, 260);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(226, 43);
            this.button3.TabIndex = 19;
            this.button3.Text = "Editar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 155);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 43);
            this.button1.TabIndex = 17;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // mtb_dataDeCompra
            // 
            this.mtb_dataDeCompra.Location = new System.Drawing.Point(928, 42);
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
            this.label7.Location = new System.Drawing.Point(1104, 12);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Garantia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1342, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Preço de Compra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(924, 12);
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
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(782, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Produto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Telefone";
            // 
            // label_0
            // 
            this.label_0.AutoSize = true;
            this.label_0.Location = new System.Drawing.Point(20, 12);
            this.label_0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_0.Name = "label_0";
            this.label_0.Size = new System.Drawing.Size(51, 20);
            this.label_0.TabIndex = 8;
            this.label_0.Text = "Nome";
            // 
            // tb_precoDeCompra
            // 
            this.tb_precoDeCompra.Location = new System.Drawing.Point(1347, 42);
            this.tb_precoDeCompra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_precoDeCompra.Name = "tb_precoDeCompra";
            this.tb_precoDeCompra.Size = new System.Drawing.Size(157, 26);
            this.tb_precoDeCompra.TabIndex = 7;
            this.tb_precoDeCompra.Text = "R$ ";
            // 
            // tb_fornecedor
            // 
            this.tb_fornecedor.Location = new System.Drawing.Point(1108, 42);
            this.tb_fornecedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_fornecedor.Name = "tb_fornecedor";
            this.tb_fornecedor.Size = new System.Drawing.Size(228, 26);
            this.tb_fornecedor.TabIndex = 6;
            // 
            // tb_quantidade
            // 
            this.tb_quantidade.Location = new System.Drawing.Point(786, 42);
            this.tb_quantidade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_quantidade.Name = "tb_quantidade";
            this.tb_quantidade.Size = new System.Drawing.Size(132, 26);
            this.tb_quantidade.TabIndex = 3;
            // 
            // tb_produto
            // 
            this.tb_produto.Location = new System.Drawing.Point(406, 42);
            this.tb_produto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_produto.Name = "tb_produto";
            this.tb_produto.Size = new System.Drawing.Size(368, 26);
            this.tb_produto.TabIndex = 2;
            // 
            // tb_tipoDeProduto
            // 
            this.tb_tipoDeProduto.Location = new System.Drawing.Point(130, 42);
            this.tb_tipoDeProduto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_tipoDeProduto.Name = "tb_tipoDeProduto";
            this.tb_tipoDeProduto.Size = new System.Drawing.Size(265, 26);
            this.tb_tipoDeProduto.TabIndex = 1;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(20, 42);
            this.tb_id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(100, 26);
            this.tb_id.TabIndex = 0;
            // 
            // F_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1704, 946);
            this.Controls.Add(this.p_editar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "F_Clientes";
            this.ShowInTaskbar = false;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.F_Clientes_Load);
            this.p_editar.ResumeLayout(false);
            this.p_editar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel p_editar;
        private System.Windows.Forms.ComboBox cb_filtro;
        private System.Windows.Forms.TextBox tb_pesquisa;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox mtb_dataDeCompra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_0;
        private System.Windows.Forms.TextBox tb_precoDeCompra;
        private System.Windows.Forms.TextBox tb_fornecedor;
        private System.Windows.Forms.TextBox tb_quantidade;
        private System.Windows.Forms.TextBox tb_produto;
        private System.Windows.Forms.TextBox tb_tipoDeProduto;
        private System.Windows.Forms.TextBox tb_id;
    }
}