using System.ComponentModel.DataAnnotations;

namespace Supermarket.API.Resources
{
    public class SaveContractorResource : SaveUserResource
    {
        public SaveContractorResource(string nuser, int cpassword, string temail, int cdni, string nname, string nlastname, int isAdmin, string tbio, string neducation, int numphone) : base(nuser, cpassword, temail, cdni, nname, nlastname, isAdmin)
        {
            Tbio = tbio;
            Neducation = neducation;
            Numphone = numphone;
        }
        public string Tbio { get; set; }
        public string Neducation { get; set; }
        public int Numphone { get; set; }
    }
}