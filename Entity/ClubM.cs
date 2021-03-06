using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace coreDemo.Entity
{
    /// <summary>
    /// 社團
    /// </summary>
    [Table("ClubM")]
    public partial class ClubM
    {
        /// <summary>
        /// 流水號
        /// </summary>
        [Display(Name = "流水號")]
        [Key]
        public int Sn{ get; set; }

        /// <summary>
        /// 社團名
        /// </summary>
        [Display(Name = "社團名")]
        public string Name{ get; set; }
        public virtual ICollection<StudClub> StudClubs { get; set; }
    }
}
