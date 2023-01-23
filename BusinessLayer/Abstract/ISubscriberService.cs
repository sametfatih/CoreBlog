using CoreLayer.Business.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface ISubscriberService:IService<Subscriber>
	{
		public bool CheckMail(Subscriber subscriber);
	}
}
