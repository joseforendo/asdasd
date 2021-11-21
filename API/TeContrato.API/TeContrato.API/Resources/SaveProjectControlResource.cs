using System;
using System.ComponentModel.DataAnnotations;

namespace Supermarket.API.Resources
{
    public class SaveProjectControlResource
    {
        [Required]
        [MaxLength(30)]
        public string Nproject { get; set; }
        public int Fstatus { get; set; }
        public DateTime Dlastedited { get; set; }
        public string Ttasks { get; set; }
        public int Qemployees { get; set; }
        public int Mbudget { get; set; }
        public int Qprogress { get; set; }
    }
}