using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AmazingRaceAPI.Entitites
{
    [Table("Enterprises")]
    public class Enterprise
    {
        [Key]
        [Required]
        [Column("Id")]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Location { get; set; } = string.Empty;
        public int Capacity { get; set; }
        public string? Description { get; set; }
        public string? PicFileName { get; set; }
        public byte[]? PicData { get; set; }



    }
}
