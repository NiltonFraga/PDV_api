namespace Application.UseCase.PhysicalPerson.Remove
{
    public interface IRemovePhysicalPersonUseCase
    {
        int Remove(Domain.PhysicalPerson.PhysicalPerson physicalPerson);
    }
}
