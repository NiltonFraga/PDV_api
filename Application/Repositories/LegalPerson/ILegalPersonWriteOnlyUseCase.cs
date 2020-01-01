namespace Application.Repositories.LegalPerson
{
    public interface ILegalPersonWriteOnlyUseCase
    {
        int Add(Domain.LegalPerson.LegalPerson legalPerson);
        int Remove(Domain.LegalPerson.LegalPerson legalPerson);
        int Update(Domain.LegalPerson.LegalPerson legalPerson);
    }
}
