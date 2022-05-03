using MediatR;
using MediatRExample.Commands;
using Microsoft.AspNetCore.Mvc;

namespace MediatRExample.Controllers
{
    [ApiController]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IMediator mediator;

        public WeatherForecastController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        [Route("all")]
        public async Task<IEnumerable<WeatherForecast>> Get()
        {
            var command = new GetForecast();
            return await mediator.Send(command).ConfigureAwait(false);
        }

        [HttpGet]
        [Route("single")]
        public async Task<WeatherForecast> GetSingle()
        {
            var command = new GetForecastSingle();
            return await mediator.Send(command).ConfigureAwait(false);
        }
    }
}