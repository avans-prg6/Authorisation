using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Authorisation.Model
{
    public class Geheim
    {
        [Key]
        public int Id { get; set; }

        public string Inhoud { get; set; }

        public int SecurityLevel { get; set; }
    }
}
