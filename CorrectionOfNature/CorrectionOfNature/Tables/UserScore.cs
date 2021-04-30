using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace CorrectionOfNature.Tables
{
	public class UserScore
	{
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }
		public string Username { get; set; }
		public int Score { get; set; }
	}
}
