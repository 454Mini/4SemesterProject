using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniJur.ClientMasterData.Domain.Models
{
    public class ActivityPet
    {
        public string ActivityPetId { get; set; }
        public string ActivityId { get; set; }
        public string PetId { get; set; }
        public string Level { get; set; }
    }
}
