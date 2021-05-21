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
		public int Score1 { get; set; }
		public int Score2 { get; set; }
		public int Score3 { get; set; }
		public int Score4 { get; set; }
		public int Score5 { get; set; }
		public int Score6 { get; set; }
		public int Score7 { get; set; }
		public int Score8 { get; set; }
		public int Score9 { get; set; }
		public int Score10 { get; set; }
	}
}
