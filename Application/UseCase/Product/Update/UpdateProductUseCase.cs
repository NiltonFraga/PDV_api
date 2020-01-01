using Application.Repositories.Product;

namespace Application.UseCase.Product.Update
{
    public class UpdateProductUseCase : IUpdateProductUseCase
    {
        private readonly IProductWriteOnlyUseCase ProductWriteOnlyUseCase;

        public UpdateProductUseCase(IProductWriteOnlyUseCase productWriteOnlyUseCase)
        {
            ProductWriteOnlyUseCase = productWriteOnlyUseCase;
        }

        public int Update(Domain.Product.Product product)
        {
            return ProductWriteOnlyUseCase.Update(product);
        }
    }
}
