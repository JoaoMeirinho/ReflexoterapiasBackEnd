using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReflexoterapiasBackEnd.Communication.Requests;
using ReflexoterapiasBackEnd.Communication.Responses;

namespace ReflexoterapiasBackEnd.Application.UseCases.User.Register
{
    interface IRegisterUseCase
    {
        public Task<ResponseRegisterUserJson> Execute(RequestRegisterUserJson user);
    }
}
