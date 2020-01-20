using System;
using System.Collections.Generic;
using System.Text;

namespace Application.UseCase.Saller.GetById
{
    public interface IGetByIdSallerUseCase
    {
        Domain.Saller.Saller GetById(Guid id);
    }
}
