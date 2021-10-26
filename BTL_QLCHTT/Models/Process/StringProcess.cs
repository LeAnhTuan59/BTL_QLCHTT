using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace BTL_QLCH.Models.Process
{
    public class StringProcess
    {
        public string AutoGenerateKey(string strInput)
        {
            string strResult = "", numPart, strPart;
            int intPart;
            numPart = Regex.Match(strInput, @"\d+").Value;
            intPart = Convert.ToInt32(numPart) + 1;
            strPart = Regex.Match(strInput, @"\D+").Value;
            strResult = strPart + intPart;
            return strResult;
        }
    }
}