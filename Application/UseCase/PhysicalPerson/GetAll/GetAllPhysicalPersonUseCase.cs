using Application.Repositories.PhysicalPerson;
using System.Collections.Generic;

namespace Application.UseCase.PhysicalPerson.GetAll
{
    public class GetAllPhysicalPersonUseCase : IGetAllPhysicalPersonUseCase
    {
        private readonly IPhysicalPersonReadOnlyUseCase PhysicalPersonReadOnlyUseCase;

        public GetAllPhysicalPersonUseCase(IPhysicalPersonReadOnlyUseCase physicalPersonReadOnlyUseCase)
        {
            PhysicalPersonReadOnlyUseCase = physicalPersonReadOnlyUseCase;
        }

        public List<Domain.PhysicalPerson.PhysicalPerson> GetAll()
        {
            return PhysicalPersonReadOnlyUseCase.GetAll();
        }
    }
}
