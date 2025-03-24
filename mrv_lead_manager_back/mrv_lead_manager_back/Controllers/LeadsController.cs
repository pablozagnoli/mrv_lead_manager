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
        private IGetLeadsUseCase _GetLeadsUseCase;
        private IAcceptLeadUseCase _AcceptLeadUseCase;
        private IDeclineLeadUseCase _DeclineLeadUseCase;

        public LeadsController(IGetLeadsUseCase LeadsUseCase, IAcceptLeadUseCase UpdateLeadUseCase, IDeclineLeadUseCase declineLeadUseCase)
        {
            _GetLeadsUseCase = LeadsUseCase;
            _AcceptLeadUseCase = UpdateLeadUseCase;
            _DeclineLeadUseCase = declineLeadUseCase;
        }

        [HttpGet("Getall")]
        public async Task<ActionResult<List<LeadsEntity>>> GetAll()
        {
            try
            {
                var result = await _GetLeadsUseCase.GetLeadsAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                // Log the exception
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("Getall-invited")]
        public async Task<ActionResult<List<LeadsEntity>>> GetInvited()
        {
            try
            {
                var result = await _GetLeadsUseCase.GetInvitedAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                // Log the exception
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("Getall-accepted")]
        public async Task<ActionResult<List<LeadsEntity>>> GetAccepted()
        {
            try
            {
                var result = await _GetLeadsUseCase.GetAcceptedAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                // Log the exception
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("AcceptLead")]
        public async Task<ActionResult> AcceptLead([FromBody] LeadsEntity lead)
        {
            try
            {
                await _AcceptLeadUseCase.AcceptLeadAsync(lead);
                return Ok();
            }
            catch (Exception ex)
            {
                // Log the exception
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("DeclineLead")]
        public async Task<ActionResult> DeclineLead([FromBody] LeadsEntity lead)
        {
            try
            {
                await _DeclineLeadUseCase.DeclineLeadAsync(lead);
                return Ok();
            }
            catch (Exception ex)
            {
                // Log the exception
                return BadRequest(ex.Message);
            }
        }
    }

}
