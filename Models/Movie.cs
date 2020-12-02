using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cinema.Models
{
	public class Movie
	{
		public int Id { get; set; }
		[Required(ErrorMessage ="نام فیلم الزامی است")]
		[Display(Name ="عنوان")]
		public  string Name { get; set; }
		[Display(Name = "تصویر")]
		public string ImageUrl { get; set; }
		[Required(ErrorMessage = "اسامی بازیگران  الزامی است")]
		[Display(Name = "بازیگران")]
		public string Actors { get; set; }
		[Required(ErrorMessage = "امتیاز فیلم الزامی است")]
		[Display(Name = "امتیازIMDB")]
		public int IMDBPoint { get; set; }
		[Required(ErrorMessage = "سال ساخت  الزامی است")]
		[Display(Name = "سال ساخت")]
		public DateTime CreatedDate { get; set; }
		[Display(Name = "خلاصه")]
		public string Summary { get; set; }
		[Required(ErrorMessage = "نام کارگردان  الزامی است")]
		[Display(Name = "کارگردان")]
		public string Director { get; set; }


	}
}