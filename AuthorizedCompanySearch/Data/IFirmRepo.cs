using AuthorizedCompanySearch.Models;

namespace AuthorizedCompanySearch.Data
{
    public interface IFirmRepo
    {
        IEnumerable<FirmModel> GetAllFirm();
        FirmModel GetFirmById(int id);

        bool SaveChanges();

    }
}
