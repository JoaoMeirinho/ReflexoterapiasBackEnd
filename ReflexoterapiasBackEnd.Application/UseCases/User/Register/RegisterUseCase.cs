using ReflexoterapiasBackEnd.Communication.Requests;
using ReflexoterapiasBackEnd.Communication.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflexoterapiasBackEnd.Application.UseCases.User.Register
{
    class RegisterUseCase : IRegisterUseCase
    {
        public Task<ResponseRegisterUserJson> Execute(RequestRegisterUserJson user)
        {
            throw new NotImplementedException();
        }
    }
}
