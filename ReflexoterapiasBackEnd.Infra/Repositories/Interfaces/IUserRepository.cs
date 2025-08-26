using ReflexoterapiasBackEnd.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflexoterapiasBackEnd.Infra.Repositories.Interfaces
{
    interface IUserRepository
    {
        public Task Add(User user);
    }
}
