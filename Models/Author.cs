using System;

namespace CRUD_WEB_API_SP_MVC.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string BookId { get; set; }
    }
}