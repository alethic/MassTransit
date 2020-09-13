namespace Automatonymous
{
    using System;


    /// <summary>
    /// Provides an address for the request service
    /// </summary>
    /// <typeparam name="TInstance"></typeparam>
    /// <param name="context"></param>
    /// <returns></returns>
    public delegate Uri ServiceAddressProvider<in TInstance>(EventContext<TInstance> context);


    /// <summary>
    /// Provides an address for the request service
    /// </summary>
    /// <typeparam name="TInstance"></typeparam>
    /// <typeparam name="TData"></typeparam>
    /// <param name="context"></param>
    /// <returns></returns>
    public delegate Uri ServiceAddressProvider<in TInstance, in TData>(EventContext<TInstance, TData> context)
        where TData : class;
}
