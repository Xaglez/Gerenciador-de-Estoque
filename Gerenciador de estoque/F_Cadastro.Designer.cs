namespace Gerenciador_de_estoque
{
    partial class F_Cadastro
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
            this.gb_consulta = new System.Windows.Forms.GroupBox();
            this.btn_buscarTodosUsuarios = new System.Windows.Forms.Button();
            this.dgv_consulta = new System.Windows.Forms.DataGridView();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.tb_nomePesquisa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_idPesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_endereço = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.n_nivel = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_telefone = new System.Windows.Forms.TextBox();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_cargaHoraria = new System.Windows.Forms.TextBox();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_dataInicio = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_cargo = new System.Windows.Forms.TextBox();
            this.gb_consulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_nivel)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_consulta
            // 
            this.gb_consulta.Controls.Add(this.btn_buscarTodosUsuarios);
            this.gb_consulta.Controls.Add(this.dgv_consulta);
            this.gb_consulta.Controls.Add(this.btn_buscar);
            this.gb_consulta.Controls.Add(this.tb_nomePesquisa);
            this.gb_consulta.Controls.Add(this.label2);
            this.gb_consulta.Controls.Add(this.tb_idPesquisa);
            this.gb_consulta.Controls.Add(this.label1);
            this.gb_consulta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gb_consulta.Location = new System.Drawing.Point(0, 386);
            this.gb_consulta.Name = "gb_consulta";
            this.gb_consulta.Size = new System.Drawing.Size(1350, 343);
            this.gb_consulta.TabIndex = 1;
            this.gb_consulta.TabStop = false;
            this.gb_consulta.Text = "Consulta";
            // 
            // btn_buscarTodosUsuarios
            // 
            this.btn_buscarTodosUsuarios.Location = new System.Drawing.Point(447, 36);
            this.btn_buscarTodosUsuarios.Name = "btn_buscarTodosUsuarios";
            this.btn_buscarTodosUsuarios.Size = new System.Drawing.Size(137, 20);
            this.btn_buscarTodosUsuarios.TabIndex = 6;
            this.btn_buscarTodosUsuarios.Text = "Buscar Todos Usuários";
            this.btn_buscarTodosUsuarios.UseVisualStyleBackColor = true;
            this.btn_buscarTodosUsuarios.Click += new System.EventHandler(this.button4_Click);
            // 
            // dgv_consulta
            // 
            this.dgv_consulta.AllowUserToAddRows = false;
            this.dgv_consulta.AllowUserToDeleteRows = false;
            this.dgv_consulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_consulta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_consulta.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_consulta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_consulta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_consulta.Location = new System.Drawing.Point(3, 63);
            this.dgv_consulta.Name = "dgv_consulta";
            this.dgv_consulta.ReadOnly = true;
            this.dgv_consulta.Size = new System.Drawing.Size(1344, 277);
            this.dgv_consulta.TabIndex = 5;
            this.dgv_consulta.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.dgv_consulta_CellStateChanged);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(366, 37);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 20);
            this.btn_buscar.TabIndex = 4;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // tb_nomePesquisa
            // 
            this.tb_nomePesquisa.Location = new System.Drawing.Point(112, 37);
            this.tb_nomePesquisa.Name = "tb_nomePesquisa";
            this.tb_nomePesquisa.Size = new System.Drawing.Size(248, 20);
            this.tb_nomePesquisa.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // tb_idPesquisa
            // 
            this.tb_idPesquisa.Location = new System.Drawing.Point(10, 37);
            this.tb_idPesquisa.Name = "tb_idPesquisa";
            this.tb_idPesquisa.Size = new System.Drawing.Size(96, 20);
            this.tb_idPesquisa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(10, 25);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(96, 20);
            this.tb_id.TabIndex = 6;
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(112, 25);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(107, 20);
            this.tb_nome.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(119, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Endereço";
            // 
            // tb_endereço
            // 
            this.tb_endereço.Location = new System.Drawing.Point(119, 107);
            this.tb_endereço.Name = "tb_endereço";
            this.tb_endereço.Size = new System.Drawing.Size(280, 20);
            this.tb_endereço.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Username";
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(10, 68);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(174, 20);
            this.tb_username.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(296, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Nível";
            // 
            // n_nivel
            // 
            this.n_nivel.Location = new System.Drawing.Point(299, 69);
            this.n_nivel.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.n_nivel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n_nivel.Name = "n_nivel";
            this.n_nivel.Size = new System.Drawing.Size(100, 20);
            this.n_nivel.TabIndex = 14;
            this.n_nivel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Telefone";
            // 
            // tb_telefone
            // 
            this.tb_telefone.Location = new System.Drawing.Point(10, 147);
            this.tb_telefone.Name = "tb_telefone";
            this.tb_telefone.Size = new System.Drawing.Size(103, 20);
            this.tb_telefone.TabIndex = 16;
            // 
            // tb_senha
            // 
            this.tb_senha.Location = new System.Drawing.Point(190, 69);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.Size = new System.Drawing.Size(103, 20);
            this.tb_senha.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(187, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Senha";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(222, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Carga Horaria";
            // 
            // tb_cargaHoraria
            // 
            this.tb_cargaHoraria.Location = new System.Drawing.Point(225, 25);
            this.tb_cargaHoraria.Name = "tb_cargaHoraria";
            this.tb_cargaHoraria.Size = new System.Drawing.Size(174, 20);
            this.tb_cargaHoraria.TabIndex = 19;
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Items.AddRange(new object[] {
            "Ativo",
            "Bloqueado"});
            this.cb_status.Location = new System.Drawing.Point(10, 106);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(103, 21);
            this.cb_status.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Status";
            // 
            // tb_dataInicio
            // 
            this.tb_dataInicio.Location = new System.Drawing.Point(119, 147);
            this.tb_dataInicio.Name = "tb_dataInicio";
            this.tb_dataInicio.Size = new System.Drawing.Size(175, 20);
            this.tb_dataInicio.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(119, 131);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Data de Inicio";
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_adicionar.Location = new System.Drawing.Point(10, 184);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(125, 28);
            this.btn_adicionar.TabIndex = 6;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = false;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_remover.Location = new System.Drawing.Point(142, 184);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(125, 28);
            this.btn_remover.TabIndex = 25;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = false;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_salvar.Location = new System.Drawing.Point(277, 184);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(125, 28);
            this.btn_salvar.TabIndex = 26;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.tb_cargo);
            this.panel1.Controls.Add(this.tb_endereço);
            this.panel1.Controls.Add(this.btn_salvar);
            this.panel1.Controls.Add(this.cb_status);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tb_username);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.tb_id);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btn_remover);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.n_nivel);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tb_telefone);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.btn_adicionar);
            this.panel1.Controls.Add(this.tb_cargaHoraria);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tb_nome);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tb_senha);
            this.panel1.Controls.Add(this.tb_dataInicio);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 230);
            this.panel1.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(299, 131);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Cargo";
            // 
            // tb_cargo
            // 
            this.tb_cargo.Location = new System.Drawing.Point(299, 147);
            this.tb_cargo.Name = "tb_cargo";
            this.tb_cargo.Size = new System.Drawing.Size(100, 20);
            this.tb_cargo.TabIndex = 28;
            // 
            // F_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gb_consulta);
            this.Name = "F_Cadastro";
            this.Text = "F_Tarefas";
            this.Load += new System.EventHandler(this.F_Cadastro_Load);
            this.gb_consulta.ResumeLayout(false);
            this.gb_consulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_nivel)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_consulta;
        private System.Windows.Forms.DataGridView dgv_consulta;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox tb_nomePesquisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_idPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_endereço;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown n_nivel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_telefone;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_cargaHoraria;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_dataInicio;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_buscarTodosUsuarios;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_cargo;
    }
}