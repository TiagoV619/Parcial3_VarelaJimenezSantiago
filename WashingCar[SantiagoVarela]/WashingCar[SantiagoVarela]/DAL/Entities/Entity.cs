using System.ComponentModel.DataAnnotations;

namespace WashingCar_SantiagoVarela_.DAL.Entities
{
    public class Entity
    {

        [Key]
        [Required]
        public Guid Id { get; set; }
    }
}
