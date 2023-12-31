﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass.Model
{
    [Table("Categories")]
    public class Categories
    {
        [Key]
        public int Id { get; set;  }

        [Required]
        [Display(Name="Tên loại")]
        public string Name { get; set; }

        [Display(Name = "Tên rút gọn")]

        public string Slug { get ; set; }

        [Display(Name = "Id cha")]

        public int? ParentId { get; set; }

        [Display(Name = "Sắp xếp")]

        public int? Order { get; set; }


        [Required]

        [Display(Name = "Mô tả")]

        public string MetaDesc { get; set; }

        [Required]

        [Display(Name = "Từ khóa")]

        public string MetaKey { get;  set; }

        [Display(Name = "Tạo bởi")]

        public int CreateBy { get; set; }

        [Display(Name = "Tạo lúc")]

        public DateTime CreateAt { get; set; }

        [Display(Name = "Cập nhật bởi")]

        public string UpdateBy { get; set; }

        [Display(Name = "Cập nhật lúc")]

        public DateTime UpdateAt { get; set; }

        [Display(Name = "Trạng thái")]

        public int Status { get; set; }




    }
}
