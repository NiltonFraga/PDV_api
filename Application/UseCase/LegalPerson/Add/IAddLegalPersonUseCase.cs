namespace Application.UseCase.LegalPerson.Add
{
    public interface IAddLegalPersonUseCase
    {
        int Add(Domain.LegalPerson.LegalPerson legalPerson);
    }
}
