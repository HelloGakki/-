using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Linkman.Domain.Entities
{
    #region " 人物属性枚举 "

    public enum EGender
    {
        [Display(Name = "男")]
        male,
        [Display(Name = "女")]
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
        [HiddenInput(DisplayValue = false)]
        [DisplayName("ID")]
        public int PersonID { get; set; }

        [Required(ErrorMessage = "Please enter a name")]
        [DisplayName("姓名")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a gender")]
        [RegularExpression(@"male|female", ErrorMessage = "Please enter male or female")]
        [DisplayName("性别")]
        public EGender Gender { get; set; }

        [Required(ErrorMessage = "Please enter an age")]
        [Range(0, 1000, ErrorMessage = "Please enter an age")]
        [DisplayName("年龄")]
        public int? Age { get; set; }

        [Required(ErrorMessage = "Please enter an mobilephone number")]
        [RegularExpression(@"0?(13|14|15|17|18|19)[0-9]{9}", ErrorMessage = "Please enter an mobilephone number")]
        [DisplayName("手机")]
        public string Mobile { get; set; }

        [Required(ErrorMessage = "Please enter a telphone number")]
        [RegularExpression(@"\d{7,8}", ErrorMessage = "Please enter a telphone number")]
        [DisplayName("座机")]
        public string Tel { get; set; }

        [Required(ErrorMessage = "Please enter a tel-ext")]
        [RegularExpression(@"\d{4}", ErrorMessage = "Please enter a tel-ext")]
        [DisplayName("分机号")]
        public string TelExt { get; set; }

        [Required(ErrorMessage = "Please enter an email")]
        [RegularExpression(@"\w[-\w.+]*@([A-Za-z0-9][-A-Za-z0-9]+\.)+[A-Za-z]{2,14}", ErrorMessage = "Please enter an email")]
        [DisplayName("邮件")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter a department code")]
        [Range(0, 16, ErrorMessage = "Please enter a department code")]
        [DisplayName("部门")]
        public EDepartment Department { get; set; }
    }
}
