using AutoMapper;
using Lancamentos.Api.Request;
using Lancamentos.Api.Response;
using Lancamentos.Domain.Interfaces.Service;
using Lancamentos.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lancamentos.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovimentacaoController : ControllerBase
    {
        private readonly IMovimentacaoService _service;
        private readonly IMapper _mapper;

        public MovimentacaoController(IMovimentacaoService service, IMapper mapper)
        {
            _service = service;
            this._mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> InsertAsync(InsereMovimentacaoRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var entity = _mapper.Map<Movimentacao>(request);

            await _service.InsertAsync(entity);

            var response = _mapper.Map<MovimentacaoResponse>(entity);

            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var list = await _service.GetAllAsync();

            var response = _mapper.Map<List<MovimentacaoResponse>>(list);

            return Ok(response);
        }
    }
}
