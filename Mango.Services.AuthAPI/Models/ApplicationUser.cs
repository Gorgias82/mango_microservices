using Microsoft.AspNetCore.Identity;

namespace Mango.Services.AuthAPI.Models
{
	//Imprementa el usuario por defecto de asp identity
	//y se le añaden las propiedades que se quiera
	public class ApplicationUser : IdentityUser
	{
        public string Name { get; set; }
    }
}
