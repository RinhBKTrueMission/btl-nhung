using btl_embedded.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace btl_embedded.Controllers
{
    public class LoginController : Controller
    {
        public string ACCOUNT_ID = null;
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public JsonResult LoginInfo(string checkId)
        {
            var arr = checkId.Split('&');
            var arrUser = arr[0].Split('=');
            var arrPass = arr[1].Split('=');
            var check = Data.MasterDB.MainDB.GetCollection("Account").FindById<Account>(arrUser[1]);
            if (check != null)
            {
                if (check.passWord != arrPass[1])
                {

                    string obj = "Enter the wrong password or username";
                    var kq = JsonConvert.SerializeObject(obj);
                    return Json(kq);
                }
                else
                {
                    if (check.avt == null)
                    {
                        HttpContext.Session.SetString("AvtUser", "");
                    }
                    else
                    {
                        HttpContext.Session.SetString("AvtUser", check.avt);
                    }
                    HttpContext.Session.SetString("UserId", arrUser[1]);

                    string obj1 =check.Id;
                    var kq1 = JsonConvert.SerializeObject(obj1);
                    return Json(kq1);
                }

            }
            else
            {
                string obj = "Enter the wrong password or username";
                var kq = JsonConvert.SerializeObject(obj);
                return Json(kq);
            }


            //return RedirectToRoute(new { action = "Index", controller = "Home", area = "" });
        }
        [HttpPost]
        public JsonResult SignUpFunc(string account)
        {
            var arr = account.Split('&');
            var newAcc = new Account();
            var arrUser = arr[0].Split('=');
            var arrPass = arr[1].Split('=');
            var arrEmail = arr[2].Split('=');
            newAcc.userName = arrUser[1];
            newAcc.passWord = arrEmail[1];
            newAcc.AccId = newAcc.userName;
            newAcc.Email = arrPass[1].Replace("%40", "@");
            // Data.MasterDB.MainDB.GetCollection("Account").Delete(newAcc.userName);
            var check = Data.MasterDB.MainDB.GetCollection("Account").FindById(newAcc.AccId);
            if (check != null)
            {
                string obj = "Account already exists";
                var kq = JsonConvert.SerializeObject(obj);
                return Json(kq);
            }
            else
            {
                Data.MasterDB.MainDB.GetCollection("Account").Insert(newAcc.AccId, newAcc);
                string obj = "Account successfully created";
                var kq = JsonConvert.SerializeObject(obj);
                return Json(kq);
            }

        }

    }
}
