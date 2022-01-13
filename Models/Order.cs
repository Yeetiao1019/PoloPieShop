using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PoloPieShop.Models
{
    public class Order
    {
        [BindNever]
        public int OrderId { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

        [Required(ErrorMessage = "請輸入名子")]
        [Display(Name = "名子")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "請輸入姓氏")]
        [Display(Name = "姓氏")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "請輸入聯絡地址")]
        [StringLength(100)]
        [Display(Name = "聯絡地址 1")]
        public string AddressLine1 { get; set; }

        [Display(Name = "聯絡地址 2")]
        public string AddressLine2 { get; set; }

        [Required(ErrorMessage = "請輸入郵遞區號")]
        [Display(Name = "郵遞區號")]
        [StringLength(10, MinimumLength = 3)]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "請輸入縣市")]
        [StringLength(50)]
        public string City { get; set; }
        [StringLength(10)]
        public string State { get; set; }

        [Required(ErrorMessage = "請輸入國家")]
        [StringLength(50)]
        public string Country { get; set; }

        [Required(ErrorMessage = "請輸入聯絡電話")]
        [StringLength(25)]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "聯絡電話")]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])",
            ErrorMessage = "email 格式不正確")]
        public string Email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public decimal OrderTotal { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderPlaced { get; set; }
    }
}
