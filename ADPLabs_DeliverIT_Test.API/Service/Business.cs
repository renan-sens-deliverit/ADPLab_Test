using ADPLabs_DeliverIT_Test.API.Controllers;
using ADPLabs_DeliverIT_Test.API.EF;
using ADPLabs_DeliverIT_Test.API.Model;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http.Headers;
using System.Text;

namespace ADPLabs_DeliverIT_Test.API.Service
{
    public class Business
    {
        public Business(){}
        public RequestPostCalc MakeCalcAndResult(CalcTask calcTask)
        {
            
            RequestPostCalc? requestPost = null;
            try
            {
                    //Make the operation
                    requestPost = new RequestPostCalc();
                    requestPost.id = calcTask.ID;

                    switch (calcTask.Operation.ToLower())
                    {
                        case "subtraction":
                            requestPost.result = calcTask.Left - calcTask.Right;
                            break;
                        case "multiplication":
                            requestPost.result = calcTask.Left * calcTask.Right;
                            break;
                        case "division":
                            requestPost.result = calcTask.Left / calcTask.Right;
                            break;
                        case "addition":
                            requestPost.result = calcTask.Left + calcTask.Right;
                            break;
                        case "remainder":
                            requestPost.result = calcTask.Left % calcTask.Right;
                            break;
                    }

            }
            catch (Exception)
            {
                throw;
            }
            return requestPost;
        }

    }
}
