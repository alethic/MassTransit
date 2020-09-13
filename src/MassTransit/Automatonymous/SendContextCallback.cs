namespace Automatonymous
{
    using MassTransit;


    public delegate void SendContextCallback<in TInstance, in TData, in TMessage>(EventContext<TInstance, TData> context,
        SendContext<TMessage> sendContext)
        where TMessage : class
        where TData : class;


    public delegate void SendContextCallback<in TInstance, in TMessage>(EventContext<TInstance> context, SendContext<TMessage> sendContext)
        where TMessage : class;
}
