using System;
using System.Collections.Generic;
using System.Text;
using NDT.Domain.Models;

namespace NDT.Infra.Data.Repositories
{
    public class ClientRepository : IClientRepository
    {
        public Client this[string name] => throw new NotImplementedException();

        public IEnumerable<Client> Clients { get; }

        public void AddClient(Client client)
        {
            throw new NotImplementedException();
        }

        public void DeleteClient(Client client)
        {
            throw new NotImplementedException();
        }
    }
}
