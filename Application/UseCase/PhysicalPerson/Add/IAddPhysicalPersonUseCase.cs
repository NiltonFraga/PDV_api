namespace Application.UseCase.PhysicalPerson.Add
{
    public interface IAddPhysicalPersonUseCase
    {
        int Add(Domain.PhysicalPerson.PhysicalPerson physicalPerson);
    }
}
