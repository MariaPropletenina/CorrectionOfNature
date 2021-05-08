using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace CorrectionOfNature.Tables
{
    public class Avatar
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public byte[] Content { get; set; }
    }
}
