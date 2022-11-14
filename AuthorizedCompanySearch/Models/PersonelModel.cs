using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuthorizedCompanySearch.Models
{
    public class PersonelModel
    {
        [Key]
        public int personelId { get; set; } 
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Phone { get; set; }

        [ForeignKey("FirmId")]
        public int  FirmId { get; set; }

        
      //public virtual FirmModel FirmModel { get; set; } = null;   


    }
}
