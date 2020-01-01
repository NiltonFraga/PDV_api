using Application.Repositories.LegalPerson;

namespace Application.UseCase.LegalPerson.Update
{
    public class UpdateLegalPersonUseCase : IUpdateLegalPersonUseCase
    {
        private readonly ILegalPersonWriteOnlyUseCase LegalPersonWriteOnlyUseCase;

        public UpdateLegalPersonUseCase(ILegalPersonWriteOnlyUseCase legalPersonWriteOnlyUseCase)
        {
            LegalPersonWriteOnlyUseCase = legalPersonWriteOnlyUseCase;
        }

        public int Update(Domain.LegalPerson.LegalPerson legalPerson)
        {
            return LegalPersonWriteOnlyUseCase.Update(legalPerson);
        }
    }
}
