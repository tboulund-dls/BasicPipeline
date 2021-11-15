using System.Threading.Tasks;

namespace BasicPipeline.Framework
{
    public interface IFilter<T> where T : class
    {
        void SetNext(IFilter<T> next);
        Task Invoke(T input);
    }
}