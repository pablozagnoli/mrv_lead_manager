using Aplication.UseCases.Leads;
using Domain.Entities;
using Domain.Interfaces.Leads.UseCases;
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
        public ActionResult<List<LeadsEntity>> GetAll()
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

        [HttpGet("Getall-invited")]
        public ActionResult<List<LeadsEntity>> GetInvited()
        {
            try
            {
                var result = _LeadsUseCase.GetInvited();
                return Ok(result);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet("Getall-accepted")]
        public ActionResult<List<LeadsEntity>> GetAccepted()
        {
            try
            {
                var result = _LeadsUseCase.GetAccepted();
                return Ok(result);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPut("AcceptLead")]
        public ActionResult AcceptLead([FromBody] LeadsEntity lead)
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

        [HttpPut("DeclineLead")]
        public ActionResult DeclineLead([FromBody] LeadsEntity lead)
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
