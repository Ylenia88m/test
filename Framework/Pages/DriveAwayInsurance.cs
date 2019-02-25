using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Pages
{
	public class DriveAwayInsurance
	{
        private static string inputTextXpath = ".//*[@id='vehicleReg']";
        private static string sendButton = ".//*[@id='page-container']/div[3]/form/button";
        public static string resultfield = ".//*[@id='page-container']/div[4]/div[1]";
        public static string noresultfield = ".//*[@id='page-container']/div[4]";
        public static string startdatefield = ".//*[@id='page-container']/div[4]/div[2]";
        public static string enddatefield = ".//*[@id='page-container']/div[4]/div[3]";
        public static string rederrormessage = ".//*[@id='page-container']/div[3]/form/div";

        public static string InputText()
        {
            string inputText = inputTextXpath;
            return inputText;

        }

        public static string SendRegistrationKeys()
        {
            string sendbutton = sendButton;
            return sendbutton;
        }

        public static string ReadResultField()
        {
            string resultfields = resultfield;
            return resultfields;
        }

        public static string ReadNoResultField()
        {
            string noresultfields = noresultfield;
            return noresultfields;
        }

        public static string ReadStartDate()
        {
            string startdate = startdatefield;
            return startdate;
        }

        public static string ReadEndtDate()
        {
            string enddate = enddatefield;
            return enddate;
        }


        public static string ReadredError()
        {
            string rederror = rederrormessage;
            return rederror;
        }
  



    }
}
