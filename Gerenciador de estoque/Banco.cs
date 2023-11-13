//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data;
//using System.Data.SQLite;
//using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

//namespace Gerenciador_de_estoque
//{
//    internal class Banco
//    {
//        private static SQLiteConnection conexao;

//        private static SQLiteConnection ConexaoBanco()
//        {
//            conexao = new SQLiteConnection("seu banco");
//            conexao.Open();
//            return conexao;
//        }

//        public static DataTable ObterTodosUsuarios()
//        {
//            DataTable dataTable = new DataTable();
//            SQLiteDataAdapter da = null;

//            try
//            {
//                using (var cmd = ConexaoBanco().CreateCommand())
//                {
//                    cmd.CommandText = "SELECT * FROM tb_usuarios";
//                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
//                    da.Fill(dataTable);
//                    conexao.Close();
//                    return dataTable;
//                }
//            }
//            catch (Exception ex)
//            {
//                conexao.Close();
//                throw (ex);
//            }
//        }

//        public static DataTable ObterTodosProdutos()
//        {
//            DataTable dt = new DataTable();
//            SQLiteDataAdapter da = null;

//            try
//            {
//                using (var cmd = ConexaoBanco().CreateCommand())
//                {
//                    cmd.CommandText = "SELECT * FROM tb_produtos";
//                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
//                    da.Fill(dt);
//                    conexao.Close();
//                    return dt;
//                }
//            }
//            catch (Exception ex)
//            {
//                conexao.Close();
//                throw (ex);
//            }
//        }

//        public static DataTable Consulta(string sql)
//        {

//            DataTable dataTable = new DataTable();
//            SQLiteDataAdapter da;

//            try
//            {
//                using (var cmd = ConexaoBanco().CreateCommand())
//                {
//                    cmd.CommandText = sql;
//                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
//                    da.Fill(dataTable);
//                    conexao.Close();
//                    return dataTable;
//                }
//            }
//            catch (Exception ex)
//            {

//                throw (ex);
//            }
//        }

//        public static void NovoUsuario(Usuario u)
//        {
//            if (ExisteUsername(u))
//            {
//                MessageBox.Show("Já existe esse usuário");
//                return;
//            }

//            try
//            {
//                using (var connection = ConexaoBanco())
//                {
//                    var cmd = connection.CreateCommand();
//                    cmd.CommandText = "INSERT INTO tb_usuarios (NOME_USUARIO, USERNAME, SENHA, STATUS, CARGO_USUARIO, NIVEL, Telefone, Endereço, Carga_Horaria, Data_de_Inicio) VALUES (@nome, @username, @senha, @status, @cargo, @nivel, @telefone, @endereco, @cargaHoraria, @dataInicio)";
//                    cmd.Parameters.AddWithValue("@nome", u.nome);
//                    cmd.Parameters.AddWithValue("@username", u.username);
//                    cmd.Parameters.AddWithValue("@senha", u.senha);
//                    cmd.Parameters.AddWithValue("@status", u.status);
//                    cmd.Parameters.AddWithValue("@cargo", u.cargo);
//                    cmd.Parameters.AddWithValue("@nivel", u.nivel);
//                    cmd.Parameters.AddWithValue("@telefone", u.telefone);
//                    cmd.Parameters.AddWithValue("@endereco", u.endereco);
//                    cmd.Parameters.AddWithValue("@cargaHoraria", u.cargaHoraria);
//                    cmd.Parameters.AddWithValue("@dataInicio", u.dataInicio);
//                    cmd.ExecuteNonQuery();
//                }

//                MessageBox.Show("Usuário Inserido");
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Erro ao gravar novo usuário: " + ex.Message);
//                conexao.Close();
//            }
//        }

//        public static void NovoProduto()
//        {

//        }

//        public static bool ExisteUsername(Usuario u)
//        {
//            using (var connection = ConexaoBanco())
//            {
//                var cmd = connection.CreateCommand();
//                cmd.CommandText = "SELECT COUNT(*) FROM tb_usuarios WHERE USERNAME = @username";
//                cmd.Parameters.AddWithValue("@username", u.username);
//                int count = Convert.ToInt32(cmd.ExecuteScalar());

//                return count > 0;
//            }
//        }

//        public static void Salvar(Usuario u)
//        {
//            try
//            {
//                using (var connection = ConexaoBanco())
//                {
//                    var cmd = connection.CreateCommand();
//                    cmd.CommandText = "UPDATE tb_usuarios SET NOME_USUARIO = @nome, USERNAME = @username, SENHA = @senha, STATUS = @status, CARGO_USUARIO = @cargo, NIVEL = @nivel, Telefone = @telefone, Endereço = @endereco, Carga_Horaria = @cargaHoraria, Data_de_Inicio = @dataInicio WHERE ID_Usuario = @id ";
//                    cmd.Parameters.AddWithValue("@nome", u.nome);
//                    cmd.Parameters.AddWithValue("@username", u.username);
//                    cmd.Parameters.AddWithValue("@senha", u.senha);
//                    cmd.Parameters.AddWithValue("@status", u.status);
//                    cmd.Parameters.AddWithValue("@cargo", u.cargo);
//                    cmd.Parameters.AddWithValue("@nivel", u.nivel);
//                    cmd.Parameters.AddWithValue("@telefone", u.telefone);
//                    cmd.Parameters.AddWithValue("@endereco", u.endereco);
//                    cmd.Parameters.AddWithValue("@cargaHoraria", u.cargaHoraria);
//                    cmd.Parameters.AddWithValue("@dataInicio", u.dataInicio);
//                    cmd.Parameters.AddWithValue("@id", u.id);
//                    cmd.ExecuteNonQuery();
//                }

//                MessageBox.Show("Usuário Atualizado");
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Erro ao atualizar o usuário: " + ex.Message);
//                conexao.Close();
//            }
//        }

//        public static void Remover(Usuario u)
//        {
//            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja remover o usuário ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
//            {
//                try
//                {
//                    using (var connection = ConexaoBanco())
//                    {
//                        var cmd = connection.CreateCommand();
//                        cmd.CommandText = "DELETE FROM tb_usuarios WHERE  ID_Usuario = @id";
//                        cmd.Parameters.AddWithValue("@id", u.id);
//                        cmd.ExecuteNonQuery();
//                    }

//                    MessageBox.Show("Usuário Removido");
//                }
//                catch (Exception ex)
//                {
//                    MessageBox.Show("Erro ao remover usuário: " + ex.Message);
//                    conexao.Close();
//                }
//            }
//        }
//    }
//}
