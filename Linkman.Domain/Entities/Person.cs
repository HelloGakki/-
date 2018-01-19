using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Linkman.Domain.Entities
{
    #region " 人物属性枚举 "

    public enum EGender
    {
        male,
        female
    }
    public enum EDepartment
    {
        [Display(Name = "总经理")]
        boss,       // 总经理
        [Display(Name = "总经理助理")]
        bossAss,    // 总经理助理
        [Display(Name = "营运部")]
        yyb,        // 营运部
        [Display(Name = "营运部助理")]
        yybAss,     // 营运部助理
        [Display(Name = "研发部")]
        yfb,        // 研发部
        [Display(Name = "销售部")]
        xsb,        // 销售部
        [Display(Name = "行政部")]
        xzb,        // 行政部
        [Display(Name = "财务部")]
        cwb,        // 财务部
        [Display(Name = "工程部")]
        gcb,        // 工程部
        [Display(Name = "供应链")]
        gyl,        // 供应链
        [Display(Name = "计划部")]
        jhb,        // 计划部
        [Display(Name = "仓储部")]
        ccb,        // 仓储部
        [Display(Name = "生产部")]
        scb,        // 生产部
        [Display(Name = "品质部")]
        pzb,        // 品质部
        [Display(Name = "人事部")]
        rsb,        // 人事部
        [Display(Name = "车队")]
        cd,         // 车队
        [Display(Name = "采购部")]
        cgb,        // 采购部
    }

    #endregion

    public class Person
    {
        public int PersonID { get; set; }
        public string Name { get; set; }
        public EGender Gender { get; set; }
        public int? Age { get; set; }
        public string Mobile { get; set; }
        public string Tel { get; set; }
        public string TelExt { get; set; }
        public string Email{ get; set; }
        public EDepartment Department { get; set; }
    }
}
