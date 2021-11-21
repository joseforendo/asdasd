using System.Collections.Generic;

namespace Supermarket.API.Domain.Models
{
    //Los nombres de las clases se deben poner en en singular, ya que así es la regla, pero estos objetos irán
    //a una tabla de una BD, donde debe ser plural, por ello se debe agregar Microsoft.EntityFrameworkCore.Relational
    //y usar la propiedad .ToTable()
    public abstract class User
    {
        public User(int cuser, string nuser, int cpassword, string temail, int cdni, string nname, string nlastname, int isadmin)
        {
            Cuser = cuser;
            Nuser = nuser;
            Cpassword = cpassword;
            Temail = temail;
            Cdni = cdni;
            Nname = nname;
            Nlastname = nlastname;
            this.isadmin = isadmin;
        }

        public int Cuser { get; set; }
        public string Nuser { get; set; }
        public int Cpassword { get; set; }
        public string Temail { get; set; }
        public int Cdni { get; set; }
        public string Nname { get; set; }
        public string Nlastname { get; set; }
        public int isadmin { get; set; }

    }
}
