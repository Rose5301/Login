using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace ProjetoLogin.DAO
{
    public class LoginCOMANDO
    {
        public bool tem = false;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;

        public bool VerificarLogin(String login, String senha)
        {
            cmd.CommandText = "select * from logar were email = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
                con.Desconectar();
                dr.Close();
            }
            catch (SqlException)
            {
                this.mensagem = "Error!!!";
            }
            return true;
        }

        public String CadastreSe(String email, String telefone, String senha, String confSenha)
        {
            if (senha.Equals(confSenha))
            {
                cmd.CommandText = "insert into logar values (@e,@s,@t";
                cmd.Parameters.AddWithValue("@e", email);
                cmd.Parameters.AddWithValue("@s", senha);
                cmd.Parameters.AddWithValue("@t", telefone);

                try
                {
                    cmd.Connection = con.Conectar();
                    cmd.ExecuteNonQuery();
                    con.Desconectar();
                    this.mensagem = "Cadastrado!";

                }
                catch (SqlException)
                {
                    this.mensagem = "Error!!!";
                }
                finally
                {
                    this.mensagem = "Executando.";
                }

            }
            else
            {
                this.mensagem = "Senhas não combinam";
            }
            return mensagem;        
        }
    } 
}


                
