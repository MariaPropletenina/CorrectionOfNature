using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace CorrectionOfNature.Tables
{
	public class XamarinQuiz
	{
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }
		public string Question { get; set; }
		public string Answer1 { get; set; }
		public string Answer2 { get; set; }
		//public string Answer3 { get; set; }
		public int CurrentAnswer { get; set; }
	}
}
