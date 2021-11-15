using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicPipeline.Framework
{
    public class Pipeline<T> : IFilter<T> where T : class
    {
        private readonly LinkedList<IFilter<T>> _operations = new();
        
        public void SetNext(IFilter<T> next)
        {
            if (!_operations.Any())
            {
                _operations.AddLast(next);
            }
            else
            {
                _operations.Last().SetNext(next);
                _operations.AddLast(next);
            }
        }

        public async Task Invoke(T data)
        {
            var nextFilter = _operations.First?.Value;
            if (nextFilter != null)
            {
                await nextFilter.Invoke(data);
            }
        }
    }
}