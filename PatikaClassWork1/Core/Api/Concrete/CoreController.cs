using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PatikaClassWork1.Core.Api.Abstract;
using PatikaClassWork1.Core.Business.Abstract;
using PatikaClassWork1.Core.Dto.Abstract;
using PatikaClassWork1.Core.Entity.Concrete;
using PatikaClassWork1.Utilities;

namespace PatikaClassWork1.Core.Api.Concrete
{
    public class CoreController<TEntity, TDto, TService> : ControllerBase, ICoreController<TEntity, TDto>
        where TEntity : CoreEntity
        where TDto : ICoreDto
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
        public virtual async Task<ActionResult> Add([FromBody] TDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var entity = _mapper.Map<TEntity>(dto);
            await _service.Add(entity);
            return Ok(Message.ADDED);
        }

        [HttpPut]
        public virtual async Task<ActionResult> Update(int? id, [FromBody] TDto dto)
        {
            if (id == null)
                return BadRequest(Message.ID_NULL);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (_service.GetById((int)id) == null)
                return NotFound(Message.NOT_FOUND);

            var entity = _mapper.Map<TEntity>(dto);
            entity.Id = (int)id;
            await _service.Update(entity);

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