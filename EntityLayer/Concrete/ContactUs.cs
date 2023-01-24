using CoreLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class ContactUs : IEntity
	{
		public int ContactUSId { get; set; }
		public string ContactUsAdress { get; set; }
		public string ContactUsMail { get; set; }
		public string ContactUsPhone { get; set; }
	}
}
