using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniJur.ClientMasterData.Domain.Models
{
    public class Pet
    {
        public string PetId { get; set; }
        public string Animal { get; set; }
        public string Name { get; set; }
        public DateTime Birtday { get; set; }
        public string Breed { get; set; }
        public string Food { get; set; }
        public string SleepPlace { get; set; }
        public string DayStay { get; set; }
        public string Mind { get; set; }
        public string Sex { get; set; }
        public string VetId { get; set; }
        public string EnsuranceId { get; set; }
    }
}
