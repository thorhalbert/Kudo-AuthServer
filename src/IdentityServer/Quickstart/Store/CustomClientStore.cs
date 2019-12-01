﻿using System.Threading.Tasks;
using IdentityServer4.Models;
using QuickstartIdentityServer.Quickstart.Interface;

namespace QuickstartIdentityServer.Quickstart.Store
{
    public class CustomClientStore : IdentityServer4.Stores.IClientStore
    {
        protected IRepository _dbRepository;

        public CustomClientStore(IRepository repository)
        {
            _dbRepository = repository;
        }

        public Task<Client> FindClientByIdAsync(string clientId)
        {
            var client = _dbRepository.Single<Client>(c => c.ClientId == clientId);

            return Task.FromResult(client);
        }
    }
}
