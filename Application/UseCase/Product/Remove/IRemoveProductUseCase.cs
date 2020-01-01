namespace Application.UseCase.Product.Remove
{
    public interface IRemoveProductUseCase
    {
        int Remove(Domain.Product.Product product);
    }
}
