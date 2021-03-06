using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace coreDemo.Entity
{
    /// <summary>
    /// 學生
    /// </summary>
    ///
    [Table("Student")]
    public partial class Student
    {

        public static Student SetClass(Student student, ClassM classM) {
            student.ClassM = classM;
            return student;
        }

        /// <summary>
        /// 流水號
        /// </summary>
        [Display(Name = "流水號")]
        [Key]
        public int Sn{ get; set; }

        /// <summary>
        /// 名子
        /// </summary>
        [Display(Name = "名子")]
        public string Name{ get; set; }

        /// <summary>
        /// 身高
        /// </summary>
        [Display(Name = "身高")]
        public int Hight{ get; set; }

        /// <summary>
        /// 體重
        /// </summary>
        [Display(Name = "體重")]
        public double Weight{ get; set; }

        /// <summary>
        /// 生日
        /// </summary>
        [Display(Name = "生日")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime Birthday{ get; set; }

        /// <summary>
        /// 大頭照
        /// </summary>
        [Display(Name = "大頭照")]
        public string Photo{ get; set; }

        /// <summary>
        /// 備註
        /// </summary>
        [Display(Name = "備註")]
        public string Memo{ get; set; }

        [Display(Name = "碼")]
        [Required(ErrorMessage = "{0} 不可為空")]
        //[UIHint("CompanyD")]
        [ForeignKey("ClassM")]
        public string ClassId { get; set; }
        [Display(Name = "班級")]
        public virtual ClassM ClassM { get; set; }

        public virtual ICollection<StudClub> StudClubs { get; set; }
    }
}
