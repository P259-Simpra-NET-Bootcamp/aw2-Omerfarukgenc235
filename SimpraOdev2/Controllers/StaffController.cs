using BusinessLayer.Abstract;
using EntityLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SimpraOdev2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly IStaffService _staffService;

        public StaffController(IStaffService staffService)
        {
            _staffService = staffService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var deger = _staffService.GetList();
            return Ok(deger);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var deger = _staffService.GetByID(id);
            return Ok(deger);
        }
        [HttpPost]
        public IActionResult Post([FromBody] Staff staff)
        {
            bool result = _staffService.Add(staff);
            return Ok(result);
        }
        [HttpDelete]
        public IActionResult DeleteById(int id)
        {
            bool result = _staffService.Delete(id);
            return Ok(result);
        }
        [HttpPut]
        public IActionResult Update([FromBody] Staff staff)
        {
            bool result = _staffService.Update(staff);
            return Ok(result);
        }
    }
}
