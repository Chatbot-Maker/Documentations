using HTTPRequest.Models;
using HTTPRequest.Services;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace HTTPRequest.Controllers
{
    public class CheckCustomerExampleController : Controller
    {
        private SuriService _suriService {  get; set; }

        private readonly string IsCustomerFlowId = "cbXXXX";

        private readonly string IsNotCustomerFlowId = "cbYYYY";

        public CheckCustomerExampleController(SuriService suriService)
        {
            _suriService = suriService;
        }

        [HttpPost("customer/suri/check")]
        public async Task<IActionResult> CheckSuri([FromQuery] string userId, [FromBody] JsonDocument data)
        {
            var clientId = data.RootElement.GetProperty("clientId").ToString();
            var cnpj = data.RootElement.GetProperty("cnpj").ToString();

            FlowActionGoToFlow redirectResponse;
            if (!string.IsNullOrEmpty(userId) && !string.IsNullOrEmpty(clientId) && !string.IsNullOrEmpty(cnpj))
            {
                // TODO: call an external service to check this on a real database
                var customerName = "EMPRESA TESTE S.A.";
                
                // Use the SUri API to save a new variable on User.
                // The created variable named "Empresa" contains the customer name searched by CNPJ.
                var response = await _suriService.AddVariable(userId, "Empresa", customerName);

                redirectResponse = new FlowActionGoToFlow(response.Success ? IsCustomerFlowId : IsNotCustomerFlowId);
            }
            else
            {
                redirectResponse = new FlowActionGoToFlow(IsNotCustomerFlowId);
            }

            return Ok(redirectResponse);
        }

        [HttpPost("customer/check")]
        public async Task<IActionResult> Check([FromQuery] string userId, [FromBody] JsonDocument data)
        {
            var clientId = data.RootElement.GetProperty("clientId").ToString();
            var cnpj = data.RootElement.GetProperty("cnpj").ToString();

            if (!string.IsNullOrEmpty(userId) && !string.IsNullOrEmpty(clientId) && !string.IsNullOrEmpty(cnpj))
            {
                // TODO: call an external service to check this on a real database
                var customerName = "EMPRESA TESTE S.A.";

                // Use the SUri API to save a new variable on User.
                // The created variable named "Empresa" contains the customer name searched by CNPJ.
                await _suriService.AddVariable(userId, "Empresa", customerName);

                return Ok(new
                {
                    isClient = true,
                    enterpriseName = customerName
                });
            }
            
            return Ok(new
            {
                isClient = false
            });
        }
    }
}
