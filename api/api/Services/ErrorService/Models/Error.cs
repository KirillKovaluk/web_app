namespace api.Services
{
    public class Error
    {
        public int Code { get; set; }
        public string ErrorName { get; set; }
        public Error() { }
        public Error(int code, string errorName) 
        {
            Code = code;
            ErrorName = errorName;
        }
    }
}
