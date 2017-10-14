namespace GW2API.Common.Interfaces
{
    interface IRepository<Model, IdType> : IAllItemRepository<Model>, ISingleItemRepository<Model, IdType>, IIdRepository<IdType>, IMultipleItemRepository<Model, IdType> { }
}
