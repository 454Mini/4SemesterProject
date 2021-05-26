using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniJur.ClientMasterData.Domain.Models
{
    public class Owner
    {
        public string OwnerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Zip { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Tlf { get; set; }
        public string AnimalId { get; set; } //Laves laves om til collection af dogs
    }
}
