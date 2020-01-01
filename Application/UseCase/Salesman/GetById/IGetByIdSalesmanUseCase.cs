using System;

namespace Application.UseCase.Salesman.GetById
{
    public interface IGetByIdSalesmanUseCase
    {
        Domain.Salesman.Salesman GetById(Guid id);
    }
}
