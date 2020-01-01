using Application.Repositories.LegalPerson;

namespace Application.UseCase.LegalPerson.Add
{
    public class AddLegalPersonUseCase : IAddLegalPersonUseCase
    {
        private readonly ILegalPersonWriteOnlyUseCase LegalPersonWriteOnlyUseCase;

        public AddLegalPersonUseCase(ILegalPersonWriteOnlyUseCase legalPersonWriteOnlyUseCase)
        {
            LegalPersonWriteOnlyUseCase = legalPersonWriteOnlyUseCase;
        }

        public int Add(Domain.LegalPerson.LegalPerson legalPerson)
        {
            return LegalPersonWriteOnlyUseCase.Add(legalPerson);
        }
    }
}
