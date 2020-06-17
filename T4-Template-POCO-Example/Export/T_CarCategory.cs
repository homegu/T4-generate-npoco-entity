using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_CarCategory.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(T_CarCategoryMetadata))]
	[PrimaryKey("CategoryID")]
	[TableName("[dbo].[T_CarCategory]")]
    public class T_CarCategory 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class T_CarCategoryMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("CategoryID")]
			public int Id { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("ParentID")]
			public int ParentID { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("CategoryName")]
			public string CategoryName { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("IsDeleted")]
			public bool IsDeleted { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("IsRecommend")]
			public byte IsRecommend { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("IsHot")]
			public byte IsHot { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("PathLevel")]
			public int PathLevel { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("Rank")]
			public int Rank { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("HotRank")]
			public int HotRank { get; set; }

			[StringLength(200, ErrorMessage = "{0}不能超过200个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("Path")]
			public string Path { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("PageTitle")]
			public string PageTitle { get; set; }

			[StringLength(200, ErrorMessage = "{0}不能超过200个字符！")]
			
			[Display(Name = "")]
			[Column("PageKeywords")]
			public string PageKeywords { get; set; }

			[StringLength(300, ErrorMessage = "{0}不能超过300个字符！")]
			
			[Display(Name = "")]
			[Column("PageDescription")]
			public string PageDescription { get; set; }

			[StringLength(200, ErrorMessage = "{0}不能超过200个字符！")]
			
			[Display(Name = "")]
			[Column("PictureUrl")]
			public string PictureUrl { get; set; }

			[StringLength(5, ErrorMessage = "{0}不能超过5个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("FirstChar")]
			public string FirstChar { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("SpellName")]
			public string SpellName { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("OldTableName")]
			public string OldTableName { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("OldTableKeyName")]
			public string OldTableKeyName { get; set; }

			[StringLength(100, ErrorMessage = "{0}不能超过100个字符！")]
			
			[Display(Name = "")]
			[Column("OldTableKeyValue")]
			public string OldTableKeyValue { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("VehicleTypeID")]
			public int VehicleTypeID { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("ForumID")]
			public int ForumID { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("DongLi")]
			public int DongLi { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("CheShenJieGou")]
			public string CheShenJieGou { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("MinXuHang")]
			public string MinXuHang { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("MaxXuHang")]
			public string MaxXuHang { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("MaxShiShu")]
			public string MaxShiShu { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("SlowCharge")]
			public string SlowCharge { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("FastCharge")]
			public string FastCharge { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("DCGongLv")]
			public string DCGongLv { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("DcRongLiang")]
			public string DcRongLiang { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("MinCompanyPrice")]
			public int MinCompanyPrice { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("MaxCompanyPrice")]
			public int MaxCompanyPrice { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("MinPrice")]
			public int MinPrice { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("MaxPrice")]
			public int MaxPrice { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("JiBie")]
			public int JiBie { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("Area")]
			public int Area { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("FactoryID")]
			public int FactoryID { get; set; }

			
			
			[Display(Name = "")]
			[Column("IsShow")]
			public byte? IsShow { get; set; }

			
			
			[Display(Name = "")]
			[Column("CompanyID")]
			public int? CompanyID { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("IsSubsidy")]
			public bool IsSubsidy { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("IsReleased")]
			public byte IsReleased { get; set; }

			
			
			[Display(Name = "")]
			[Column("ReleasedSerial")]
			public int? ReleasedSerial { get; set; }

			
			
			[Display(Name = "")]
			[Column("RecommendSerial")]
			public int? RecommendSerial { get; set; }

			
			
			[Display(Name = "")]
			[Column("HotSerial")]
			public int? HotSerial { get; set; }

    }
  }      
}