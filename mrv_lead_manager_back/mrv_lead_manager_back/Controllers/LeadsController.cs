using Aplication.UseCases.Leads;
using Domain.Entities;
using Domain.Interfaces.Leads;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace mrv_lead_manager_back.Controllers
{
    [ApiController]
    [Route("leads")]
    public class LeadsController : ControllerBase
    {

        private IGetLeadsUseCase _LeadsUseCase;
        private IUpdateLeadUseCase _UpdateLeadUseCase;

        public LeadsController(IGetLeadsUseCase LeadsUseCase, IUpdateLeadUseCase UpdateLeadUseCase)
        {
            _LeadsUseCase = LeadsUseCase;
            _UpdateLeadUseCase = UpdateLeadUseCase;
        }

        [HttpGet("Getall")]
        public ActionResult<List<LeadsEntity>> Get()
        {
            try
            {
                var result = _LeadsUseCase.GetLeads();
                return Ok(result);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPut("Put")]
        public ActionResult Update([FromBody] LeadsEntity lead)
        {
            try
            {
                _UpdateLeadUseCase.UpdateLead(lead);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
