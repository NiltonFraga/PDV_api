using Application.Repositories.Salesman;
using System;

namespace Application.UseCase.Salesman.GetById
{
    public class GetByIdSalesmanUseCase : IGetByIdSalesmanUseCase
    {
        private readonly ISalesmanReadOnlyUseCase SalesmanReadOnlyUseCase;

        public GetByIdSalesmanUseCase(ISalesmanReadOnlyUseCase salesmanReadOnlyUseCase)
        {
            SalesmanReadOnlyUseCase = salesmanReadOnlyUseCase;
        }

        public Domain.Salesman.Salesman GetById(Guid id)
        {
            return SalesmanReadOnlyUseCase.GetById(id);
        }
    }
}