using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class CryptoController : ControllerBase
{
    private readonly ICryptoService _cryptoService;

    public CryptoController(ICryptoService cryptoService)
    {
        _cryptoService = cryptoService;
    }

    [HttpPost("encrypt")]
    public IActionResult Encrypt([FromBody] CryptoRequest request)
    {
        var encryptedText = _cryptoService.Encrypt(request.Text);
        return Ok(new { encrypted = encryptedText });
    }

    [HttpPost("decrypt")]
    public IActionResult Decrypt([FromBody] CryptoRequest request)
    {
        var decryptedText = _cryptoService.Decrypt(request.Text);
        return Ok(new { decrypted = decryptedText });
    }
}
