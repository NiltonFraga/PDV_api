using Application.Repositories.Product;
using System.Collections.Generic;

namespace Application.UseCase.Product.GetAll
{
    public class GetAllProductUseCase : IGetAllProductUseCase
    {
        private readonly IProductReadOnlyUseCase ProductReadOnlyUseCase;

        public GetAllProductUseCase(IProductReadOnlyUseCase productReadOnlyUseCase)
        {
            ProductReadOnlyUseCase = productReadOnlyUseCase;
        }

        public List<Domain.Product.Product> GetAll()
        {
            return ProductReadOnlyUseCase.GetAll();
        }
    }
}
