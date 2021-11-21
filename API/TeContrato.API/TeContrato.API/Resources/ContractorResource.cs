namespace Supermarket.API.Resources
{
    public class ContractorResource : UserResource
    {
        public ContractorResource(int cuser, string nuser, int cpassword, string temail, int cdni, string nname, string nlastname, int isAdmin, string cbio, string neducation, int numphone) : base(cuser, nuser, cpassword, temail, cdni, nname, nlastname, isAdmin)
        {
            Cbio = cbio;
            Neducation = neducation;
            Numphone = numphone;
        }

        public string Cbio { get; set; }
        public string Neducation { get; set; }
        public int Numphone { get; set; }
    }
}