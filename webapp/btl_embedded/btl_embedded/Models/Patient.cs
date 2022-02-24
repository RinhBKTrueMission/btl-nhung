using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace btl_embedded.Models
{
    public class Patient:BsonData.Document
    {
        public string patientId { get; set; }//mã bệnh nhân
        public string CCCD { get; set; }// mã căn cước công dân
        public string firstName { get; set; }// tên bệnh nhân
        public string lastName { get; set; }// họ của bệnh nhân
        public string birth { get; set; }//ngày tháng năm sinh
        public string gender { get; set; }// giới tính
        public string phoneNumber { get; set; }// số điện thoại liên hệ
        public string address { get; set; }// địa chỉ liên hệ
        public string beginDate { get; set; }//ngày phát hiện dương tính covid-19
        public bool success { get; set; }//ngày phát hiện dương tính covid-19
        public string urlAvt { get; set; }// ảnh đại diện
        public List<covidResult> resultdates { get; set; }// danh sách kết quả lấy mẫu xét nghiệm
        public List<heathcare> resultHeath { get; set; }// danh sách chỉ số sức khỏe hằng ngày
        public string report { get; set; }// thông báo
        public string alert { get; set; }
        public string het_benh { get; set; }//thời gian công bố khỏi bệnh

    }

    public class covidResult:BsonData.Document
    {
        public string getSampleDate { get; set; }// ngày lấy mẫu xét nghiệm
        public bool result { get; set; }// kết quả xét nghiệm
    }
    public class heathcare:BsonData.Document
    {
        public string getSampleDate { get; set; }//thời điểm đo lấy kết quả
        public int nhip_tim { get; set; }// chỉ số nhịp tim
        public int nong_do_oxy { get; set; }// nồng độ oxy trong máu
        public int than_nhiet { get; set; }// nhiệt độ cơ thể
    }
}
