namespace Gerenciador_de_estoque
{
    partial class F_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Principal));
            this.btn_close = new System.Windows.Forms.Button();
            this.lb_hora = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lb_data = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lb_usuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_setUsuario = new System.Windows.Forms.Label();
            this.lb_setCargo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.p_direito = new System.Windows.Forms.Panel();
            this.p_topo = new System.Windows.Forms.Panel();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_cadastroCliente = new System.Windows.Forms.Button();
            this.btn_historicoVendas = new System.Windows.Forms.Button();
            this.btn_vender = new System.Windows.Forms.Button();
            this.btn_cadastroUsuarios = new System.Windows.Forms.Button();
            this.btn_estoque = new System.Windows.Forms.Button();
            this.p_central = new System.Windows.Forms.Panel();
            this.p_principal = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.p_direito.SuspendLayout();
            this.p_topo.SuspendLayout();
            this.p_principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(296, 5);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(68, 69);
            this.btn_close.TabIndex = 0;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_hora
            // 
            this.lb_hora.AutoSize = true;
            this.lb_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hora.Location = new System.Drawing.Point(135, 58);
            this.lb_hora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_hora.Name = "lb_hora";
            this.lb_hora.Size = new System.Drawing.Size(119, 30);
            this.lb_hora.TabIndex = 4;
            this.lb_hora.Text = "00:00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-4, 226);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(414, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "---------------------------------------------------------------------------------" +
    "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(58, 40);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 69);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(66, 137);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 62);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // lb_data
            // 
            this.lb_data.AutoSize = true;
            this.lb_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_data.Location = new System.Drawing.Point(135, 151);
            this.lb_data.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_data.Name = "lb_data";
            this.lb_data.Size = new System.Drawing.Size(129, 29);
            this.lb_data.TabIndex = 8;
            this.lb_data.Text = "dd/mm/aa";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(66, 255);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(63, 65);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // lb_usuario
            // 
            this.lb_usuario.AutoSize = true;
            this.lb_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_usuario.Location = new System.Drawing.Point(60, 329);
            this.lb_usuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_usuario.Name = "lb_usuario";
            this.lb_usuario.Size = new System.Drawing.Size(117, 30);
            this.lb_usuario.TabIndex = 10;
            this.lb_usuario.Text = "Usuário:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 386);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 30);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cargo:";
            // 
            // lb_setUsuario
            // 
            this.lb_setUsuario.AutoSize = true;
            this.lb_setUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_setUsuario.Location = new System.Drawing.Point(180, 329);
            this.lb_setUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_setUsuario.Name = "lb_setUsuario";
            this.lb_setUsuario.Size = new System.Drawing.Size(102, 30);
            this.lb_setUsuario.TabIndex = 12;
            this.lb_setUsuario.Text = "Usuário";
            // 
            // lb_setCargo
            // 
            this.lb_setCargo.AutoSize = true;
            this.lb_setCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_setCargo.Location = new System.Drawing.Point(158, 386);
            this.lb_setCargo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_setCargo.Name = "lb_setCargo";
            this.lb_setCargo.Size = new System.Drawing.Size(69, 30);
            this.lb_setCargo.TabIndex = 13;
            this.lb_setCargo.Text = "CEO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-4, 449);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(409, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "--------------------------------------------------------------------------------";
            // 
            // p_direito
            // 
            this.p_direito.BackColor = System.Drawing.Color.SteelBlue;
            this.p_direito.Controls.Add(this.label3);
            this.p_direito.Controls.Add(this.lb_setCargo);
            this.p_direito.Controls.Add(this.lb_setUsuario);
            this.p_direito.Controls.Add(this.label1);
            this.p_direito.Controls.Add(this.lb_usuario);
            this.p_direito.Controls.Add(this.pictureBox3);
            this.p_direito.Controls.Add(this.lb_data);
            this.p_direito.Controls.Add(this.pictureBox2);
            this.p_direito.Controls.Add(this.pictureBox1);
            this.p_direito.Controls.Add(this.label2);
            this.p_direito.Controls.Add(this.lb_hora);
            this.p_direito.Controls.Add(this.btn_close);
            this.p_direito.Dock = System.Windows.Forms.DockStyle.Right;
            this.p_direito.Location = new System.Drawing.Point(1583, 0);
            this.p_direito.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.p_direito.Name = "p_direito";
            this.p_direito.Size = new System.Drawing.Size(363, 1106);
            this.p_direito.TabIndex = 3;
            // 
            // p_topo
            // 
            this.p_topo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.p_topo.Controls.Add(this.btn_home);
            this.p_topo.Controls.Add(this.btn_cadastroCliente);
            this.p_topo.Controls.Add(this.btn_historicoVendas);
            this.p_topo.Controls.Add(this.btn_vender);
            this.p_topo.Controls.Add(this.btn_cadastroUsuarios);
            this.p_topo.Controls.Add(this.btn_estoque);
            this.p_topo.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_topo.Location = new System.Drawing.Point(0, 0);
            this.p_topo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.p_topo.Name = "p_topo";
            this.p_topo.Size = new System.Drawing.Size(1583, 237);
            this.p_topo.TabIndex = 20;
            // 
            // btn_home
            // 
            this.btn_home.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_home.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_home.BackgroundImage")));
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btn_home.Location = new System.Drawing.Point(51, 54);
            this.btn_home.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(120, 123);
            this.btn_home.TabIndex = 20;
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click_1);
            // 
            // btn_cadastroCliente
            // 
            this.btn_cadastroCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cadastroCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cadastroCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cadastroCliente.BackgroundImage")));
            this.btn_cadastroCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cadastroCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cadastroCliente.FlatAppearance.BorderSize = 0;
            this.btn_cadastroCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastroCliente.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btn_cadastroCliente.Location = new System.Drawing.Point(368, 69);
            this.btn_cadastroCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_cadastroCliente.Name = "btn_cadastroCliente";
            this.btn_cadastroCliente.Size = new System.Drawing.Size(105, 108);
            this.btn_cadastroCliente.TabIndex = 16;
            this.btn_cadastroCliente.UseVisualStyleBackColor = false;
            this.btn_cadastroCliente.Click += new System.EventHandler(this.btn_cadastro_Click);
            // 
            // btn_historicoVendas
            // 
            this.btn_historicoVendas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_historicoVendas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_historicoVendas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_historicoVendas.BackgroundImage")));
            this.btn_historicoVendas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_historicoVendas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_historicoVendas.FlatAppearance.BorderSize = 0;
            this.btn_historicoVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_historicoVendas.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btn_historicoVendas.Location = new System.Drawing.Point(787, 69);
            this.btn_historicoVendas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_historicoVendas.Name = "btn_historicoVendas";
            this.btn_historicoVendas.Size = new System.Drawing.Size(105, 108);
            this.btn_historicoVendas.TabIndex = 19;
            this.btn_historicoVendas.UseVisualStyleBackColor = false;
            // 
            // btn_vender
            // 
            this.btn_vender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_vender.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_vender.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_vender.BackgroundImage")));
            this.btn_vender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_vender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_vender.FlatAppearance.BorderSize = 0;
            this.btn_vender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vender.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btn_vender.Location = new System.Drawing.Point(505, 69);
            this.btn_vender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_vender.Name = "btn_vender";
            this.btn_vender.Size = new System.Drawing.Size(105, 108);
            this.btn_vender.TabIndex = 17;
            this.btn_vender.UseVisualStyleBackColor = false;
            this.btn_vender.Click += new System.EventHandler(this.btn_vender_Click);
            // 
            // btn_cadastroUsuarios
            // 
            this.btn_cadastroUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cadastroUsuarios.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cadastroUsuarios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cadastroUsuarios.BackgroundImage")));
            this.btn_cadastroUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cadastroUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cadastroUsuarios.FlatAppearance.BorderSize = 0;
            this.btn_cadastroUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastroUsuarios.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btn_cadastroUsuarios.Location = new System.Drawing.Point(645, 69);
            this.btn_cadastroUsuarios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_cadastroUsuarios.Name = "btn_cadastroUsuarios";
            this.btn_cadastroUsuarios.Size = new System.Drawing.Size(105, 108);
            this.btn_cadastroUsuarios.TabIndex = 18;
            this.btn_cadastroUsuarios.UseVisualStyleBackColor = false;
            this.btn_cadastroUsuarios.Click += new System.EventHandler(this.btn_tarefas_Click);
            // 
            // btn_estoque
            // 
            this.btn_estoque.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_estoque.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_estoque.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_estoque.BackgroundImage")));
            this.btn_estoque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_estoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_estoque.FlatAppearance.BorderSize = 0;
            this.btn_estoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_estoque.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btn_estoque.Location = new System.Drawing.Point(209, 62);
            this.btn_estoque.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_estoque.Name = "btn_estoque";
            this.btn_estoque.Size = new System.Drawing.Size(120, 123);
            this.btn_estoque.TabIndex = 15;
            this.btn_estoque.UseVisualStyleBackColor = false;
            this.btn_estoque.Click += new System.EventHandler(this.btn_estoque_Click);
            // 
            // p_central
            // 
            this.p_central.BackColor = System.Drawing.SystemColors.GrayText;
            this.p_central.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p_central.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_central.Location = new System.Drawing.Point(0, 237);
            this.p_central.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.p_central.Name = "p_central";
            this.p_central.Size = new System.Drawing.Size(1583, 869);
            this.p_central.TabIndex = 21;
            // 
            // p_principal
            // 
            this.p_principal.AutoSize = true;
            this.p_principal.BackColor = System.Drawing.SystemColors.Window;
            this.p_principal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p_principal.Controls.Add(this.p_central);
            this.p_principal.Controls.Add(this.p_topo);
            this.p_principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_principal.Location = new System.Drawing.Point(0, 0);
            this.p_principal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.p_principal.Name = "p_principal";
            this.p_principal.Size = new System.Drawing.Size(1583, 1106);
            this.p_principal.TabIndex = 4;
            // 
            // F_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1946, 1106);
            this.Controls.Add(this.p_principal);
            this.Controls.Add(this.p_direito);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "F_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Principal";
            this.Load += new System.EventHandler(this.F_Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.p_direito.ResumeLayout(false);
            this.p_direito.PerformLayout();
            this.p_topo.ResumeLayout(false);
            this.p_principal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lb_hora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lb_data;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lb_usuario;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lb_setUsuario;
        public System.Windows.Forms.Label lb_setCargo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel p_direito;
        private System.Windows.Forms.Panel p_topo;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_cadastroCliente;
        private System.Windows.Forms.Button btn_historicoVendas;
        private System.Windows.Forms.Button btn_vender;
        private System.Windows.Forms.Button btn_cadastroUsuarios;
        private System.Windows.Forms.Button btn_estoque;
        private System.Windows.Forms.Panel p_central;
        private System.Windows.Forms.Panel p_principal;
    }
}