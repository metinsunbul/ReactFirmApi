using AuthorizedCompanySearch.Models;

namespace AuthorizedCompanySearch.Data
{
    public interface IPersonelRepo
    {
        IEnumerable<PersonelModel> GetPersonelByFirmId(int firmId);
        PersonelModel GetPersonelById(int Id);

        bool SaveChanges();
    }
}
