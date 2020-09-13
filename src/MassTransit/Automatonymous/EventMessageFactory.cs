namespace Automatonymous
{
    public delegate TMessage EventMessageFactory<in TInstance, out TMessage>(EventContext<TInstance> context);


    public delegate TMessage EventMessageFactory<in TInstance, in TData, out TMessage>(EventContext<TInstance, TData> context)
        where TData : class;
}
