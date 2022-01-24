using System;

namespace AdapterDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Fax fax = new Fax 
                { FaxErrorCode = 4000, ErrorDescription = "server is not found" };
            IErrorModel[] errors =
            {
                new DbError{ErrorNumber=1000,Description="Connection is timeout"},
                new DbError{ErrorNumber=1001,Description="Query Exception"},
                new ServerError{ErrorNumber=3000,Description="UnAuthorized"},
                new ServerError{ErrorNumber=3004,Description="Server is notfound"},
                new FaxAdapter(fax)
            };
            foreach (var error in errors)
            {
                error.SendMail();
            }
        }
    }
}
