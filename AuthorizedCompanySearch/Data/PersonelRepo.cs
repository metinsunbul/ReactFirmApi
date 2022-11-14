using AuthorizedCompanySearch.Models;

namespace AuthorizedCompanySearch.Data
{
    public class PersonelRepo : IPersonelRepo
    {
        private readonly FirmDbContext _context;

        public PersonelRepo(FirmDbContext context)
        {
            _context = context;
        }

        public IEnumerable<PersonelModel> GetPersonelByFirmId(int firmId)
        {
            return _context.Personels.Where(f => f.FirmId == firmId).ToList();
        }

        public PersonelModel GetPersonelById(int Id)
        {
            return _context.Personels.FirstOrDefault(f => f.personelId == Id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
