using API.core.Models;
using API.core.Vmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.core.Interface
{
    public interface IBase<T> where T:class 
    {
        Result Add(RequestVM obj);
        Task<List<Request>> GetAll(); 
    }
}
