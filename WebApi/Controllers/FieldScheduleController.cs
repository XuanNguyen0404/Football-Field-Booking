using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Bussiness.DTO;
using WebApi.Bussiness.IServices;
using WebApi.Data.Entites;
using WebApi.Data.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FieldScheduleController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStorageService _storageService;


        public FieldScheduleController(IUnitOfWork unitOfWork, IStorageService storageService)
        {
            _unitOfWork = unitOfWork;
            _storageService = storageService;
        }

        [HttpGet("ScheduleAvailable/{id}")]
        public async Task<IActionResult> GetSchedule(int id, DateTime bookingDate)
        {
            var listTime = await _unitOfWork.FieldSchedule.GetScheduleAvailable(id, bookingDate);
            return Ok(listTime);
        }
        // GET: api/<FieldScheduleController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var listProduct = await _unitOfWork.FieldSchedule.GetAll();
            return Ok(listProduct);
        }
        [HttpGet("field/{id}")]
        public async Task<IActionResult> GetSchedule(int id)
        {
            var listProduct = await _unitOfWork.FieldSchedule.GetFieldScheduleIdByFieldId(id);
            return Ok(listProduct);
        }

        // GET api/<FieldScheduleController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var product = await _unitOfWork.FieldSchedule.Get(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        // POST api/<FieldScheduleController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] FieldScheduleCreateRequest request)
        {
            var newSchedule = new FieldSchedule();
            newSchedule.TimeStart = request.TimeStart;
            newSchedule.TimeEnd = request.TimeEnd;
            newSchedule.Status = true;
            newSchedule.Price = request.Price;
            newSchedule.FieldForeignKey = request.FieldForeignKey;

            await _unitOfWork.FieldSchedule.Add(newSchedule);
            int status = _unitOfWork.Complete();
            if (status > 0)
            {
                return Ok();
            }
            return BadRequest();
        }

        // PUT api/<FieldScheduleController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] FieldScheduleUpdateRequest request)
        {
            var scheduleUpdate = await _unitOfWork.FieldSchedule.Get(id);
            if (scheduleUpdate == null)
            {
                return NotFound();
            }
            scheduleUpdate.TimeStart = request.TimeStart;
            scheduleUpdate.TimeEnd = request.TimeEnd;
            scheduleUpdate.Status = true;
            scheduleUpdate.Price = request.Price;
            scheduleUpdate.FieldForeignKey = request.FieldForeignKey;

            _unitOfWork.FieldSchedule.Update(scheduleUpdate);
            int status = _unitOfWork.Complete();
            if (status > 0)
            {
                return Ok();
            }
            return BadRequest();
        }

        // DELETE api/<FieldScheduleController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var schedule = await _unitOfWork.FieldSchedule.Get(id);
            if (schedule == null)
            {
                return NotFound();
            }
            _unitOfWork.FieldSchedule.Delete(schedule);
            _unitOfWork.Complete();
            return Ok();
        }
    }
}
