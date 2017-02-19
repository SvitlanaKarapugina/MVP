﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DataBase
{
	public class AuthorMagazine
	{
		public int Id { get; set; }
		public int MagazineId { get; set; }
		public Magazine Magazine { get; set; }
		public int AuthorId { get; set; }
		public Author Author { get; set; }
	}
}