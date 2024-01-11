using AmazingRaceAPI.Data;
using AmazingRaceAPI.DTOS;
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
        public Enterprise GetEnterprise(int id)
        {
            return _context.Enterprises.Where(e => e.Id == id).FirstOrDefault() ?? throw new ArgumentException($"There is no Enterprise with id: {id}");
        }
        public Enterprise EditEnterprise(int id, EnterpriseDTO enterprise)
        {
            Enterprise toEdit = _context.Enterprises.Where(e => e.Id == id).FirstOrDefault() ?? throw new ArgumentException($"There is no Enterprise with id: {id}");
            toEdit.Name = enterprise.Name;
            toEdit.Location = enterprise.Location;
            toEdit.Capacity = enterprise.Capacity;
            toEdit.Description = enterprise.Description;
            toEdit.PicData = enterprise.PicData;
            toEdit.PicFileName = enterprise.PicFileName;
            _context.SaveChanges();
            return toEdit;
        }
        public Enterprise AddEnterprise(EnterpriseDTO enterprise)
        {
            Enterprise newObj = new Enterprise()
            {
                Name = enterprise.Name,
                Location = enterprise.Location,
                Capacity = enterprise.Capacity,
                Description = enterprise.Description,
                PicFileName = enterprise.PicFileName,
                PicData = enterprise.PicData
            };
            _context.Enterprises.Add(newObj);
            _context.SaveChanges();
            return newObj;
        }
        public Enterprise DeleteEnterprise(int id)
        {
            Enterprise toRemove = _context.Enterprises.Where(e => e.Id == id).FirstOrDefault() ?? throw new ArgumentException($"There is no Enterprise with id: {id}");
            _context.Enterprises.Remove(toRemove);
            _context.SaveChanges();
            return toRemove;
        }

    }
}
