using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.UseCase.Salesman.Add;
using Application.UseCase.Salesman.GetAll;
using Application.UseCase.Salesman.GetById;
using Application.UseCase.Salesman.Remove;
using Application.UseCase.Salesman.Update;
using Domain.Salesman;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PDV_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesmanController : ControllerBase
    {
        private readonly IAddSalesmanUseCase addSalesman;
        private readonly IGetAllSalesmanUseCase getAllSalesman;
        private readonly IGetByIdSalesmanUseCase getByIdSalesman;
        private readonly IRemoveSalesmanUseCase removeSalesman;
        private readonly IUpdateSalesmanUseCase updateSalesman;

        public SalesmanController(
            IAddSalesmanUseCase addSalesman, 
            IGetAllSalesmanUseCase getAllSalesman, 
            IGetByIdSalesmanUseCase getByIdSalesman, 
            IRemoveSalesmanUseCase removeSalesman, 
            IUpdateSalesmanUseCase updateSalesman)
        {
            this.addSalesman = addSalesman;
            this.getAllSalesman = getAllSalesman;
            this.getByIdSalesman = getByIdSalesman;
            this.removeSalesman = removeSalesman;
            this.updateSalesman = updateSalesman;
        }

        [HttpPost]
        [Route("CreateSalesman")]
        [ProducesResponseType(typeof(Guid), 200)]
        [ProducesResponseType(typeof(ProblemDetails), 400)]
        public IActionResult CreateSalesman(string name, string phone, string email)
        {
            var salesman = new Salesman(name, phone, email);

            addSalesman.Add(salesman);

            return new OkObjectResult(salesman);
        }

        [HttpPost]
        [Route("GetAllSalesman")]
        [ProducesResponseType(typeof(Guid), 200)]
        [ProducesResponseType(typeof(ProblemDetails), 400)]
        public IActionResult GetAllSalesman()
        {
            var salesman = getAllSalesman.GetAll();

            return new OkObjectResult(salesman);
        }

        [HttpPost]
        [Route("GetByIdSalesman")]
        [ProducesResponseType(typeof(Guid), 200)]
        [ProducesResponseType(typeof(ProblemDetails), 400)]
        public IActionResult GetByIdSalesman(Guid id)
        {
            var salesman = getByIdSalesman.GetById(id);

            return new OkObjectResult(salesman);
        }

        [HttpPut]
        [Route("UpdateSalesman")]
        [ProducesResponseType(typeof(Guid), 200)]
        [ProducesResponseType(typeof(ProblemDetails), 400)]
        public IActionResult UpdateSalesman(Guid id, string name, string phone, string email)
        {
            var salesman = new Salesman(id, name, phone, email);

            updateSalesman.Update(salesman);

            return new OkObjectResult(salesman);
        }

        [HttpDelete]
        [Route("RemoveSalesman")]
        [ProducesResponseType(typeof(Guid), 200)]
        [ProducesResponseType(typeof(ProblemDetails), 400)]
        public IActionResult RemoveSalesman(Guid id)
        {
            var salesman = new Salesman(id);

            removeSalesman.Remove(salesman);

            return new OkObjectResult(salesman);
        }

    }
}