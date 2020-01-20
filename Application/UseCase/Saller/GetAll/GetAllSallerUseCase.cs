using Application.Repositories.Saller;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.UseCase.Saller.GetAll
{
    public class GetAllSallerUseCase : IGetAllSallerUseCase
    {
        private readonly ISallerReadOnlyUseCase SalleReadOnlyUseCase;
        public GetAllSallerUseCase(ISallerReadOnlyUseCase salleReadOnlyUseCase)
        {
            SalleReadOnlyUseCase = salleReadOnlyUseCase;
        }

        public List<Domain.Saller.Saller> GetAll()
        {
            return SalleReadOnlyUseCase.GetAll();
        }
    }
}
