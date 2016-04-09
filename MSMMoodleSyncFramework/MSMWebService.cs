
using System;
using System.IO;
using System.Net;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MSMMoodleSyncFramework
{

    public class MSMWebService
    {

        #region Public Constructors 

        public MSMWebService():base()
        {

        }

        public MSMWebService(string sURL, string sAuthToken, string sAction)
        {
            this.AuthToken = sAuthToken;
            this.ServiceURL = sURL;
            this.ActionMethod = sAction;
        }

        #endregion  

        #region Public Properties

        public string ServiceURL { get; set; }
        public string AuthToken { get; set; }
        public string ActionMethod { get; set; }
        public string JSON { get; internal set; }
        public string WriteResponse { get; internal set; }
        public Exception ServiceException { get; private set; }

        #endregion

        #region Public Methods 

        public bool ReadService()
        {

            HttpWebRequest objWRequest = null;
            HttpWebResponse objWResponse = null;
            Stream objStream = null;
            StreamReader objSReader = null;

            bool blnResult = false;

            try
            {

                this.ServiceException = new Exception();

                objWRequest = (HttpWebRequest)WebRequest.Create(this.ServiceURL);
                objWRequest.Method = this.ActionMethod; //PUT/POST/GET/DELETE

                if (!this.AuthToken.Trim().Equals(string.Empty))
                    objWRequest.Headers.Add("auth_token", this.AuthToken);

                objWRequest.ContentLength = 0;

                objWResponse = (HttpWebResponse)objWRequest.GetResponse();
                objStream = objWResponse.GetResponseStream();
                objSReader = new StreamReader(objStream);

                this.JSON = objSReader.ReadToEnd();

                objWResponse.Close();
                objStream.Close();
                objSReader.Close();

                blnResult = true;

            }
            catch (Exception ex)
            {
                this.ServiceException = ex;
            }

            return blnResult;

        }

        public bool WriteService()
        {

            StreamWriter objWriter;
            HttpWebRequest objRequest;
            HttpWebResponse objResponse;
            StreamReader objReader;

            string strOutValue = string.Empty;
            bool blnResult = false;

            try
            {

                if (this.JSON.Length > 0)
                {
                    // Write the Service

                    this.ServiceException = new Exception();

                    objRequest = (HttpWebRequest)WebRequest.Create(this.ServiceURL);
                    objRequest.ContentType = "application/json; charset=utf-8";
                    objRequest.Method = this.ActionMethod;

                    if (!this.AuthToken.Trim().Equals(string.Empty))
                        objRequest.Headers.Add("auth_token", this.AuthToken);

                    objWriter = new StreamWriter(objRequest.GetRequestStream());

                    objWriter.Write(this.JSON);
                    objWriter.Flush();

                    objResponse = (HttpWebResponse)objRequest.GetResponse();

                    objReader = new StreamReader(objResponse.GetResponseStream());
                    this.WriteResponse = objReader.ReadToEnd();

                    blnResult = true;

                }

            }
            catch (Exception ex)
            {
                this.ServiceException = ex;
            }

            return blnResult;

        }

        #endregion

    }

}
