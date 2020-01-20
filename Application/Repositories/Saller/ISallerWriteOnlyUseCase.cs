using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Repositories.Saller
{
    public interface ISallerWriteOnlyUseCase
    {
        int Add(Domain.Saller.Saller saller);
        int Remove(Domain.Saller.Saller saller);
        int Update(Domain.Saller.Saller saller);
    }
}
