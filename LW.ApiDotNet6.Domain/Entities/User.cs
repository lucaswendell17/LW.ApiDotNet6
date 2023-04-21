
using LW.ApiDotNet6.Domain.Validations;
using System.IO.Pipes;

namespace LW.ApiDotNet6.Domain.Entities;

public class User
{
    public int Id { get; private set; }
    public string Email { get; private set; }
    public string Password { get; private set; }

    public User(string email, string password)
    {
        Validation(email, password);
    }

    public User(int id, string email, string password)
    {
        DomainValidationException.When(id <= 0, "Usuario não encontrado!");
        Id = id;
        Validation(email, password);
    }

    private void Validation(string email, string password)
    {
        DomainValidationException.When(string.IsNullOrEmpty(email), "Email deve ser informado!");
        DomainValidationException.When(string.IsNullOrEmpty(password), "Password deve ser informado!");
        Email = email;
        Password = password;
    }
}
