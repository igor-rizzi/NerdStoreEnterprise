using NSE.WebApp.MVC.Models;

namespace NSE.WebApp.MVC.Interfaces.Services.Autenticacao
{
    public interface IAutenticacaoService
    {
        Task<string> Login(UsuarioLogin usuarioLogin);
        Task<string> Registro(UsuarioRegistro usuarioLogin);

    }

}
