using System.ComponentModel.DataAnnotations;
using Models.Interfaces;

namespace Models.Abstract
{
    public class BaseEntity : IEntity
    {
        [Key]
        public int Id { get; set; }
    }
}