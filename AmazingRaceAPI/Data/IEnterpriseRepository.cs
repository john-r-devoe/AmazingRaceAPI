using AmazingRaceAPI.DTOS;
using AmazingRaceAPI.Entitites;

namespace AmazingRaceAPI.Data
{
    public interface IEnterpriseRepository
    {
        public List<Enterprise> GetEnterprises();
        public Enterprise GetEnterprise(int id);
        public Enterprise EditEnterprise(int id, EnterpriseDTO enterprise);
        public Enterprise AddEnterprise(EnterpriseDTO enterprise);
        public Enterprise DeleteEnterprise(int id);
    }
}
