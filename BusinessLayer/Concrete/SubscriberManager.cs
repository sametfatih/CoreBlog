using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class SubscriberManager : ISubscriberService
	{
		ISubscriberDal _subscriberDal;
		public SubscriberManager(EfSubscriberDal subscriberDal)
		{
			_subscriberDal = subscriberDal;
		}
		public void Add(Subscriber entity)
		{
			_subscriberDal.Add(entity);
		}

		public bool CheckMail(Subscriber subscriber)
		{
			var result = _subscriberDal.Get(s=>s.SubscriberMail==subscriber.SubscriberMail);
			if (result == null)
			{
				return true;
			}
			return false;
		}

		public void Delete(int id)
		{
			throw new NotImplementedException();
		}

		public List<Subscriber> GetAll()
		{
			throw new NotImplementedException();
		}

		public Subscriber GetByID(int id)
		{
			throw new NotImplementedException();
		}

		public void Update(Subscriber entity)
		{
			throw new NotImplementedException();
		}
	}
}
