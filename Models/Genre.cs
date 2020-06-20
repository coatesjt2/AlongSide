using System.ComponentModel.DataAnnotations;

namespace AlongSide.Models
{
    public class Genre
    //mentors background or type of Professional
    {
        public byte Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}