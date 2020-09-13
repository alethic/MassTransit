namespace Automatonymous
{
    using System.Threading.Tasks;


    public delegate Task<TMessage> AsyncEventMessageFactory<in TInstance, in TData, TMessage>(EventContext<TInstance, TData> context)
        where TData : class;


    public delegate Task<TMessage> AsyncEventMessageFactory<in TInstance, TMessage>(EventContext<TInstance> context);
}
