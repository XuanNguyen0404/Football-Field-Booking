using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
    public class FieldController : ControllerBase
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IStorageService _storageService;

        public FieldController(IUnitOfWork unitOfWork, IStorageService storageService)
        {
            _unitOfWork = unitOfWork;
            _storageService = storageService;
        }
        // GET: api/<FieldController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var listProduct = await _unitOfWork.Field.GetListFieldsWithSchedule();
            return Ok(listProduct);
        }

        // GET api/<FieldController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var product = await _unitOfWork.Field.Get(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        // POST api/<FieldController>
        [HttpPost]
        public async Task<IActionResult> Post([FromForm] FieldCreateRequest request)
        {
            var newField = new Field();

            if (request.Image != null)
            {
                newField.ImagePath = await _storageService.SaveFileAndCreateName(request.Image);
                newField.ImageName = request.ImageName ?? request.Name;
            }
            newField.Name = request.Name;
            newField.Address = request.Address;
            newField.Status = true;
            newField.UserForeignKey = request.UserForeignKey;
            newField.GroupFieldForeinKey = request.GroupFieldForeinKey;
            
            await _unitOfWork.Field.Add(newField);
            int status = _unitOfWork.Complete();
            if (status > 0)
            {
                return Ok();
            }
            return BadRequest();
        }

        // PUT api/<FieldController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] FieldUpdateRequest request)
        {
            var field = await _unitOfWork.Field.Get(id);
            if (field == null)
            {
                return NotFound();
            }
            if (request.Image != null)
            {
                await _storageService.DeleteFileAsync(field.ImagePath);
                field.ImageName = await _storageService.SaveFileAndCreateName(request.Image);
            }
            field.ImageName = request.ImageName ?? request.Name;
            field.Name = request.Name;
            field.Status = request.Status;
            field.Address = request.Address;
            field.UserForeignKey = request.UserForeignKey;
            field.GroupFieldForeinKey = request.GroupFieldForeinKey;
            _unitOfWork.Field.Update(field);
            int status = _unitOfWork.Complete();
            if (status > 0)
            {
                return Ok();
            }
            return BadRequest();
        }

        // DELETE api/<FieldController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var field = await _unitOfWork.Field.Get(id);
            if (field == null)
            {
                return NotFound();
            }
            _unitOfWork.Field.Delete(field);
            _unitOfWork.Complete();
            return Ok();
        }
    }
}
