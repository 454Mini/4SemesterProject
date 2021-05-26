using AniJur.ClientMasterData.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniJur.ClientMasterData.Domain.Interfaces
{
   public interface IOwnerRepository
    {
        IEnumerable<Owner> GetOwners();
    }
}
