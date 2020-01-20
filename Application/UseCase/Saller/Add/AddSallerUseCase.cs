using Application.Repositories.Saller;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.UseCase.Saller.Add
{
    public class AddSallerUseCase : IAddSallerUseCase
    {
        private readonly ISallerWriteOnlyUseCase SallerWriteOnlyUseCase;
        public AddSallerUseCase(ISallerWriteOnlyUseCase sallerWriteOnlyUseCase)
        {
            SallerWriteOnlyUseCase = sallerWriteOnlyUseCase;
        }
        public int Add(Domain.Saller.Saller saller)
        {
            return SallerWriteOnlyUseCase.Add(saller);
        }
    }
}
