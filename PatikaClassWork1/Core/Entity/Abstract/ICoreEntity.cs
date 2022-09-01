namespace PatikaClassWork1.Core.Entity.Abstract
{
    public interface ICoreEntity<TIdType>
    {
        TIdType Id { get; set; }
    }
}