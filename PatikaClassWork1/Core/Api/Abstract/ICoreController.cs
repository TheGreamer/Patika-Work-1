using Microsoft.AspNetCore.Mvc;

namespace PatikaClassWork1.Core.Api.Abstract
{
    public interface ICoreController<TEntity, TCreateDto, TUpdateDto>
    {
        Task<List<TEntity>> GetAll();
        Task<ActionResult<TEntity>> Get(int? id);
        Task<ActionResult> Add([FromBody] TCreateDto createDto);
        Task<ActionResult> Update([FromBody] TUpdateDto updateDto);
        Task<ActionResult> Delete(int? id);
    }
}