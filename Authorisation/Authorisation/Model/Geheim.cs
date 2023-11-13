using System.ComponentModel.DataAnnotations;

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
