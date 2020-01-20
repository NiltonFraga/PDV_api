using System;
using System.Collections.Generic;
using System.Text;

namespace Application.UseCase.Saller.GetAll
{
    public interface IGetAllSallerUseCase
    {
        List<Domain.Saller.Saller> GetAll();
    }
}
