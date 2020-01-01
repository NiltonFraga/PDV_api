namespace Application.Repositories.Salesman
{
    public interface ISalesmanWriteOnlyUseCase
    {
        int Add(Domain.Salesman.Salesman salesman);
        int Remove(Domain.Salesman.Salesman salesman);
        int Update(Domain.Salesman.Salesman salesman);
    }
}
