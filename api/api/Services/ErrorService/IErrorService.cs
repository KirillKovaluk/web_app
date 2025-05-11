namespace api.Services
{
    public interface IErrorService
    {
        void Add(ErrorCode errorCode);
        bool HasErrors { get; }
    }
}
