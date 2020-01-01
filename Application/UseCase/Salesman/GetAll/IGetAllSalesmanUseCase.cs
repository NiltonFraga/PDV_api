using System.Collections.Generic;

namespace Application.UseCase.Salesman.GetAll
{
    public interface IGetAllSalesmanUseCase
    {
        List<Domain.Salesman.Salesman> GetAll();
    }
}
