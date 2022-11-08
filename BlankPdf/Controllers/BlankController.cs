using Microsoft.AspNetCore.Mvc;

namespace BlankPdf.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BlankController : ControllerBase
{
    [HttpPost]
    public async ValueTask<IActionResult> Post(IFormFile file)
    {
        await using var memoryStream = new MemoryStream();
        await file.CopyToAsync(memoryStream);
        bool result = Utility.IsBlankPdf(memoryStream);
        return Ok(result);
    }
}