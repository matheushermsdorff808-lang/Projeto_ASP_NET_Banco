using Microsoft.AspNetCore.Mvc;
using PROJETO_BANCO_DE_DADOS.Models;
using PROJETO_BANCO_DE_DADOS.Repository.Contrato;

namespace PROJETO_BANCO_DE_DADOS.Controllers
{
    public class UsuarioController : Controller
    {
        private IUsuariorepository _usuarioRepository;

        public UsuarioController(IUsuariorepository usuariorepository)
        {
            _usuarioRepository = usuariorepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CadastrarUsuario()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CadastrarUsuario(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _usuarioRepository.CadastrarUsuario(usuario);

            }
            return RedirectToAction(nameof(Index));
        }
    }
}
