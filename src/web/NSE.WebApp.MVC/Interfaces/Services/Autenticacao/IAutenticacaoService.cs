using NSE.WebApp.MVC.Models;

namespace NSE.WebApp.MVC.Interfaces.Services.Autenticacao
{
    public interface IAutenticacaoService
    {
        Task<UsuarioRespostaLogin> Login(UsuarioLogin usuarioLogin);
        Task<UsuarioRespostaLogin> Registro(UsuarioRegistro usuarioLogin);

    }

}
