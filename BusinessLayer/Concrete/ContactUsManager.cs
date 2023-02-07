using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContactUsManager : IContactUsService
	{
		IContactUsDal _contactDal;

		public ContactUsManager(EfContactUsDal contactDal)
		{
			_contactDal = contactDal;
		}

		public void Add(ContactUs entity)
		{
			throw new NotImplementedException();
		}

		public void Delete(int id)
		{
			throw new NotImplementedException();
		}

		public List<ContactUs> GetAll()
		{
			throw new NotImplementedException();
		}

		public ContactUs GetByID(int id)
		{
			return _contactDal.Get(c => c.ContactUSId == id);
		}

		public void Update(ContactUs entity)
		{
			throw new NotImplementedException();
		}
	}
}
