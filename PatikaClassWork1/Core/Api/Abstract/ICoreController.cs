using Microsoft.AspNetCore.Mvc;
using PatikaClassWork1.Core.Dto.Abstract;
using PatikaClassWork1.Core.Entity.Concrete;

namespace PatikaClassWork1.Core.Api.Abstract
{
    public interface ICoreController<TEntity, TDto>
        where TEntity : CoreEntity
        where TDto : ICoreDto
    {
        Task<List<TEntity>> GetAll();
        Task<ActionResult<TEntity>> Get(int? id);
        Task<ActionResult> Add([FromBody] TDto dto);
        Task<ActionResult> Update(int? id, [FromBody] TDto dto);
        Task<ActionResult> Delete(int? id);
    }
}