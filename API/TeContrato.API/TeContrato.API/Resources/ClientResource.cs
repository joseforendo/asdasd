namespace Supermarket.API.Resources
{
    public class ClientResource : UserResource
    {
        public ClientResource(int cuser, string nuser, int cpassword, string temail, int cdni, string nname, string nlastname, int isAdmin, string tbio, string taddress) : base(cuser, nuser, cpassword, temail, cdni, nname, nlastname, isAdmin)
        {
            Tbio = tbio;
            Taddress = taddress;
        }

        public string Tbio { get; set; }
        public string Taddress { get; set; }
    }
}
