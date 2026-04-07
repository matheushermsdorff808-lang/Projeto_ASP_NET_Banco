using MySql.Data.MySqlClient;
using PROJETO_BANCO_DE_DADOS.Models;
using PROJETO_BANCO_DE_DADOS.Repository.Contrato;

namespace PROJETO_BANCO_DE_DADOS.Repository
{
    public class UsuarioRepository : IUsuariorepository
    {
        private readonly string _conexaoMySQL;

        public UsuarioRepository(IConfiguration conf)
        {
            _conexaoMySQL = conf.GetConnectionString("ConexaoMySQL");
        }
        public void Atualizar(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public void CadastrarUsuario(Usuario usuario)
        {
            using (var conexao = new MySqlConnection(_conexaoMySQL))
            {
                conexao.Open();

                MySqlCommand cmd = new MySqlCommand("insert into usuario(nomeUsu, Cargo, DataNasc) " +
                                                " values (@nomeUsu, @Cargo, @DataNasc )", conexao); // @: PARAMETRO

                cmd.Parameters.Add("@nomeUsu", MySqlDbType.VarChar).Value = usuario.nomeUsu;
                cmd.Parameters.Add("@Cargo", MySqlDbType.VarChar).Value = usuario.Cargo;
                // cmd.Parameters.Add("@DataNasc", MySqlDbType.VarChar).Value = usuario.DataNasc.ToString("yyyy/MM/dd");
                cmd.Parameters.Add("@DataNasc", MySqlDbType.VarChar).Value = usuario.Datanasc.ToString("yyyy/MM/dd");

                cmd.ExecuteNonQuery();
                conexao.Close();
            }
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Usuario> ObterTodosUsuario()
        {
            throw new NotImplementedException();
        }

        public Usuario ObterUsuario(int id)
        {
            throw new NotImplementedException();
        }
    }
}
