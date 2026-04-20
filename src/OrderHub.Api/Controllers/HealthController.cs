using Microsoft.AspNetCore.Mvc;

namespace OrderHub.Api.Controllers;

[ApiController]
[Route("v1/[controller]")]
public class HealthController : ControllerBase
{
    /// <summary>
    /// Indica se o processo está vivo (não checa dependências).
    /// </summary>
    [HttpGet("live")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult Live()
        => Ok(new { status = "ok" });

    /// <summary>
    /// Readiness probe: indica se o serviço está pronto para receber tráfego.
    /// Inicialmente retorna OK; depois você conecta health checks de Postgres/Redis.
    /// </summary>
    [HttpGet("ready")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult Ready()
        => Ok(new { status = "ready" });
}
