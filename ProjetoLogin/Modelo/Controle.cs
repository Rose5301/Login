using ProjetoLogin.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLogin.Modelo
{
    public class Controle
    {
        public bool tem;
        public String mensagem = "";
        public bool Acessar(String login, String senha)
        {
            LoginCOMANDO loginDao = new LoginCOMANDO();
            tem = loginDao.VerificarLogin(login, senha);
            if (!loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;
            }
            return tem;
        }

        public String CadastreSe(String email, String telefone, String senha, String confSenha)
        {
            LoginCOMANDO loginDao = new LoginCOMANDO();
            this.mensagem = loginDao.CadastreSe(email, telefone, senha, confSenha);
            if(loginDao.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }
    }
}