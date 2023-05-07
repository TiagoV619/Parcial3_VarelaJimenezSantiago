using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace WashingCar_SantiagoVarela_.DAL.Entities
{
    public class Vehicle : Entity
    {
        [Display(Name = " Nombre del propietario")]
        public string Owner { get; set; }

        [Display(Name = "Placa vehiculo")]
        public string NumberPlate { get; set; }

        [Display(Name = "Servicio")]
        public Service Service { get; set; }

        [Display(Name = "Detalles del vehiculo")]
        public ICollection<VehicleDetail> VehiclesDetails { get; set; }



    }
}
