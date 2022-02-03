using System.ComponentModel.DataAnnotations;
using Models.Abstract;
using Models.Enums;

namespace Models.Entities
{
    public class Device : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Status { get; set; }

        [Required]
        public decimal Temperature { get; set; }

        [Required]
        public int TypeId { get; set; }

        [Required]
        public DeviceType Type { get; set; }
    }
}
