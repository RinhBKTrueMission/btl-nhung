using btl_embedded.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Threading;

namespace btl_embedded.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult ChangeURL(string img, string id)
        {
            var pat = JsonConvert.DeserializeObject<List<JsonObj>>(img).ToArray();
            var avt = pat[0].value;
            var pa = Data.MasterDB.MainDB.GetCollection("Patient").FindById<Models.Patient>(id);
            pa.urlAvt = avt;
            Data.MasterDB.MainDB.GetCollection("Patient").Update(pa);
            return Json(avt);
        }
        public IActionResult Statistics()
        {

            return View();
        }
        [HttpGet]
        public JsonResult thongke()
        {
            var lstpat = Data.MasterDB.MainDB.GetCollection("Patient").ToList<Patient>();
            var chart = new List<dataChart>();
            var pat_end = lstpat.ToArray()[lstpat.ToArray().Length - 1];
            var ti = DateTime.Parse(pat_end.beginDate);
            var v = new List<string>();
            if (ti.Day >= 7)
            {
                int c = ti.Day;
                for (int i = 0; i < 7; i++)
                {
                    var kq = ti.Year + "-" + ti.Month + "-" + c;
                    v.Add(kq);
                    c -= 1;
                }
            }
            else
            {
                int c = ti.Day;
                int t = ti.Month;
                for (int i = 0; i < 7; i++)
                {
                    if (c < 0)
                    {
                        if (ti.Month == 1)
                        {
                            c = 31;
                            t = 12;
                        }
                        else if ((ti.Month - 1) == 1 || (ti.Month - 1) == 3 || (ti.Month - 1) == 5 || (ti.Month - 1) == 7 || (ti.Month - 1) == 8 || (ti.Month - 1) == 10 || (ti.Month - 1) == 12)
                        {
                            c = 31;
                            t = ti.Month - 1;
                        }
                        else if ((ti.Month - 1) == 2)
                        {
                            if (ti.Year % 4 == 0)
                            {
                                c = 29;
                                t = 2;
                            }
                            else
                            {
                                c = 28;
                                t = 2;
                            }
                        }
                        else if ((ti.Month - 1) == 4 || (ti.Month - 1) == 6 || (ti.Month - 1) == 9 || (ti.Month - 1) == 11)
                        {
                            c = 30;
                            t = ti.Month - 1;
                        }

                    }
                    var kq = ti.Year + "-" + t + "-" + c;
                    v.Add(kq);
                    c -= 1;

                }



            }
            foreach (var x in v)
            {
                var c = new dataChart();
                c.time = x;
                chart.Add(c);
            }
            int[] a = new int[7];
            int[] b = new int[7];
            for (int i = 0; i < 7; i++)
            {
                a[i] = b[i] = 0;
            }
            foreach (var z in lstpat)
            {
                if (z.success == false)
                {
                    if (z.beginDate.Equals(v.ToArray()[0]))
                    {
                        a[0] += 1;
                    }
                    if (z.beginDate.Equals(v.ToArray()[1]))
                    {
                        a[1] += 1;
                    }
                    if (z.beginDate.Equals(v.ToArray()[2]))
                    {
                        a[2] += 1;
                    }
                    if (z.beginDate.Equals(v.ToArray()[3]))
                    {
                        a[3] += 1;
                    }
                    if (z.beginDate.Equals(v.ToArray()[4]))
                    {
                        a[4] += 1;
                    }
                    if (z.beginDate.Equals(v.ToArray()[5]))
                    {
                        a[5] += 1;
                    }
                    if (z.beginDate.Equals(v.ToArray()[6]))
                    {
                        a[6] += 1;
                    }
                }
                else
                {
                    if (z.het_benh.Equals(v.ToArray()[0]))
                    {
                        b[0] += 1;
                    }
                    if (z.het_benh.Equals(v.ToArray()[1]))
                    {
                        b[1] += 1;
                    }
                    if (z.het_benh.Equals(v.ToArray()[2]))
                    {
                        b[2] += 1;
                    }
                    if (z.het_benh.Equals(v.ToArray()[3]))
                    {
                        b[3] += 1;
                    }
                    if (z.het_benh.Equals(v.ToArray()[4]))
                    {
                        b[4] += 1;
                    }
                    if (z.het_benh.Equals(v.ToArray()[5]))
                    {
                        b[5] += 1;
                    }
                    if (z.het_benh.Equals(v.ToArray()[6]))
                    {
                        b[6] += 1;
                    }
                }

            }
            for (int i = 0; i < 7; i++)
            {
                chart.ToArray()[i].beginCovid = a[i];
                chart.ToArray()[i].end_Covid = b[i];
            }
            chart.Reverse();
            string Jchart = JsonConvert.SerializeObject(chart);
            return Json(Jchart);
        }
        public IActionResult Assess()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Account()
        {
            var userId = HttpContext.Session.GetString("UserId");
            var data = Data.MasterDB.MainDB.GetCollection("Account").FindById<Account>(userId);
            if (data == null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View(data);
        }
        [HttpPost]
        public JsonResult ChangeURL_AD(string img)
        {
            var Imgid = HttpContext.Session.GetString("UserId");
            var pat = JsonConvert.DeserializeObject<List<JsonObj>>(img).ToArray();
            var avt = pat[0].value;
            var pa = Data.MasterDB.MainDB.GetCollection("Account").FindById<Models.Account>(Imgid);
            pa.avt = avt;
            Data.MasterDB.MainDB.GetCollection("Account").Update(pa);
            return Json(avt);
        }
        [HttpPost]
        public IActionResult UpdateAcc(Account info)
        {

            var pat1 = Data.MasterDB.MainDB.GetCollection("Account").FindById<Account>(info.userName);
            if (pat1 != null)
            {
                pat1.firstName = info.firstName;
                pat1.lastName = info.lastName;
                pat1.userName = info.userName;
                pat1.passWord = info.passWord;
                pat1.Birth = info.Birth;
                pat1.Gender = info.Gender;
                pat1.Email = info.Email;
                pat1.phoneNumber = info.phoneNumber;
                pat1.duty = info.duty;
                pat1.Address = info.Address;
                pat1.AccId = info.userName;
                pat1.Id = info.userName;
                Data.MasterDB.MainDB.GetCollection("Account").Update(pat1);
            }

            return RedirectToAction("Account");
        }
        [HttpPost]
        public IActionResult updatePat(Patient info)
        {
            var id = HttpContext.Session.GetString("IdPatient");
            var up = Data.MasterDB.MainDB.GetCollection("Patient").FindById<Patient>(id);
            if (up != null)
            {
                up.address = info.address;
                up.beginDate = info.beginDate;
                up.phoneNumber = info.phoneNumber;
                Data.MasterDB.MainDB.GetCollection("Patient").Update(up);
            }
            return RedirectToAction("Details", "Home");
        }
        [HttpPost]
        public IActionResult ChangeReport(Patient rp)
        {
            var id = HttpContext.Session.GetString("IdPatient");
            var up = Data.MasterDB.MainDB.GetCollection("Patient").FindById<Patient>(id);

            if (up != null)
            {
                up.report = rp.report;
                Data.MasterDB.MainDB.GetCollection("Patient").Update(up);
            }
            return RedirectToAction("Details", "Home");
        }
        [HttpPost]
        public void SetData(string ketqua)
        {
            var kq = ketqua.Split('/');// id bệnh nhân/ thân nhiệt/ SpO2/BPM
            var get_time = DateTime.Now.ToString();
            var pa = Data.MasterDB.MainDB.GetCollection("Patient").FindById<Models.Patient>(kq[0]);
            if (pa != null)
            {
                var h = new heathcare();
                h.getSampleDate = get_time;
                h.than_nhiet = (int)float.Parse(kq[1]);
                h.nhip_tim = (int)float.Parse(kq[3]);
                h.nong_do_oxy = (int)float.Parse(kq[2]);
                pa.resultHeath.Add(h);
                var a = pa.resultHeath;
                //Thread t2 = new Thread(() => {
                //    Data.MasterDB.MainDB.GetCollection("Patient").Update(pa);
                //});
                //t2.Start();
                Data.MasterDB.MainDB.GetCollection("Patient").Update(pa);
            }


        }
    }
    public class dataChart
    {
        public int beginCovid { get; set; }
        public int end_Covid { get; set; }
        public string time { get; set; }
    }
}
