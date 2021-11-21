namespace Supermarket.API.Resources
{
    //Esta clase es usada para que el usuario vea, solo lo que el desarrolaldor quiere que vea de User
    //Esto se hace porque una categoría tiene productos, y es una regla importante que una API nunca debe
    //exponer el modelo relacional que está detrás de ella. Por ello se crea un Resource
    public abstract class UserResource
    {
        public UserResource(int cuser, string nuser, int cpassword, string temail, int cdni, string nname, string nlastname, int isAdmin)
        {
            Cuser = cuser;
            Nuser = nuser;
            Cpassword = cpassword;
            Temail = temail;
            Cdni = cdni;
            Nname = nname;
            Nlastname = nlastname;
            is_admin = isAdmin;
        }

        public int Cuser { get; set; }
        public string Nuser { get; set; }
        public int Cpassword { get; set; }
        public string Temail { get; set; }
        public int Cdni { get; set; }
        public string Nname { get; set; }
        public string Nlastname { get; set; }
        public int is_admin { get; set; }
    }
}