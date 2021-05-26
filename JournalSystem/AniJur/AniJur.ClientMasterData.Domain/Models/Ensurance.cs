using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniJur.ClientMasterData.Domain.Models
{
    public  class Ensurance
    {
        public string EnsuranceId { get; set; }
        public string CompanyName { get; set; }
        public int Cvr { get; set; }
        public string Tlf { get; set; }
    }
}
