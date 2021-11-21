using System.Collections.Generic;

namespace Supermarket.API.Domain.Models
{
    public class Client : User
    {
        public Client(int cuser, string nuser, int cpassword, string temail, int cdni, string nname, string nlastname, int isadmin, string tbio, string taddress) : base(cuser, nuser, cpassword, temail, cdni, nname, nlastname, isadmin)
        {
            Tbio = tbio;
            Taddress = taddress;
        }

        public string Tbio { get; set; }
        public string Taddress { get; set; }

    }
}
