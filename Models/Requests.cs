using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cinema.Models
{
	public class Requests
	{
		public int Id { get; set; }
		public int TicketId { get; set; }
		public Ticket Ticket { get; set; }
		public int CustomerId { get; set; }
		public Customer Customer { get; set; }
		public DateTime Date { get; set; }
	}
}