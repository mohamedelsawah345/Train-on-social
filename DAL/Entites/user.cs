using System.ComponentModel.DataAnnotations;

namespace DAL.Entites
{
    public class user
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Please ente UserName")]
        public string username { get; set; }

        [Required(ErrorMessage = "Please ente password")]
        public string password { get; set; }

        [Required(ErrorMessage = "Please ente email")]
        public string email { get; set; }

        public string? phone { get; set; }

        public string? city { get; set; }

        public string? country { get; set; }

        public bool? IsDeleted { get; set; }

        //List<like>? likes { get; set; }
        public List<post>? posts { get; set; }

        


    }
}
