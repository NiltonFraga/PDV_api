using System.Collections.Generic;

namespace Application.UseCase.PhysicalPerson.GetAll
{
    public interface IGetAllPhysicalPersonUseCase
    {
        List<Domain.PhysicalPerson.PhysicalPerson> GetAll();
    }
}
