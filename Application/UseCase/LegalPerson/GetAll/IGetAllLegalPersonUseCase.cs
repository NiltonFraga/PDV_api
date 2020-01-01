using System.Collections.Generic;

namespace Application.UseCase.LegalPerson.GetAll
{
    public interface IGetAllLegalPersonUseCase
    {
        List<Domain.LegalPerson.LegalPerson> GetAll();
    }
}
