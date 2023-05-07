using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WashingCar_SantiagoVarela_.DAL;
using WashingCar_SantiagoVarela_.Helpers;

namespace WashingCar_SantiagoVarela_.Services
{
    public class DropDownListsHelper : IDropDownListsHelper
    {
        private readonly DatabaseContext _context;

        public DropDownListsHelper(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SelectListItem>> GetDDLServicesAsync()
        {
            List<SelectListItem> listServices = await _context.Services
                .Select(s => new SelectListItem
                {
                    Text = s.Name, 
                    Value = s.Id.ToString(), //Guid                    
                })
                .ToListAsync();

            listServices.Insert(0, new SelectListItem
            {
                Text = "Selecione el servicio deseado...",
                Value = Guid.Empty.ToString(),
                Selected = true
            });

            return listServices;
        }
    }
}
