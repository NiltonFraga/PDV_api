using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Repositories.Product
{
    public interface IProductWriteOnlyUseCase
    {
        int Add(Domain.Product.Product product);
        int Remove(Domain.Product.Product product);
        int Update(Domain.Product.Product product);
    }
}
