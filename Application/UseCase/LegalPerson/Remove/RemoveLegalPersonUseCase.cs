using Application.Repositories.LegalPerson;

namespace Application.UseCase.LegalPerson.Remove
{
    public class RemoveLegalPersonUseCase : IRemoveLegalPersonUseCase
    {
        private readonly ILegalPersonWriteOnlyUseCase LegalPersonWriteOnlyUseCase;

        public RemoveLegalPersonUseCase(ILegalPersonWriteOnlyUseCase legalPersonWriteOnlyUseCase)
        {
            LegalPersonWriteOnlyUseCase = legalPersonWriteOnlyUseCase;
        }

        public int Remove(Domain.LegalPerson.LegalPerson legalPerson)
        {
            return LegalPersonWriteOnlyUseCase.Remove(legalPerson);
        }
    }
}
