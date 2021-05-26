 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniJur.ClientMasterData.Domain.Models
{
    public class MedicationPet
    {
        public string MedPetId { get; set; }
        public string MedId { get; set; }
        public string Amount { get; set; }
        public string Period { get; set; }
        public string PetId { get; set; }

    }
}

