using Serilog;

namespace Grid.Util;

public interface ILogTransform<T> where T:ILogTransform<T>
{
    object AddTransform(T value);
}