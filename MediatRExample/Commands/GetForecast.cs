using MediatR;

namespace MediatRExample.Commands
{
    public class GetForecast : IRequest<WeatherForecast[]>
    {
    }
}
