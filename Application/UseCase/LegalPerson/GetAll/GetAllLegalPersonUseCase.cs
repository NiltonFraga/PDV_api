using Application.Repositories.LegalPerson;
using System.Collections.Generic;

namespace Application.UseCase.LegalPerson.GetAll
{
    public class GetAllLegalPersonUseCase : IGetAllLegalPersonUseCase
    {
        private readonly ILegalPersonReadOnlyUseCase LegalPersonReadOnlyUseCase;

        public GetAllLegalPersonUseCase(ILegalPersonReadOnlyUseCase legalPersonReadOnlyUseCase)
        {
            LegalPersonReadOnlyUseCase = legalPersonReadOnlyUseCase;
        }

        public List<Domain.LegalPerson.LegalPerson> GetAll()
        {
            return LegalPersonReadOnlyUseCase.GetAll();
        }
    }
}
