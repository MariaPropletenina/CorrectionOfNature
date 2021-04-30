using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CorrectionOfNature
{
    public static class Constants
    {
        public const string DatabaseFilename = "CorrectionNatureDB.db";

        public const SQLite.SQLiteOpenFlags Flags =
            SQLite.SQLiteOpenFlags.ReadWrite |
            SQLite.SQLiteOpenFlags.Create |
            SQLite.SQLiteOpenFlags.SharedCache;

        public static string DatabasePath
        {
            get
            {
                var basePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                return Path.Combine(basePath, DatabaseFilename);
            }
        }
    }
}
