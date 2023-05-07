using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace WashingCar_SantiagoVarela_.DAL.Entities
{
    public class VehicleDetail : Entity
    {
        [Display(Name = "Fecha de ingreso")]
        public DateTime CreationDate { get; set; }

        [Display(Name = "Fecha de entrega")]
        public DateTime DeliveryDate { get; set; }

        [Display(Name = "Vehiculo")]
        public Vehicle Vehicle { get; set; }

      
    }


}
