using System;
using System.ComponentModel.DataAnnotations;

namespace Supermarket.API.Resources
{
    public class SavePostsResource
    {
        public string Ntitle { get; set; }
        public string Tbody { get; set; }
        public DateTime Created_at { get; set; }
        public int Mbudget { get; set; }
        public int views { get; set; }
        public int pic { get; set; }
    }
}