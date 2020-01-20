using System;
using System.Collections.Generic;
using System.Text;

namespace Application.UseCase.Saller.Add
{
    public interface IAddSallerUseCase
    {
        int Add(Domain.Saller.Saller saller);
    }
}
