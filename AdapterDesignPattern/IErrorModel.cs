using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    public interface IErrorModel
    {
        int ErrorNumber { get; set; }
        string Description { get; set; }
        void SendMail();
    }
    public class DbError : IErrorModel
    {
        private int _errorNumber;
        private string _description;
        public int ErrorNumber
        {
            get
            {
                return _errorNumber;
            }
            set
            {
                _errorNumber = value;
            }
        }
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }

        public void SendMail()
        {
            Console.WriteLine("{0} - {1} => DbError is send",_errorNumber,_description);
        }
    }
    public class ServerError : IErrorModel
    {
        private int _errorNumber;
        private string _description;
        public int ErrorNumber
        {
            get
            {
                return _errorNumber;
            }
            set
            {
                _errorNumber = value;
            }
        }
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }

        public void SendMail()
        {
            Console.WriteLine("{0} - {1} => ServerError is send", _errorNumber, _description);
        }
    }

    public class FaxAdapter : IErrorModel
    {
        private Fax _fax;
        public FaxAdapter(Fax fax)
        {
            _fax = fax;
        }
        public int ErrorNumber 
        { 
            get
            {
                return _fax.FaxErrorCode;
            }
            set
            {
                _fax.FaxErrorCode = value;
            }
        }
        public string Description
        {
            get
            {
                return _fax.ErrorDescription;
            }
            set
            {
                _fax.ErrorDescription = value;
            }
        }
        public void SendMail()
        {
            Console.WriteLine("{0} {1} fax exception",ErrorNumber,Description);
        }
    }

    public class Fax
    {
        public int FaxErrorCode { get; set; }
        public string ErrorDescription { get; set; }

        void Send()
        {

        }
        void Get()
        {

        }
    }

}
