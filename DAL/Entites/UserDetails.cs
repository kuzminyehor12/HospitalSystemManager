using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Entites
{
    public class UserDetails
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required, Range(18, 100)]
        public int Age { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
        public override string ToString()
        {
            return String.Format($"User Id: {Id}\n" +
                                $"Name: {Name}\n" +
                                $"Surname: {Surname}\n" +
                                $"Age: {Age}\n" +
                                $"Email: {Email}\n" +
                                $"Password: {Password}\n");
        }
    }
}
