using Microsoft.AspNetCore.Identity;

namespace NSE.Identidade.API.Extensions
{
    public class IdentityMensagensPortugues : IdentityErrorDescriber
    {
        public override IdentityError DefaultError() => new IdentityError
        {
            Code = nameof(DefaultError),
            Description = "Ocorreu um erro desconhecido."
        };

        public override IdentityError ConcurrencyFailure() => new IdentityError
        {
            Code = nameof(ConcurrencyFailure),
            Description = "Falha de concorrência otimista, o objeto foi modificado."
        };

        public override IdentityError PasswordMismatch() => new IdentityError
        {
            Code = nameof(PasswordMismatch),
            Description = "Senha incorreta."
        };

        public override IdentityError InvalidToken() => new IdentityError
        {
            Code = nameof(InvalidToken),
            Description = "Token inválido."
        };

        public override IdentityError LoginAlreadyAssociated() => new IdentityError
        {
            Code = nameof(LoginAlreadyAssociated),
            Description = "Um usuário com este login já existe."
        };

        public override IdentityError InvalidUserName(string userName) => new IdentityError
        {
            Code = nameof(InvalidUserName),
            Description = $"Nome de usuário '{userName}' inválido, somente letras ou números são permitidos."
        };

        public override IdentityError InvalidEmail(string email) => new IdentityError
        {
            Code = nameof(InvalidEmail),
            Description = $"Email '{email}' inválido."
        };

        public override IdentityError DuplicateUserName(string userName) => new IdentityError
        {
            Code = nameof(DuplicateUserName),
            Description = $"Nome de usuário '{userName}' já está em uso."
        };

        public override IdentityError DuplicateEmail(string email) => new IdentityError
        {
            Code = nameof(DuplicateEmail),
            Description = $"Email '{email}' já está em uso."
        };

        public override IdentityError InvalidRoleName(string role) => new IdentityError
        {
            Code = nameof(InvalidRoleName),
            Description = $"Nome de função '{role}' inválido."
        };

        public override IdentityError DuplicateRoleName(string role) => new IdentityError
        {
            Code = nameof(DuplicateRoleName),
            Description = $"Função '{role}' já está em uso."
        };

        public override IdentityError UserAlreadyHasPassword() => new IdentityError
        {
            Code = nameof(UserAlreadyHasPassword),
            Description = "O usuário já possui uma senha."
        };

        public override IdentityError PasswordRequiresNonAlphanumeric() => new IdentityError
        {
            Code = nameof(PasswordRequiresNonAlphanumeric),
            Description = "Senhas devem conter pelo menos um caractere não alfanumérico."
        };

        public override IdentityError PasswordRequiresDigit() => new IdentityError
        {
            Code = nameof(PasswordRequiresDigit),
            Description = "Senhas devem conter pelo menos um dígito ('0'-'9')."
        };

        public override IdentityError PasswordRequiresLower() => new IdentityError
        {
            Code = nameof(PasswordRequiresLower),
            Description = "Senhas devem conter pelo menos um caractere em caixa baixa ('a'-'z')."
        };

        public override IdentityError PasswordRequiresUpper() => new IdentityError
        {
            Code = nameof(PasswordRequiresUpper),
            Description = "Senhas devem conter pelo menos um caractere em caixa alta ('A'-'Z')."
        };

        public override IdentityError PasswordTooShort(int length) => new IdentityError
        {
            Code = nameof(PasswordTooShort),
            Description = $"Senhas devem ter pelo menos {length} caracteres."
        };

    }
}
