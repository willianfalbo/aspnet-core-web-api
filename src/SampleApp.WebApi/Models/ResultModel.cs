
namespace SampleApp.WebApi.Models
{
    public class ResultModel<T>
    {
        public ResultModel(T result, bool hasError = true)
        {
            this.Result = result;
            this.HasError = hasError;
        }

        public T Result { get; private set; }
        public bool HasError { get; private set; } = true;
    }
}
