using System;

namespace Application.UseCase.Product.GetById
{
    public interface IGetByIdProductUseCase
    {
        Domain.Product.Product GetById(Guid id);
    }
}
