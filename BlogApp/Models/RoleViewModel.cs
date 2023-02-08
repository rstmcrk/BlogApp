using System.ComponentModel.DataAnnotations;

namespace BlogApp.Models
{
    public class RoleViewModel
    {
        [Required(ErrorMessage = "Rol Adı Giriniz")]
        public string name { get; set; }
    }
}
