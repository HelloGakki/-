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
        [Display(Name = "♂")]
        male,
        [Display(Name = "♀")]
        female
    }
    public enum EDepartment
    {
        [Display(Name = "总经理")]
        [Category("Boss")]
        boss,       // 总经理
        [Display(Name = "总经理助理")]
        [Category("BossAss")]
        bossAss,    // 总经理助理
        [Display(Name = "营运部")]
        [Category("Operation")]
        yyb,        // 营运部
        [Display(Name = "营运部助理")]
        [Category("OperationAss")]
        yybAss,     // 营运部助理
        [Display(Name = "研发部")]
        [Category("RD")]
        yfb,        // 研发部
        [Display(Name = "销售部")]
        [Category("Sales")]
        xsb,        // 销售部
        [Display(Name = "行政部")]
        [Category("Administration")]
        xzb,        // 行政部
        [Display(Name = "财务部")]
        [Category("Finance")]
        cwb,        // 财务部
        [Display(Name = "工程部")]
        [Category("Engineering")]
        gcb,        // 工程部
        [Display(Name = "供应链")]
        [Category("Supply")]
        gyl,        // 供应链
        [Display(Name = "计划部")]
        [Category("Planning")]
        jhb,        // 计划部
        [Display(Name = "仓储部")]
        [Category("Warehousing")]
        ccb,        // 仓储部
        [Display(Name = "生产部")]
        [Category("Production")]
        scb,        // 生产部
        [Display(Name = "品质部")]
        [Category("Quality")]
        pzb,        // 品质部
        [Display(Name = "人事部")]
        [Category("Personnel")]
        rsb,        // 人事部
        [Display(Name = "车队")]
        [Category("Fleet")]
        cd,         // 车队
        [Display(Name = "采购部")]
        [Category("Purchasing")]
        cgb,        // 采购部
    }

    #endregion

    public class Person
    {
        [DisplayName("ID")]
        public int PersonID { get; set; }

        [DisplayName("姓名")]
        public string Name { get; set; }

        [DisplayName("性别")]
        public EGender Gender { get; set; }

        [DisplayName("年龄")]
        public int? Age { get; set; }

        [DisplayName("手机")]
        public string Mobile { get; set; }

        [DisplayName("座机")]
        public string Tel { get; set; }

        [DisplayName("分机号")]
        public string TelExt { get; set; }

        [DisplayName("邮件")]
        public string Email{ get; set; }

        [DisplayName("部门")]
        public EDepartment Department { get; set; }
    }
}
