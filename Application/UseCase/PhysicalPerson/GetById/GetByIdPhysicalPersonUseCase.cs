using Application.Repositories.PhysicalPerson;
using System;

namespace Application.UseCase.PhysicalPerson.GetById
{
    public class GetByIdPhysicalPersonUseCase : IGetByIdPhysicalPersonUseCase
    {
        private readonly IPhysicalPersonReadOnlyUseCase PhysicalPersonReadOnlyUseCase;

        public GetByIdPhysicalPersonUseCase(IPhysicalPersonReadOnlyUseCase physicalPersonReadOnlyUseCase)
        {
            PhysicalPersonReadOnlyUseCase = physicalPersonReadOnlyUseCase;
        }

        public Domain.PhysicalPerson.PhysicalPerson GetById(Guid id)
        {
            return PhysicalPersonReadOnlyUseCase.GetById(id);
        }
    }
}
