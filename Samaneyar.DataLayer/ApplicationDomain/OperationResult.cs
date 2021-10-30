namespace Samaneyar.DataLayer.ApplicationDomain
{
   public class OperationResult
    {
        public bool IsSucceeded { get; set; }
        public string Message { get; set; }

        public OperationResult()
        {
            IsSucceeded = false;
        }

        public OperationResult Succeeded(string message="اطلاعات شما با موفقیت انجام شد")
        {
            Message = message;
            IsSucceeded = true;
            return this;
        }

        public OperationResult Faild(string message)
        {
            Message = message;
            IsSucceeded = false;
            return this;
        }
    }
}
