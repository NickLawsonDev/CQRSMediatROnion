using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRSMediatROnion.Presentation.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public abstract class BaseApiController : ControllerBase
{
    protected IMediator Mediator => HttpContext.RequestServices.GetRequiredService<IMediator>();
}