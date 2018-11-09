using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract
{
    public class Contracts
    {
        public static List<string> IllegalList = new List<string>() { "or", "||", "1=1", "where" };
    }
    public class HttpResponse
    {
        public ResponseState ResState { get; set; }

        public string ResMsg { get; set; }

        public string ResContent { get; set; }
    }

    public enum ResponseState
    {
        //服务器内部出错
        Error = 500,

        //调用失败
        Fail = 101,

        //调用成功
        Success = 200
    }

}
