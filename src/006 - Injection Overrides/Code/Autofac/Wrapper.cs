namespace DiWalkthrough_006.Injection_Overrides.Code.Autofac
{
    public abstract class Wrapper
    {
        public Wrapper(object value)
        {
            Value = value;
        }

        public object Value
        {
            get;
        }
    }

    public class Wrapper<T> : Wrapper
    {
        public Wrapper(T value) : base(value)
        {
        }
    }
}