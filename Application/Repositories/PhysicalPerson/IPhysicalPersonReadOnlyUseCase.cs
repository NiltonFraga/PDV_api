using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Repositories.PhysicalPerson
{
    public interface IPhysicalPersonReadOnlyUseCase
    {
        List<Domain.PhysicalPerson.PhysicalPerson> GetAll();
        Domain.PhysicalPerson.PhysicalPerson GetById(Guid id);
    }
}
