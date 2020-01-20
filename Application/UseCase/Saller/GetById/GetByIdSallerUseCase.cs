using Application.Repositories.Saller;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.UseCase.Saller.GetById
{
    public class GetByIdSallerUseCase : IGetByIdSallerUseCase
    {
        private readonly ISallerReadOnlyUseCase SallerReadOnlyUseCase;
        public GetByIdSallerUseCase(ISallerReadOnlyUseCase sallerReadOnlyUseCase)
        {
            SallerReadOnlyUseCase = sallerReadOnlyUseCase;
        }
        public Domain.Saller.Saller GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
