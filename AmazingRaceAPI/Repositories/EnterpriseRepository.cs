using AmazingRaceAPI.Data;
using AmazingRaceAPI.Entitites;

namespace AmazingRaceAPI.Repositories
{
    public class EnterpriseRepository:IEnterpriseRepository
    {
        SQLDataContext _context;

        public EnterpriseRepository(SQLDataContext ef)
        {
            _context = ef;
        }
        public List<Enterprise> GetEnterprises()
        {
            return _context.Enterprises.ToList();
        }
    }
}
