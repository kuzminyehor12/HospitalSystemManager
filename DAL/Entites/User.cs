using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Entites
{
    public class User
    {
        public Guid UserId { get; set; }
        [Required]
        public UserRole Role { get; set; }
        public UserDetails Info { get; set; }
        public override string ToString()
        {
            return String.Format($"Info:\n{Info}\n" +
                                $"Role: {Role}\n");
        }
    }
}
