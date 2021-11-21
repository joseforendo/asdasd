using System.Collections.Generic;

namespace Supermarket.API.Domain.Models
{
    public class Contractor : User
    {
        public Contractor(int cuser, string nuser, int cpassword, string temail, int cdni, string nname, string nlastname, int isAdmin, int ccontractor, string tbio, string neducation, int numphone, IList<Project> cProject) : base(cuser, nuser, cpassword, temail, cdni, nname, nlastname, isAdmin)
        {
            Ccontractor = ccontractor;
            Tbio = tbio;
            Neducation = neducation;
            Numphone = numphone;
            CProject = cProject;
        }

        public int Ccontractor { get; set; }
        public string Tbio { get; set; }
        public string Neducation { get; set; }
        public int Numphone { get; set; }
        public IList<Project> CProject { get; set; }
    }
}
