using System;
using Microsoft.VisualBasic;

namespace Supermarket.API.Resources
{
    public class PostsResource
    {
        public string Ntitle { get; set; }
        public string Tbody { get; set; }
        public DateTime Created_at { get; set; }
        public int Mbudget { get; set; }
        public int views { get; set; }
        public int pic { get; set; }
        public UserResource User { get; set; }
    }
}