using System.Security.Claims;

namespace NSE.WebApp.MVC.Extensions
{
    public interface IUser
    {
        string Name { get; }
        string ObterUserId();
        string ObterUserEmail();
        string ObterUserToken();
        bool EstaAutenticado();
        bool PossuiRole(string role);
        IEnumerable<Claim> ObterClaims();
        HttpContext ObterHttpContext();

    }

    public class AspNetUser : IUser
    {
        private readonly IHttpContextAccessor _accessor;

        public AspNetUser(IHttpContextAccessor accessor)
        {
            _accessor = accessor;
        }

        public string Name => ObterHttpContext().User.Identity.Name;

        public string ObterUserId()
        {
            return EstaAutenticado() ? _accessor.HttpContext.User.GetUserId() : "";
        }

        public string ObterUserEmail()
        {
            return EstaAutenticado() ? ObterHttpContext().User.GetUserEmail() : "";
        }

        public string ObterUserToken()
        {
            return EstaAutenticado() ? ObterHttpContext().User.GetUserToken() : "";
        }

        public bool EstaAutenticado()
        {
            return ObterHttpContext().User.Identity.IsAuthenticated;
        }

        public bool PossuiRole(string role)
        {
            return ObterHttpContext().User.IsInRole(role);
        }

        public IEnumerable<Claim> ObterClaims()
        {
            return ObterHttpContext().User.Claims;
        }

        public HttpContext ObterHttpContext()
        {
            return _accessor.HttpContext;
        }
    }

    public static class ClaimsPrincipalExtensions
    {
        public static string GetUserId(this ClaimsPrincipal principal)
        {
            if (principal == null) throw new ArgumentException(nameof(principal));

            var claim = principal.FindFirst(ClaimTypes.NameIdentifier);

            return claim?.Value;
        }

        public static string GetUserEmail(this ClaimsPrincipal principal)
        {
            if (principal == null) throw new ArgumentException(nameof(principal));

            var claim = principal.FindFirst("email");

            return claim?.Value;
        }

        public static string GetUserToken(this ClaimsPrincipal principal)
        {
            if (principal == null) throw new ArgumentException(nameof(principal));

            var claim = principal.FindFirst("JWT");

            return claim?.Value;
        }
    }
}
