﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._22_24._11._2023.DesignPrinciples
{
    public class CustomerService
    {
        private ICollection<Customer> Customers { get; } = new List<Customer> { new Customer(1), new Customer(2), new Customer(3), new Customer(4), new Customer(5) };

        public Customer? FindById(int customerId)
        {
            return Customers.Where(x => x.Id == customerId).SingleOrDefault();
        }
    }
}
