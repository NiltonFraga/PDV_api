using Application.Repositories.LegalPerson;
using System;

namespace Application.UseCase.LegalPerson.GetById
{
    public class GetByIdLegalPersonUseCase : IGetByIdLegalPersonUseCase
    {
        private readonly ILegalPersonReadOnlyUseCase LegalPersonReadOnlyUseCase;

        public GetByIdLegalPersonUseCase(ILegalPersonReadOnlyUseCase legalPersonReadOnlyUseCase)
        {
            LegalPersonReadOnlyUseCase = legalPersonReadOnlyUseCase;
        }

        public Domain.LegalPerson.LegalPerson GetById(Guid id)
        {
            return LegalPersonReadOnlyUseCase.GetById(id);
        }
    }
}
