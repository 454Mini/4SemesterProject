using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniJur.ClientMasterData.Domain.Models
{
    public class Post
    {
        [Key]
        public int Zip { get; set; }
        public string City { get; set; }

    }
}
