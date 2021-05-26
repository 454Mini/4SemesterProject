using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniJur.ClientMasterData.Domain.Models
{
    public class Vet
    {
        public string VetId { get; set; }
        public string Clinic { get; set; }
        public string VetName { get; set; }
        public string Tlf { get; set; }
        public int Cvr { get; set; }
    }
}
