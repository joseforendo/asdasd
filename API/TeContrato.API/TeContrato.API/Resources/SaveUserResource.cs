using System.ComponentModel.DataAnnotations;

namespace Supermarket.API.Resources
{
    public abstract class SaveUserResource
    {
        public SaveUserResource(string nuser, int cpassword, string temail, int cdni, string nname, string nlastname, int isAdmin)
        {
            Nuser = nuser;
            Cpassword = cpassword;
            Temail = temail;
            Cdni = cdni;
            Nname = nname;
            Nlastname = nlastname;
            is_admin = isAdmin;
        }

        public string Nuser { get; set; }
        public int Cpassword { get; set; }
        public string Temail { get; set; }
        public int Cdni { get; set; }
        public string Nname { get; set; }
        public string Nlastname { get; set; }
        public int is_admin { get; set; }
    }
}
