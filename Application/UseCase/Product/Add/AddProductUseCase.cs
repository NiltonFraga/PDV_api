using Application.Repositories.Product;

namespace Application.UseCase.Product.Add
{
    public class AddProductUseCase : IAddProductUseCase
    {
        private readonly IProductWriteOnlyUseCase ProductWriteOnlyUseCase;

        public AddProductUseCase(IProductWriteOnlyUseCase productWriteOnlyUseCase)
        {
            ProductWriteOnlyUseCase = productWriteOnlyUseCase;
        }

        public int Add(Domain.Product.Product product)
        {
            return ProductWriteOnlyUseCase.Add(product);
        }
    }
}
