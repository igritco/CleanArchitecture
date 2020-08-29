using MediatR;

namespace ToDoApp.Application.User.Queries
{
    public class GetTokenQuery : IRequest<string>
    {
        public GetTokenQuery(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public string Username { get; set; }

        public string Password { get; set; }
    }
}
