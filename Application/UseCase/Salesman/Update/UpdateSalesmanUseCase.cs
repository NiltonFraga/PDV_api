using Application.Repositories.Salesman;

namespace Application.UseCase.Salesman.Update
{
    public class UpdateSalesmanUseCase : IUpdateSalesmanUseCase
    {
        private readonly ISalesmanWriteOnlyUseCase SalesmanWriteOnlyUseCase;

        public UpdateSalesmanUseCase(ISalesmanWriteOnlyUseCase salesmanWriteOnlyUseCase)
        {
            SalesmanWriteOnlyUseCase = salesmanWriteOnlyUseCase;
        }

        public int Update(Domain.Salesman.Salesman salesman)
        {
            return SalesmanWriteOnlyUseCase.Remove(salesman);
        }
    }
}
