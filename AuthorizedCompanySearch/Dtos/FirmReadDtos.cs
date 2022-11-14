using AuthorizedCompanySearch.Models;

namespace AuthorizedCompanySearch.Dtos
{
    public class FirmReadDtos
    {
        public int FirmId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public bool HaveAuthority { get; set; } = false;
        public virtual IEnumerable<PersonelModel> Personel { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Authority { get; set; }
        public double FirmPerformansScore { get; set; }
        public double GasOpenningPercentage { get; set; }
    }
}
