﻿using Models.SysModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.TestModels
{
   //位置
    public enum Position
    {
        上肢,
        下肢,
        躯干,

    }
    /// <summary>
    /// 指标项目类型表
    /// </summary>
    public class TrainingType : DbSetBase
    {
        public TrainingType()
        {
            Position = Position.上肢;
        }
        public string Name { get; set; }

        public Position Position { get; set; }

        [ScaffoldColumn(false)]
        public virtual ICollection<TrainingRelation> TrainingRelations { get; set; }

    }
    /// <summary>
    /// 指标配置关系表（和教练角色关联）
    /// </summary>
    public class TrainingRelation
    {
        public TrainingRelation()
        {
            Id = Guid.NewGuid().ToString();
        }
        [Key]
        [ScaffoldColumn(false)]
        [Required]
        [MaxLength(128)]
        public string Id { get; set; }

        [ForeignKey("SysDepartment")]
        [MaxLength(128)]
        public string SysDepartmentId { get; set; }
        [ScaffoldColumn(false)]
        public virtual SysDepartment SysDepartment { get; set; }

        [ForeignKey("TrainingType")]    
        [MaxLength(128)]
        public string TrainingTypeId { get; set; }
        [ScaffoldColumn(false)]
        public virtual TrainingType TrainingType { get; set; }
    }
    /// <summary>
    /// 运动员指标数据
    /// </summary>
    public class TrainingPeople : DbSetBase
    {
        [ForeignKey("TrainingType")]
        [MaxLength(128)]
        public string TrainingTypeId { get; set; }
        [ScaffoldColumn(false)]
        public virtual TrainingType TrainingType { get; set; }

        public double Value { get; set; }

    }
}
