using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Autofac;
using Autofac.Builder;
using Autofac.Core;

namespace DiWalkthrough_006.Injection_Overrides.Code.Autofac
{
    internal static class PropertyInjectorLogic
    {
        public static IRegistrationBuilder<TImplementer, ConcreteReflectionActivatorData, SingleRegistrationStyle> WithProperties<TImplementer>(this IRegistrationBuilder<TImplementer, ConcreteReflectionActivatorData, SingleRegistrationStyle> builder)
        {
            return builder.OnActivating(e =>
            {
                InjectProperties(e.Context, e.Instance, e.Parameters);
            }

            );
        }

        public static void AllowProperties(this ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterGeneric(typeof (Wrapper<>));
        }

        public static void InjectProperties(IComponentContext context, object instance, IEnumerable<Parameter> parameters)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));
            if (instance == null)
                throw new ArgumentNullException(nameof(instance));
            Type instanceType = instance.GetType();
            foreach (var property in instanceType.GetTypeInfo().DeclaredProperties.Where(pi => pi.CanWrite))
            {
                var propertyType = property.PropertyType;
                if (propertyType.GetTypeInfo().IsValueType && !propertyType.GetTypeInfo().IsEnum)
                    continue;
                if (propertyType.IsArray && propertyType.GetElementType().GetTypeInfo().IsValueType)
                    continue;
                if (property.GetIndexParameters().Length != 0)
                    continue;
                if (!context.IsRegistered(propertyType))
                    continue;
                if (!property.SetMethod.IsPublic)
                    continue;
                Wrapper wrapper = (Wrapper)context.Resolve(typeof (Wrapper<>).MakeGenericType(property.PropertyType), parameters);
                property.SetValue(instance, wrapper.Value, null);
            }
        }
    }
}