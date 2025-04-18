﻿namespace HaMyDuyen_2122110528.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Role { get; set; } // Admin, Customer, etc.
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
