using System;
using System.Collections.Generic;

namespace Application.Repositories.Salesman
{
    public interface ISalesmanReadOnlyUseCase
    {
        List<Domain.Salesman.Salesman> GetAll();
        Domain.Salesman.Salesman GetById(Guid id);
    }
}
