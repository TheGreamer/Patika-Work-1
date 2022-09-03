using Microsoft.AspNetCore.Mvc;

namespace PatikaClassWork1.Core.Api.Abstract
{
    public interface ICoreController<TEntity, TDto>
    {
        Task<List<TEntity>> GetAll();
        Task<ActionResult<TEntity>> Get(int? id);
        Task<ActionResult> Add([FromBody] TDto dto);
        Task<ActionResult> Update(int? id, [FromBody] TDto dto);
        Task<ActionResult> Delete(int? id);
    }
}