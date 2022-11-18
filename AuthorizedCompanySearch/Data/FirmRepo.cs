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

        public void AddFirm(FirmModel model)
        {
            
            if (model != null)
            {
              var result =   _context.Firms.Add(model);
                SaveChanges();
            }
            
        }

        public bool DeleteFirm(int id)
        {
            var firmToDelete = GetFirmById(id);

            if (DeleteFirm != null)
            {
                try
                {
                    _context.Firms.Remove(firmToDelete);
                    return SaveChanges();
                }
                catch (Exception)
                {

                   return false;
                }
                 
            }
            return false;
            
        }

        public IEnumerable<FirmModel> GetAllFirm()
        {
            return _context.Firms.ToList();
        }

        public FirmModel GetFirmById(int id)
        {
            return _context.Firms.FirstOrDefault(f => f.FirmId == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
