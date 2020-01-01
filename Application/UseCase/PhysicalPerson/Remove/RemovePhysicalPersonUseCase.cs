using Application.Repositories.PhysicalPerson;

namespace Application.UseCase.PhysicalPerson.Remove
{
    public class RemovePhysicalPersonUseCase : IRemovePhysicalPersonUseCase
    {
        private readonly IPhysicalPersonWriteOnlyUseCase PhysicalPersonWriteOnlyUseCase;

        public RemovePhysicalPersonUseCase(IPhysicalPersonWriteOnlyUseCase physicalPersonWriteOnlyUseCase)
        {
            PhysicalPersonWriteOnlyUseCase = physicalPersonWriteOnlyUseCase;
        }

        public int Remove(Domain.PhysicalPerson.PhysicalPerson physicalPerson)
        {
            return PhysicalPersonWriteOnlyUseCase.Remove(physicalPerson);
        }
    }
}
