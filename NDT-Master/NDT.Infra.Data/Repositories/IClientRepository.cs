using NDT.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NDT.Infra.Data.Repositories
{
    public interface IClientRepository
    {
        IEnumerable<Client> Clients { get; }

        Client this[string name] { get; }

        void AddClient(Client client);

        void DeleteClient(Client client);
    }
}
