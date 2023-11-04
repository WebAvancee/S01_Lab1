﻿using Jungle_Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jungle_DataAccess.Repository.IRepository
{
    public interface ICustomerRepository : IRepository<Customer>
    {


        void Update(Customer customer);

        


    }
}
