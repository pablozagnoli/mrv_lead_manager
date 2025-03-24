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
        private IAcceptLeadUseCase _AcceptLeadUseCase;
        private IDeclineLeadUseCase _DeclineLeadUseCase;

        public LeadsController(IGetLeadsUseCase LeadsUseCase, IAcceptLeadUseCase UpdateLeadUseCase, IDeclineLeadUseCase declineLeadUseCase)
        {
            _LeadsUseCase = LeadsUseCase;
            _AcceptLeadUseCase = UpdateLeadUseCase;
            _DeclineLeadUseCase = declineLeadUseCase;
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
                _AcceptLeadUseCase.AcceptLead(lead);
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
                _DeclineLeadUseCase.DeclineLead(lead);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
