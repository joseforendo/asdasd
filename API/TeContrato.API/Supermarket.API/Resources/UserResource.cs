﻿namespace Supermarket.API.Resources
{
    //Esta clase es usada para que el usuario vea, solo lo que el desarrolaldor quiere que vea de User
    //Esto se hace porque una categoría tiene productos, y es una regla importante que una API nunca debe
    //exponer el modelo relacional que está detrás de ella. Por ello se crea un Resource
    public class UserResource
    {
        public string Nuser { get; set; }
        public string Cpassword { get; set; }
        public string Temail { get; set; }
        public int Cdni { get; set; }
        public string Nname { get; set; }
        public string Nlastname { get; set; }
        public int is_admin { get; set; }
    }
}