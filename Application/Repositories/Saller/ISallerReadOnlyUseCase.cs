using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Repositories.Saller
{
    public interface ISallerReadOnlyUseCase
    {
        List<Domain.Saller.Saller> GetAll();
        Domain.Saller.Saller GetById(Guid id);
    }
}
