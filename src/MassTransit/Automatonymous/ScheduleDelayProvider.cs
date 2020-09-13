namespace Automatonymous
{
    using System;


    public delegate TimeSpan ScheduleDelayProvider<in TInstance>(EventContext<TInstance> context);


    public delegate TimeSpan ScheduleDelayProvider<in TInstance, in TData>(EventContext<TInstance, TData> context)
        where TData : class;
}
