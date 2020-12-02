using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cinema.Models
{
	public class CinemaModel
	{
		public int Id { get; set; }
		[DisplayName("عنوان")]
		[Required(ErrorMessage = "عنوان سینما  را وارد کنید")]
		public string Name { get; set; }
		[DisplayName("لوگو")]
		public string ImageUrl { get; set; }

		public int CityId { get; set; }
		public City City { get; set; }

		[DisplayName("ادرس")]
		[Required(ErrorMessage = "آدرس سینما  را وارد کنید")]
		public string Address { get; set; }
	}
}