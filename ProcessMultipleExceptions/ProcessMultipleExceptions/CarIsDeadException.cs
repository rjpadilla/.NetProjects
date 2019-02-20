using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessMultipleExceptions
{
    class CarIsDeadException:ApplicationException
    {
        private string messageDetails = String.Empty;
        public DateTime ErrorTimeStamp { get; set; }
        public string CauseOfError { get; set; }

        public CarIsDeadException()
        {

        }
        //Feed message to parent constructor.
        public CarIsDeadException(string message, string cause, DateTime time):base(message)
        {
            CauseOfError = cause;
            ErrorTimeStamp = time;

        }

        //Override the Exception.Message property.
        //public override string Message
        //{
        //    get
        //    {
        //        return string.Format("Car Error Message: {0}", messageDetails);
        //    }
        //}


        

    }
}
