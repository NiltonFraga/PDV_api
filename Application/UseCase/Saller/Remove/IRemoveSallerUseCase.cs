using System;
using System.Collections.Generic;
using System.Text;

namespace Application.UseCase.Saller.Remove
{
    public interface IRemoveSallerUseCase
    {
        int Remove(Domain.Saller.Saller saller);
    }
}
