using MediatR;

using ToDoApp.Entity.Generics;

namespace ToDoApp.Application.User.Commands
{
    public class RegisterUserCommand : IRequest<Result>
    {
        public RegisterUserCommand(string email, string password)
        {
            Email = email;
            Password = password;
        }

        public string Email { get; }

        public string Password { get; }
    }
}
