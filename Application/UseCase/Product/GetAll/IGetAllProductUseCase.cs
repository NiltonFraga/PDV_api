using System.Collections.Generic;

namespace Application.UseCase.Product.GetAll
{
    public interface IGetAllProductUseCase
    {
        List<Domain.Product.Product> GetAll();
    }
}
