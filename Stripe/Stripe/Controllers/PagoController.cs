using Microsoft.AspNetCore.Mvc;
using Stripe;

namespace Stripe.Controllers
{
    [ApiController]
    [Route("api/pago")]
    public class PagoController : ControllerBase
    {
        [HttpPost]
        public IActionResult CrearPago([FromBody] PaymentRequest request)
        {
            var options = new ChargeCreateOptions
            {
                Amount = request.Monto, // ya viene en centavos desde el cliente
                Currency = "mxn",
                Description = request.Descripcion,
                Source = request.Token, // token del frontend
            };

            var service = new ChargeService();
            var charge = service.Create(options);

            return Ok(charge);
        }
    }

    public class PaymentRequest
    {
        public int Monto { get; set; }
        public string Descripcion { get; set; }
        public string Token { get; set; }
    }
}
