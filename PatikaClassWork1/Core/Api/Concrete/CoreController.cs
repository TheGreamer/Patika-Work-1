using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PatikaClassWork1.Core.Api.Abstract;
using PatikaClassWork1.Core.Business.Abstract;
using PatikaClassWork1.Core.Dto.Abstract;
using PatikaClassWork1.Core.Entity.Concrete;
using PatikaClassWork1.Utilities;

namespace PatikaClassWork1.Core.Api.Concrete
{
    public class CoreController<TEntity, TCreateDto, TUpdateDto, TService> : ControllerBase, ICoreController<TEntity, TCreateDto, TUpdateDto>
        where TEntity : CoreEntity
        where TCreateDto : ICoreCreateDto
        where TUpdateDto : ICoreUpdateDto
        where TService : IService<TEntity>
    {
        private readonly TService _service;
        private readonly IMapper _mapper;

        public CoreController(TService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public virtual async Task<List<TEntity>> GetAll()
        {
            return await _service.GetAll();
        }

        [HttpGet("{id}")]
        public virtual async Task<ActionResult<TEntity>> Get(int? id)
        {
            if (id == null)
                return BadRequest(Message.ID_NULL);

            var entity = await _service.GetById((int)id);

            if (entity == null)
                return NotFound(Message.NOT_FOUND);

            return Ok(entity);
        }

        [HttpPost]
        public virtual async Task<ActionResult> Add([FromBody] TCreateDto createDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _service.Add(_mapper.Map<TEntity>(createDto));
            return Ok(Message.ADDED);
        }

        [HttpPut]
        public virtual async Task<ActionResult> Update([FromBody] TUpdateDto updateDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (_service.GetById(updateDto.Id) == null)
                return NotFound(Message.NOT_FOUND);

            await _service.Update(_mapper.Map<TEntity>(updateDto));
            return Ok(Message.UPDATED);
        }

        [HttpDelete]
        public virtual async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
                return BadRequest(Message.ID_NULL);

            var entity = await _service.GetById((int)id);

            if (entity == null)
                return NotFound(Message.NOT_FOUND);

            await _service.Delete(entity);
            return Ok(Message.DELETED);
        }
    }
}