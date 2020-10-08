﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin2.Models
{
	public class Note
	{
		///public string Filename { get; set; }
		[PrimaryKey, AutoIncrement]
		public int ID { get; set; }
		public string Text { get; set; }
		public DateTime Date { get; set; }
	}
}
