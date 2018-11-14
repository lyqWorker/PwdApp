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
        [HttpPost]
        public HttpResponse AddPwdList([FromBody]PwdInfo pwd)
        {
            var res = new HttpResponse();
            try
            {
                if (pwd != null)
                {
                    using (PwdSystemCenterEntities ctx = new PwdSystemCenterEntities())
                    {
                        PwdList thePwd = new PwdList();
                        thePwd.Title = pwd.Title;
                        thePwd.CreateUser = pwd.CreateUser;
                        thePwd.Description = pwd.Description;
                        thePwd.SecrecyLevel = pwd.SecrecyLevel;
                        thePwd.Category = pwd.Category;
                        ctx.PwdLists.Add(thePwd);
                        ctx.SaveChanges();

                        res.ResState = ResponseState.Success;
                        res.ResMsg = "调用成功";
                        res.ResContent = "保存成功";
                    }
                }
                else
                {
                    res.ResState = ResponseState.Fail;
                    res.ResMsg = "调用失败";
                    res.ResContent = "空的提交结果";
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

        [HttpGet]
        public List<PwdList> GetPwdList(string userId)
        {
            var pwdList = new List<PwdList>();
            using (PwdSystemCenterEntities ctx = new PwdSystemCenterEntities())
            {
                pwdList = ctx.PwdLists.Where(p => p.CreateUser == userId).ToList();
            }
            return pwdList;
        }
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
                            res.ResContent = item.UserId;
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
