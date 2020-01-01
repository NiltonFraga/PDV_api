namespace Application.UseCase.LegalPerson.Remove
{
    public interface IRemoveLegalPersonUseCase
    {
        int Remove(Domain.LegalPerson.LegalPerson legalPerson);
    }
}
