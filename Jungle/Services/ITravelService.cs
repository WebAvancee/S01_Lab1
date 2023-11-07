using Jungle_Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface ITravelService : IServiceBase<Travel>
    {
        public void Create() 
        { }
        
    }
}
