using System;

namespace Supermarket.API.Domain.Models
{
    public class Posts
    {
        public int Cposts { get; set; }
        public string Ntitle { get; set; }
        public string Tbody { get; set; }
        public DateTime Created_at { get; set; }
        public int Mbudget { get; set; }
        public int Views { get; set; }
        public int Pic { get; set; }
        
        public int UserId { get; set; }
        public User User { get; set; }
    }
}