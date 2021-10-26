using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace BTL_QLCHTT.Models.Process
{
    public class StringProcess
    {
        private object numPart;
        private object strPart;

        public object autoGenerateKey(string strInput)
        {
            //khai bao bien
            string strResult = "", numPart, strPart;
            int intPart;
            //strIput = PER001
            //tach phan so
            numPart = Regex.Match(strInput, @"\d+").Value;
            // tach phan chu
            strPart  = Regex.Match(strInput, @"\D+").Value;
            // chuyen phan so sang kieu int va tang len 1 don vi
            intPart = Convert.ToInt32(numPart) + 1;
            // bo sung ki tu 0 vao phan so cho du chieu dai
            // ket hop phan so voi phan chu de tra ve ma dong sinh
            return strResult;
        }

    }
}