using System;
using System.Text.Json.Serialization;
using MediatR;

namespace ToDoApp.Application.ToDo.Commands.CreateToDo
{
    public class CreateToDoCommand : IRequest
    {
        [JsonConstructor]
        public CreateToDoCommand(Guid id, string description)
        {
            Id = id;
            Description = description;
        }

        public CreateToDoCommand(string id, string description, string username)
        {
            Id = new Guid(id);
            Description = description;
            Username = username;
        }

        public Guid Id { get; }

        public string Description { get; }

        public string Username { get; private set; }

        public void SetUsername(string name)
        {
            Username = name;
        }
    }
}
