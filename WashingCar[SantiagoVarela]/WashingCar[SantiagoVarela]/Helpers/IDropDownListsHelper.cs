using Microsoft.AspNetCore.Mvc.Rendering;

namespace WashingCar_SantiagoVarela_.Helpers
{
    public interface IDropDownListsHelper
    {
        Task<IEnumerable<SelectListItem>> GetDDLServicesAsync();
    }
}
