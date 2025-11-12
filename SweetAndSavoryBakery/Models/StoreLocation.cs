using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SweetAndSavoryBakery.Models
{
    public class StoreLocation
    {
        public int Id { get; set; }

        // Tên chi nhánh (ví dụ: "Chi nhánh Thảo Điền")
        public string Name { get; set; }

        // Địa chỉ chi tiết
        public string Address { get; set; }

        // Số điện thoại liên hệ
        public string Phone { get; set; }

        // Giờ làm việc
        public string WorkingHours { get; set; }

        // Link Google Maps (dạng iframe hoặc URL)
        public string MapUrl { get; set; }
    }
}