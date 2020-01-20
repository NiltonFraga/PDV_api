using System;
using System.Collections.Generic;
using System.Text;

namespace Application.UseCase.Saller.Update
{
    public interface IUpdateSallerUseCase
    {
        int Update(Domain.Saller.Saller saller);
    }
}
