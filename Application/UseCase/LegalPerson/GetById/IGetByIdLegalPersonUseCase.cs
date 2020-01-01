using System;

namespace Application.UseCase.LegalPerson.GetById
{
    public interface IGetByIdLegalPersonUseCase
    {
        Domain.LegalPerson.LegalPerson GetById(Guid id);
    }
}
