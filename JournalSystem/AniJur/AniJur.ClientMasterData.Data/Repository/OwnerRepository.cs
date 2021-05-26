using AniJur.ClientMasterData.Data.Context;
using AniJur.ClientMasterData.Domain.Interfaces;
using AniJur.ClientMasterData.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniJur.ClientMasterData.Data.Repository
{
    public class OwnerRepository : IOwnerRepository
    {
        private MasterDataDbContext _ctx;
        public OwnerRepository(MasterDataDbContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<Owner> GetOwners()
        {
            return _ctx.Owners;
        }
    }
}
