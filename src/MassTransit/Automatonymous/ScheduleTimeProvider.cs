namespace Automatonymous
{
    using System;


    public delegate DateTime ScheduleTimeProvider<in TInstance>(EventContext<TInstance> context);


    public delegate DateTime ScheduleTimeProvider<in TInstance, in TData>(EventContext<TInstance, TData> context)
        where TData : class;
}
