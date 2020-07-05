using System;
using System.Collections.Generic;
using System.Text;

namespace Yin.Umbrella.CodeGenerator.Models
{
    public class DBModel
    {
        public class ColumnInfo
        {
            public string table_name { get; set; }
            public string column_name { get; set; }
            public int? ordinal_position { get; set; }
            public string is_nullable { get; set; }
            public string data_type { get; set; }
            public Int64? character_maximum_length { get; set; }
            public string column_key { get; set; }
            public string column_comment { get; set; }
        }

        public class TableInfo
        {
            public string table_name { get; set; }
            public string table_comment { get; set; }

        }
    }
}
