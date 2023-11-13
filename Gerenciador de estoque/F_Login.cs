using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;



namespace Gerenciador_de_estoque
{
    public partial class F_login : Form
    {
        DataTable dt;
        
        public F_login()
        {           
            InitializeComponent();           
        }
        
        private void btn_ocultarLogin_Click(object sender, EventArgs e)
        {
            if (mtb_senha.PasswordChar.Equals('*'))
            {
                mtb_senha.PasswordChar = '\0';
                btn_ocultarSenha.Text = "Ocultar";
            }
            
        }

        private void btn_ocultarSenha_Click(object sender, EventArgs e)
        {
            if (mtb_senha.PasswordChar.Equals('*'))
            {
                mtb_senha.PasswordChar = '\0';
                btn_ocultarSenha.Text = "Ocultar";
            }
            else
            {
                mtb_senha.PasswordChar = '*';
                btn_ocultarSenha.Text = "Revelar";
            }
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            Autenticar();
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name == "tsmi_fechar")
            {
                Close();
            }
            if (e.ClickedItem.Name == "tsmi_abrir")
            {
                try
                {
                    ShowDialog();
                }
                catch { MessageBox.Show("Aplicativo já aberto"); }
            }
        }

        private void F_login_Load(object sender, EventArgs e)
        {
            panel1.Location = new Point(Width / 2 - 140, Height / 2 - 221);
        }

        private void F_login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Autenticar();
            }
        }

        private void Autenticar()
        {
            //string usuario = mtb_login.Text;
            //string senha = mtb_senha.Text;

            //if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(senha))
            //{
            //    MessageBox.Show("Preencha todos os campos");
            //    mtb_login.Focus();
            //    return;
            //}

            //string sql = "SELECT * FROM tb_usuarios WHERE USERNAME='" + usuario + "'AND SENHA='" + senha + "'";
            //dt = Banco.Consulta(sql);

            //if (dt.Rows.Count == 1)
            //{
            //    Globais.nome_usuario = dt.Rows[0].ItemArray[1].ToString();
            //    Globais.cargo = dt.Rows[0].ItemArray[5].ToString();
            //    Globais.nivel = int.Parse(dt.Rows[0].ItemArray[6].ToString());
            //    Globais.status = dt.Rows[0].ItemArray[4].ToString();

            //    if (Globais.status == "Ativo")
            //    {
            //        Globais.logado = true;
            //        mtb_login.Text = null;
            //        mtb_senha.Text = null;
            //        F_Principal f_Principal = new F_Principal();
            //        f_Principal.Show();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Usário Bloqueado");
            //    }

            //}else
            //{
            //    MessageBox.Show("Dados Incorretos");
            //}

            Globais.logado = true;
            mtb_login.Text = null;
            mtb_senha.Text = null;
            F_Principal f_Principal = new F_Principal();
            f_Principal.Show();
        }

        private void mtb_senha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Autenticar();
            }
        }

        private void mtb_login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Autenticar();
            }
        }
       
    }
}
