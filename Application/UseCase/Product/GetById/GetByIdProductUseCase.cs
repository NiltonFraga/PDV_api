using Application.Repositories.Product;
using System;

namespace Application.UseCase.Product.GetById
{
    public class GetByIdProductUseCase : IGetByIdProductUseCase
    {
        private readonly IProductReadOnlyUseCase ProductReadOnlyUseCase;

        public GetByIdProductUseCase(IProductReadOnlyUseCase productReadOnlyUseCase)
        {
            ProductReadOnlyUseCase = productReadOnlyUseCase;
        }

        public Domain.Product.Product GetById(Guid id)
        {
            return ProductReadOnlyUseCase.GetById(id);
        }
    }
}
