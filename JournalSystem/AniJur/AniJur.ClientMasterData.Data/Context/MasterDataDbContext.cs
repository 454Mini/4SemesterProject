using AniJur.ClientMasterData.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniJur.ClientMasterData.Data.Context
{
    public class MasterDataDbContext: DbContext
    {
        public MasterDataDbContext(DbContextOptions options): base(options)
        {

        }

        public DbSet<Owner> Owners { get; set; }
        public DbSet<Activities> Activities { get; set; }
        public DbSet<ActivityPet> ActivityDog { get; set; }
        public DbSet<Conditions> Conditions { get; set; }
        public DbSet<ConditionPet> ConditionDog { get; set; }
        public DbSet<Pet> Dog { get; set; }
        public DbSet<Ensurance> Ensurance { get; set; }
        public DbSet<Medication> Medication { get; set; }
        public DbSet<MedicationPet> MedicationDog { get; set; }
        public DbSet<Post> Post { get; set; }
        public DbSet<Vet> Vet { get; set; }
    }
}
