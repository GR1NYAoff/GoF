using MediatR;
using MediatRExample.Commands;

namespace MediatRExample.Handlers
{
    public class GetForecastHandler :
        IRequestHandler<GetForecast, WeatherForecast[]>,
        IRequestHandler<GetForecastSingle, WeatherForecast>
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<WeatherForecast[]> Handle(GetForecast request, CancellationToken cancellationToken)
        {
            var result = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();

            return Task.FromResult(result);
        }

        public Task<WeatherForecast> Handle(GetForecastSingle request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new WeatherForecast
            {
                Date = DateTime.Now.AddDays(1),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            });
        }
    }
}
