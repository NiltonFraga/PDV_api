using System;
using System.Collections.Generic;

namespace Application.Repositories.Product
{
    public interface IProductReadOnlyUseCase
    {
        List<Domain.Product.Product> GetAll();
        Domain.Product.Product GetById(Guid id);
    }
}
