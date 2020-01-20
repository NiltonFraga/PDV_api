using Application.Repositories.Saller;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.UseCase.Saller.Update
{
    public class UpdateSallerUseCase : IUpdateSallerUseCase
    {
        private readonly ISallerWriteOnlyUseCase SallerWriteOnlyUseCase;
        public UpdateSallerUseCase(ISallerWriteOnlyUseCase sallerWriteOnlyUseCase)
        {
            SallerWriteOnlyUseCase = sallerWriteOnlyUseCase;
        }
        public int Update(Domain.Saller.Saller saller)
        {
            return SallerWriteOnlyUseCase.Update(saller);
        }
    }
}
