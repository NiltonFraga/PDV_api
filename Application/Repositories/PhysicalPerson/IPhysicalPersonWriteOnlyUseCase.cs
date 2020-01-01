namespace Application.Repositories.PhysicalPerson
{
    public interface IPhysicalPersonWriteOnlyUseCase
    {
        int Add(Domain.PhysicalPerson.PhysicalPerson physicalPerson);
        int Remove(Domain.PhysicalPerson.PhysicalPerson physicalPerson);
        int Update(Domain.PhysicalPerson.PhysicalPerson physicalPerson);
    }
}
