using System.ComponentModel.DataAnnotations;

namespace BasicRepository.Data
{
    public class Personel
    {
        [Key]
        public int Id { get; set; }
        public string ?Ad { get; set; }

    }
}
