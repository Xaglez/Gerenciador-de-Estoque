namespace Gerenciador_de_estoque
{
    partial class F_login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_login));
            this.btn_entrar = new System.Windows.Forms.Button();
            this.mtb_login = new System.Windows.Forms.MaskedTextBox();
            this.mtb_senha = new System.Windows.Forms.MaskedTextBox();
            this.tb_login = new System.Windows.Forms.Label();
            this.lb_senha = new System.Windows.Forms.Label();
            this.btn_ocultarSenha = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.csm_iconeAreaTrabalho = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_fechar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_abrir = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.csm_iconeAreaTrabalho.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_entrar
            // 
            this.btn_entrar.Location = new System.Drawing.Point(63, 442);
            this.btn_entrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(273, 45);
            this.btn_entrar.TabIndex = 2;
            this.btn_entrar.Text = "Entrar";
            this.btn_entrar.UseVisualStyleBackColor = true;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // mtb_login
            // 
            this.mtb_login.Location = new System.Drawing.Point(63, 302);
            this.mtb_login.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mtb_login.Name = "mtb_login";
            this.mtb_login.Size = new System.Drawing.Size(271, 26);
            this.mtb_login.TabIndex = 4;
            this.mtb_login.Text = "paulinho";
            this.mtb_login.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtb_login_KeyDown);
            // 
            // mtb_senha
            // 
            this.mtb_senha.Location = new System.Drawing.Point(63, 362);
            this.mtb_senha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mtb_senha.Name = "mtb_senha";
            this.mtb_senha.PasswordChar = '*';
            this.mtb_senha.Size = new System.Drawing.Size(271, 26);
            this.mtb_senha.TabIndex = 5;
            this.mtb_senha.Text = "1234";
            this.mtb_senha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtb_senha_KeyDown);
            // 
            // tb_login
            // 
            this.tb_login.AutoSize = true;
            this.tb_login.Location = new System.Drawing.Point(58, 277);
            this.tb_login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(64, 20);
            this.tb_login.TabIndex = 6;
            this.tb_login.Text = "Usuário";
            // 
            // lb_senha
            // 
            this.lb_senha.AutoSize = true;
            this.lb_senha.Location = new System.Drawing.Point(58, 337);
            this.lb_senha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_senha.Name = "lb_senha";
            this.lb_senha.Size = new System.Drawing.Size(56, 20);
            this.lb_senha.TabIndex = 7;
            this.lb_senha.Text = "Senha";
            // 
            // btn_ocultarSenha
            // 
            this.btn_ocultarSenha.Location = new System.Drawing.Point(63, 402);
            this.btn_ocultarSenha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_ocultarSenha.Name = "btn_ocultarSenha";
            this.btn_ocultarSenha.Size = new System.Drawing.Size(75, 31);
            this.btn_ocultarSenha.TabIndex = 9;
            this.btn_ocultarSenha.Text = "Revelar";
            this.btn_ocultarSenha.UseVisualStyleBackColor = true;
            this.btn_ocultarSenha.Click += new System.EventHandler(this.btn_ocultarSenha_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.csm_iconeAreaTrabalho;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // csm_iconeAreaTrabalho
            // 
            this.csm_iconeAreaTrabalho.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.csm_iconeAreaTrabalho.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_fechar,
            this.tsmi_abrir});
            this.csm_iconeAreaTrabalho.Name = "contextMenuStrip1";
            this.csm_iconeAreaTrabalho.Size = new System.Drawing.Size(136, 68);
            this.csm_iconeAreaTrabalho.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // tsmi_fechar
            // 
            this.tsmi_fechar.Name = "tsmi_fechar";
            this.tsmi_fechar.Size = new System.Drawing.Size(135, 32);
            this.tsmi_fechar.Text = "Fechar";
            // 
            // tsmi_abrir
            // 
            this.tsmi_abrir.Name = "tsmi_abrir";
            this.tsmi_abrir.Size = new System.Drawing.Size(135, 32);
            this.tsmi_abrir.Text = "Abrir";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pb_logo);
            this.panel1.Controls.Add(this.tb_login);
            this.panel1.Controls.Add(this.btn_entrar);
            this.panel1.Controls.Add(this.btn_ocultarSenha);
            this.panel1.Controls.Add(this.mtb_login);
            this.panel1.Controls.Add(this.mtb_senha);
            this.panel1.Controls.Add(this.lb_senha);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 622);
            this.panel1.TabIndex = 12;
            // 
            // pb_logo
            // 
            this.pb_logo.Image = ((System.Drawing.Image)(resources.GetObject("pb_logo.Image")));
            this.pb_logo.Location = new System.Drawing.Point(94, 72);
            this.pb_logo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(210, 182);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_logo.TabIndex = 11;
            this.pb_logo.TabStop = false;
            // 
            // F_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(398, 622);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "F_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.F_login_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.F_login_KeyDown);
            this.csm_iconeAreaTrabalho.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.MaskedTextBox mtb_login;
        private System.Windows.Forms.MaskedTextBox mtb_senha;
        private System.Windows.Forms.Label tb_login;
        private System.Windows.Forms.Label lb_senha;
        private System.Windows.Forms.Button btn_ocultarSenha;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip csm_iconeAreaTrabalho;
        private System.Windows.Forms.ToolStripMenuItem tsmi_fechar;
        private System.Windows.Forms.ToolStripMenuItem tsmi_abrir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_logo;
    }
}

