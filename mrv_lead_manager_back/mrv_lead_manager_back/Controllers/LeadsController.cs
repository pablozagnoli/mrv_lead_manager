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

        /// <summary>
        /// get all leads 
        /// </summary>
        /// <returns></returns>
        [HttpGet("Getall")]
        public ActionResult<List<LeadsEntity>> GetAll()
        {
            try
            {
                var result = _GetLeadsUseCase.GetLeads();
                return Ok(result);
            }
            catch
            {
                return BadRequest();
            }
        }

        /// <summary>
        /// get all leads at invited
        /// </summary>
        /// <returns></returns>
        [HttpGet("Getall-invited")]
        public ActionResult<List<LeadsEntity>> GetInvited()
        {
            try
            {
                var result = _GetLeadsUseCase.GetInvited();
                return Ok(result);
            }
            catch
            {
                return BadRequest();
            }
        }

        /// <summary>
        /// get all leds at acceptet
        /// </summary>
        /// <returns></returns>
        [HttpGet("Getall-accepted")]
        public ActionResult<List<LeadsEntity>> GetAccepted()
        {
            try
            {
                var result = _GetLeadsUseCase.GetAccepted();
                return Ok(result);
            }
            catch
            {
                return BadRequest();
            }
        }

        /// <summary>
        /// alter lead at status accepted
        /// </summary>
        /// <param name="lead"></param>
        /// <returns></returns>
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

        /// <summary>
        /// alter lead at status declined
        /// </summary>
        /// <param name="lead"></param>
        /// <returns></returns>
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
