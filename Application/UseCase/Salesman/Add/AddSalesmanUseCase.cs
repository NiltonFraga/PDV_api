using Application.Repositories.Salesman;

namespace Application.UseCase.Salesman.Add
{
    public class AddSalesmanUseCase : IAddSalesmanUseCase
    {
        private readonly ISalesmanWriteOnlyUseCase SalesmanWriteOnlyUseCase;

        public AddSalesmanUseCase(ISalesmanWriteOnlyUseCase salesmanWriteOnlyUseCase)
        {
            SalesmanWriteOnlyUseCase = salesmanWriteOnlyUseCase;
        }

        public int Add(Domain.Salesman.Salesman salesman)
        {
            return SalesmanWriteOnlyUseCase.Add(salesman);
        }
    }
}
