using ClientMannager.Models;
using Microsoft.EntityFrameworkCore;

namespace ClientMannager.Repositories
{
    namespace HomeBankingMindHub.Repositories
    {
        public class ClientRepository : RepositoryBase<Client>, IClientRepository
        {
            public ClientRepository(ClientMannagerContext repositoryContext) : base(repositoryContext)
            {
            }

            public Client FindById(long id)
            {
                return FindByCondition(client => client.Id == id)
                    .Include(client => client.Orders)
                    .FirstOrDefault();
            }

            public IEnumerable<Client> GetAllClients()
            {
                return FindAll()
                    .Include(client => client.Orders)
                    .ToList();
            }

            public void Save(Client client)
            {
                Create(client);
                SaveChanges();
            }
        }
    }
}
