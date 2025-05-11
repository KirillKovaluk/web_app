namespace api.Services
{
    public class ErrorService : IErrorService
    {
        public List<Error> Errors { get; set; }
        public ErrorService() 
        {
            Errors = new List<Error>();
        }
        public void Add(ErrorCode errorCode)
        {
            Errors.Add(new Error
            {
                Code = (int) errorCode,
                ErrorName = errorCode.ToString("G"),
            });
        }
        public bool HasErrors
        {
            get { return Errors.Any(); }
        }
    }
}
