using System;

namespace Application.UseCase.PhysicalPerson.GetById
{
    public interface IGetByIdPhysicalPersonUseCase
    {
        Domain.PhysicalPerson.PhysicalPerson GetById(Guid id);
    }
}
