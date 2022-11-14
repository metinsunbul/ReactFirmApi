using AuthorizedCompanySearch.Models;

namespace AuthorizedCompanySearch.Data
{
    public interface IFirmRepo
    {
        IEnumerable<FirmModel> GetAllFirm();
        FirmModel GetFirmById(int id);

        void AddFirm(FirmModel model);
        bool SaveChanges();

    }
}
