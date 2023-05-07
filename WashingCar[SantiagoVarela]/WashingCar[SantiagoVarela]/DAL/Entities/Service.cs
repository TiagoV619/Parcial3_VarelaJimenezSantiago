using System.ComponentModel.DataAnnotations;

namespace WashingCar_SantiagoVarela_.DAL.Entities
{
    public class Service : Entity
    {
        [Display(Name = "Servicio")]
        public string Name { get; set; }

        [Display(Name = "Precio")]
        public float Price { get; set; }

        [Display(Name = "Vehiculos")]
        public ICollection<Vehicle> Vehicles { get; set; }


    }
}
