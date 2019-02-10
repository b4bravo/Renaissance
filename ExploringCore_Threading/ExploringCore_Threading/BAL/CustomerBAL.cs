using ExploringCore_Threading.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExploringCore_Threading.BAL
{
    /// <summary>
    /// used for Customer operations
    /// </summary>
    public class CustomerBAL
    {
        /// <summary>
        /// Gets Customer
        /// </summary>
        /// <returns></returns>
        public CustomerBO GetCustomer()
        {
            return new CustomerBO() { Id = 100, FName = "Rand", LName = "Ayn"};
        }
    }
}
