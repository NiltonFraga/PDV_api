using Application.Repositories.Saller;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.UseCase.Saller.Remove
{
    public class RemoveSallerUseCase : IRemoveSallerUseCase
    {
        private readonly ISallerWriteOnlyUseCase SallerWriteOnlyUseCase;
        public RemoveSallerUseCase(ISallerWriteOnlyUseCase sallerWriteOnlyUseCase)
        {
            SallerWriteOnlyUseCase = sallerWriteOnlyUseCase;
        }
        public int Remove(Domain.Saller.Saller saller)
        {
            return SallerWriteOnlyUseCase.Remove(saller);
        }
    }
}
