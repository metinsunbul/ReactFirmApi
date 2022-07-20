namespace AuthorizedCompanySearch.Models
{
    public class PersonelModel
    {
        public int Id { get; set; } 
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Phone { get; set; }

        public int FirmId { get; set; }
        public virtual FirmModel FirmModel { get; set; }


    }
}
