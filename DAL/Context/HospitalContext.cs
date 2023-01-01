using System;
using System.Collections.Generic;
using System.Text;
using DAL.Entites;

namespace DAL.Context
{
    public class HospitalContext
    {
        public List<User> Users { get; set; }
        public List<UserDetails> Details { get; set; }
    }
}
