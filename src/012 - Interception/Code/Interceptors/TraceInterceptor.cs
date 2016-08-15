using System;
using System.Diagnostics;
using Castle.DynamicProxy;

namespace DiWalkthrough_012.Interception.Code.Interceptors
{
    public class TraceInterceptor : Castle.DynamicProxy.IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            Console.WriteLine($"START - {invocation.TargetType.Namespace}.{invocation.TargetType.Name}.{invocation.Method.Name}");

            invocation.Proceed();

            Console.WriteLine($"  END - {invocation.TargetType.Namespace}.{invocation.TargetType.Name}.{invocation.Method.Name} - Took: {stopwatch.ElapsedMilliseconds} milliseconds");
        }
    }
}