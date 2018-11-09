using Contract;
using PwdEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Web.Http;

namespace PwdSerivce
{
    public class PwdController : ApiController
    {
       
    }

    public class LoginController : ApiController
    {
        [HttpGet]
        public HttpResponse GetLogin(string key)
        {
            var res = new HttpResponse();
            try
            {
                //过滤非法字符
                string illegalStr = Contracts.IllegalList.Where(p => key.Contains(p)).FirstOrDefault();
                if (illegalStr != null)
                {
                    res.ResState = ResponseState.Fail;
                    res.ResMsg = "调用失败";
                    res.ResContent = "请求的Key含有非法字符";
                }
                else
                {
                    using (PwdSystemCenterEntities ctx = new PwdSystemCenterEntities())
                    {
                        var item = ctx.Managers.Where(p => p.LoginKey == key).FirstOrDefault();
                        if (item != null)
                        {
                            res.ResState = ResponseState.Success;
                            res.ResMsg = "调用成功";
                            res.ResContent = JsonConvert.SerializeObject(item);
                        }
                        else
                        {
                            res.ResState = ResponseState.Fail;
                            res.ResMsg = "调用失败";
                            res.ResContent = "错误的请求Key";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                res.ResState = ResponseState.Error;
                res.ResMsg = "服务器出错了";
                res.ResContent = ex.Message;
            }
            return res;
        }
    }
}
