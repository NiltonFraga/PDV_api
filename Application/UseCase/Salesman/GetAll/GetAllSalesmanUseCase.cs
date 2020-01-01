using Application.Repositories.Salesman;
using System.Collections.Generic;

namespace Application.UseCase.Salesman.GetAll
{
    public class GetAllSalesmanUseCase : IGetAllSalesmanUseCase
    {
        private readonly ISalesmanReadOnlyUseCase SalesmanReadOnlyUseCase;

        public GetAllSalesmanUseCase(ISalesmanReadOnlyUseCase salesmanReadOnlyUseCase)
        {
            SalesmanReadOnlyUseCase = salesmanReadOnlyUseCase;
        }

        public List<Domain.Salesman.Salesman> GetAll()
        {
            return SalesmanReadOnlyUseCase.GetAll();
        }
    }
}
