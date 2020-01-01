using System;
using System.Collections.Generic;

namespace Application.Repositories.LegalPerson
{
    public interface ILegalPersonReadOnlyUseCase
    {
        List<Domain.LegalPerson.LegalPerson> GetAll();
        Domain.LegalPerson.LegalPerson GetById(Guid id);
    }
}
