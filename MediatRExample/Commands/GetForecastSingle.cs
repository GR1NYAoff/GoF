using MediatR;

namespace MediatRExample.Commands
{
    public class GetForecastSingle: IRequest<WeatherForecast>
    {
    }
}
