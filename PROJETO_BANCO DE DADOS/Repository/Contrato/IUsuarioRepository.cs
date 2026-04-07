using PROJETO_BANCO_DE_DADOS.Models;

namespace PROJETO_BANCO_DE_DADOS.Repository.Contrato
{
    public interface IUsuariorepository
    {
        //CRUD
        IEnumerable<Usuario> ObterTodosUsuario();

        void CadastrarUsuario(Usuario usuario);

        void Atualizar(Usuario usuario);

        Usuario ObterUsuario(int id);

        void Excluir(int id);
    }
}
