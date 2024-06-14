using System.Collections.Generic;

namespace ToDoList.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<ToDoItem> ToDoItems { get; set; }
    }
}
