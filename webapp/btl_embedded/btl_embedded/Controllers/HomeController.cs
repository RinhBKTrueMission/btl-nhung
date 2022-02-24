using btl_embedded.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace btl_embedded.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            // idUser = UserId;
            var lst = Data.MasterDB.MainDB.GetCollection("Patient").ToList<Patient>();
            return View(lst.ToArray());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpPost]
        public JsonResult Add(string ketqua)
        {
            var pat = JsonConvert.DeserializeObject<List<JsonObj>>(ketqua).ToArray();
            var pat1 = new Patient();
            pat1.firstName = pat[0].value;
            pat1.lastName = pat[1].value;
            pat1.CCCD = pat[2].value;
            pat1.gender = pat[3].value;
            pat1.birth = pat[4].value;
            pat1.phoneNumber = pat[5].value;
            pat1.beginDate = pat[6].value;
            pat1.address = pat[7].value;
            pat1.resultHeath = new List<heathcare>();
            pat1.resultHeath.Add(new heathcare() { getSampleDate = DateTime.Now.ToString(), nhip_tim = 0, nong_do_oxy = 0, than_nhiet = 0 });
            pat1.resultdates = new List<covidResult>();
            pat1.resultdates.Add(new covidResult() { getSampleDate = DateTime.Now.ToString(), result = false });
            var b = Data.MasterDB.MainDB.GetCollection("Patient").ToList<Patient>();
            var le = b.Count();
            var a = b.ToArray();
            var result = "null";
           
            if (a.Count() <= 0)
            {
                Data.MasterDB.MainDB.GetCollection("Patient").Insert(pat1.patientId, pat1);
                result = "Thêm bệnh nhân thành công";
                string Jkq = JsonConvert.SerializeObject(result);
                return Json(Jkq);
            }
            foreach (var x in a)
            {
                if (pat1.CCCD.Equals(x.CCCD))
                {
                    result = "Bệnh nhân đã có trong danh sách";
                    string z = JsonConvert.SerializeObject(result);
                    return Json(z);
                }
            }

            pat1.patientId = (a.Count() + 1).ToString();
            foreach (var y in a)
            {
                if (pat1.patientId.Equals(y.patientId))
                {
                    pat1.patientId = (int.Parse(a[le - 1].patientId) + 1).ToString();
                }
            }
            
            Data.MasterDB.MainDB.GetCollection("Patient").Insert(pat1.patientId, pat1);
            result = "Thêm bệnh nhân thành công";


            string Jnode = JsonConvert.SerializeObject(result);
            return Json(Jnode);
        }
        [HttpGet]
        public IActionResult Details(string id)
        {
            if (id == null)
            {
                id = HttpContext.Session.GetString("IdPatient");
            }
            var data = Data.MasterDB.MainDB.GetCollection("Patient").FindById<Patient>(id);
            HttpContext.Session.SetString("IdPatient", id);
            return View(data);
        }
       

    }



}
