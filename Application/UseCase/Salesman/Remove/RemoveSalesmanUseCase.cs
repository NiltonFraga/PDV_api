using Application.Repositories.Salesman;

namespace Application.UseCase.Salesman.Remove
{
    public class RemoveSalesmanUseCase : IRemoveSalesmanUseCase
    {
        private readonly ISalesmanWriteOnlyUseCase SalesmanWriteOnlyUseCase;

        public RemoveSalesmanUseCase(ISalesmanWriteOnlyUseCase salesmanWriteOnlyUseCase)
        {
            SalesmanWriteOnlyUseCase = salesmanWriteOnlyUseCase;
        }

        public int Remove(Domain.Salesman.Salesman salesman)
        {
            return SalesmanWriteOnlyUseCase.Remove(salesman);
        }
    }
}
