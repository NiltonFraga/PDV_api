using Application.Repositories.PhysicalPerson;

namespace Application.UseCase.PhysicalPerson.Add
{
    public class AddPhysicalPersonUseCase : IAddPhysicalPersonUseCase
    {
        private readonly IPhysicalPersonWriteOnlyUseCase PhysicalPersonWriteOnlyUseCase;

        public AddPhysicalPersonUseCase(IPhysicalPersonWriteOnlyUseCase physicalPersonWriteOnlyUseCase)
        {
            PhysicalPersonWriteOnlyUseCase = physicalPersonWriteOnlyUseCase;
        }

        public int Add(Domain.PhysicalPerson.PhysicalPerson physicalPerson)
        {
            return PhysicalPersonWriteOnlyUseCase.Add(physicalPerson);
        }
    }
}
