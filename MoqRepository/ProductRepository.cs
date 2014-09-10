using System;
using System.Collections.Generic;

namespace MoqRepositorySample
{
    public class ProductRepository : IProductRepository
    {
        #region IProductRepository Members

        public IList<Product> FindAll()
        {
            // Your database code here, whether it is linq, or ADO.Net, or something else
            // That actually fetches all the Products from a database and creates a list
            throw new NotImplementedException();
        }

        public Product FindByName(string productName)
        {
            // Your database code here, whether it is linq, or ADO.Net, or something else
            // That actually fetches a Product from a database, using the supplied parameter
            throw new NotImplementedException();
        }

        public Product FindById(int productId)
        {
            // Your database code here, whether it is linq, or ADO.Net, or something else
            // That actually fetches a Product from a database, using the supplied parameter
            throw new NotImplementedException();
        }

        public bool Save(Product target)
        {
            // Your database code here, whether it is linq, or ADO.Net, or something else
            // That actually saves a Product to a database (insert or update), using the supplied parameter
            throw new NotImplementedException();
        }

        #endregion
    }
}