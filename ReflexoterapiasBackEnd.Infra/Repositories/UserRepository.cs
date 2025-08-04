using ReflexoterapiasBackEnd.Domain.Entities;
using ReflexoterapiasBackEnd.Infra.DataConfig;
using ReflexoterapiasBackEnd.Infra.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ReflexoterapiasBackEnd.Infra.Repositories
{
    class UserRepository(ReflexoDBContext dbContext) : UserRepositoryInterface
    {
        private readonly ReflexoDBContext _dBContext = dbContext;
        public async Task Add(User user) => await _dBContext.Users.AddAsync(user);
    }
}
