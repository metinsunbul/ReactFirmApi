using AuthorizedCompanySearch.Models;

namespace AuthorizedCompanySearch.Data
{
    public class FirmRepo : IFirmRepo
    {
        private readonly FirmDbContext _context;

        public FirmRepo(FirmDbContext context)
        {
            _context = context;
        }
        public IEnumerable<FirmModel> GetAllFirm()
        {
            return _context.FirmModels.ToList();
        }

        public FirmModel GetFirmById(int id)
        {
            return _context.FirmModels.FirstOrDefault(f => f.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
