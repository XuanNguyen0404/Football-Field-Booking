using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebApi.Bussiness.DTO;
using WebApi.Bussiness.IServices;
using WebApi.Bussiness.Services;
using WebApi.Data.Entites;
using WebApi.Data.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupFieldController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStorageService _storageService;
        private readonly IUserService _userService;

        public GroupFieldController(IUnitOfWork unitOfWork, IStorageService storageService, IUserService userService)
        {
            _unitOfWork = unitOfWork;
            _storageService = storageService;
            _userService = userService;
        }
        // GET: api/<GroupFieldController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var listProduct = await _unitOfWork.GroupField.GetAll();
            return Ok(listProduct);
        }

        [HttpGet("GroupFieldWithField")]
        public async Task<IActionResult> GetGroupFieldWithFields()
        {
            var listProduct = await _unitOfWork.GroupField.GetAllGroupFields();
            return Ok(listProduct);
        }

        [HttpGet("Search/Name/{name}")]
        public async Task<IActionResult> SearchGroupFieldByName(string name="")
        {
            var listProduct = await _unitOfWork.GroupField.GetGroupFieldsByName(name);
            return Ok(listProduct);
        }

        [HttpGet("Search/TypeField/{typeField}")]
        public async Task<IActionResult> SearchGroupFieldByTypeField(int typeField)
        {
            var listProduct = await _unitOfWork.GroupField.GetGroupFieldsByTypeField(typeField, 1, 10);

            return Ok(listProduct);
        }

        // GET api/<GroupFieldController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var product = await _unitOfWork.GroupField.Get(id);
            if(product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpGet("GroupFieldWithField/{id}")]
        public async Task<IActionResult> GetGroupWithField(int id)
        {
            var product = await _unitOfWork.GroupField.GetGroupFieldsById(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        // POST api/<GroupFieldController>
        [HttpPost]
        public async Task<IActionResult> Post([FromForm] GroupFieldCreateRequest  request)
        {
            var newGroupField = new GroupField();

            if (request.Image != null)
            {
                newGroupField.ImagePath = await _storageService.SaveFileAndCreateName(request.Image);
                newGroupField.ImageName = request.ImageName ?? request.Name;
            }
            newGroupField.Name = request.Name;
            newGroupField.Status = true;
            newGroupField.CreatedAt = System.DateTime.Now;
            newGroupField.Description = request.Description;
            newGroupField.UserForeignKey = request.UserForeignKey;
            newGroupField.Address = request.Address;

            await _unitOfWork.GroupField.Add(newGroupField);
            int status =  _unitOfWork.Complete();
            if (status>0)
            {
                return Ok();
            }
            return BadRequest();
        }

        // PUT api/<GroupFieldController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromForm] GroupFieldCreateRequest request)
        {
            var groupField = await _unitOfWork.GroupField.Get(id);
            if(groupField == null)
            {
                return NotFound();
            }
            if(request.Image != null)
            {
                await _storageService.DeleteFileAsync(groupField.ImagePath);
                groupField.ImageName = await _storageService.SaveFileAndCreateName(request.Image);
            }
            groupField.ImageName = request.ImageName?? request.Name;
            groupField.Name = request.Name;
            groupField.Status = request.Status;
            groupField.Description = request.Description;
            groupField.Address = request.Address;

            _unitOfWork.GroupField.Update(groupField);
            int status = _unitOfWork.Complete();
            if (status > 0)
            {
                return Ok();
            }
            return BadRequest();
        }

        // DELETE api/<GroupFieldController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var groupField = await _unitOfWork.GroupField.Get(id);
            if(groupField == null)
            {
                return NotFound();
            }

            _unitOfWork.GroupField.Delete(groupField);
            _unitOfWork.Complete();
            return Ok();
        }
    }
}
