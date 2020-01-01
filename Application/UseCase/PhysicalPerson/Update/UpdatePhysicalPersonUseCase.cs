using Application.Repositories.PhysicalPerson;

namespace Application.UseCase.PhysicalPerson.Update
{
    public class UpdatePhysicalPersonUseCase : IUpdatePhysicalPersonUseCase
    {
        private readonly IPhysicalPersonWriteOnlyUseCase PhysicalPersonWriteOnlyUseCase;

        public UpdatePhysicalPersonUseCase(IPhysicalPersonWriteOnlyUseCase physicalPersonWriteOnlyUseCase)
        {
            PhysicalPersonWriteOnlyUseCase = physicalPersonWriteOnlyUseCase;
        }

        public int Update(Domain.PhysicalPerson.PhysicalPerson physicalPerson)
        {
            return PhysicalPersonWriteOnlyUseCase.Update(physicalPerson);
        }
    }
}
