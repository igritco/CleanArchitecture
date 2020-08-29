using System;
using System.Text.Json.Serialization;
using MediatR;

using ToDoApp.Entity.Enums;

namespace ToDoApp.Application.ToDo.Commands.UpdateToDo
{
    public class UpdateToDoCommand : IRequest
    {
        [JsonConstructor]
        public UpdateToDoCommand(Guid id, string description, Status status)
        {
            Id = id;
            Description = description;
            Status = status;
        }

        public UpdateToDoCommand(string id, string description, int status, string username)
        {
            Id = new Guid(id);
            Description = description;
            Status = (Status)status;
            Username = username;
        }

        public Guid Id { get; }

        public string Description { get; }

        public Status Status { get; }

        public string Username { get; private set; }

        public void SetUsername(string name)
        {
            Username = name;
        }
    }
}
