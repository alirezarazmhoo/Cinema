using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cinema.Models
{
	public class Ticket
	{
		public int Id { get; set; }
		[Display(Name ="سینما")]
		public int CinemaId { get; set; }
		public CinemaModel Cinema { get; set; }
		[Display(Name = "شهر")]
		public int? CityId { get; set; }
		public City City { get; set; }
		[Display(Name = "فیلم")]
		public int MovieId { get; set; }
		public Movie Movie { get; set; }
		[Display(Name = "تاریخ بلیط")]
		public DateTime Date { get; set; }

		public string ImageUrl { get; set; }
	}
}