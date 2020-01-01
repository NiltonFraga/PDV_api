using Application.Repositories.Product;

namespace Application.UseCase.Product.Remove
{
    public class RemoveProductUseCase : IRemoveProductUseCase
    {
        private readonly IProductWriteOnlyUseCase ProductWriteOnlyUseCase;

        public RemoveProductUseCase(IProductWriteOnlyUseCase productWriteOnlyUseCase)
        {
            ProductWriteOnlyUseCase = productWriteOnlyUseCase;
        }

        public int Remove(Domain.Product.Product product)
        {
            return ProductWriteOnlyUseCase.Remove(product);
        }
    }
}
