﻿using CoreLayer.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Subscriber : IEntity
	{
		[Key]
		public int SubscriberId { get; set; }
		public string SubscriberMail { get; set; }
		public bool SubscriberStatus { get; set;} = false;
	}
}
