using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SpiderDataBase.Entity
{
    [Table("history")]
    public class History
    {
        [Column("id")]
        public Guid Id { get; set; }

        [Column("aid")]
        public string AId { get; set; }

        [Column("bid")]
        public string BId { get; set; }

        [Column("card")]
        public string Card { get; set; }

        [Column("bookname")]
        public string BookName { get; set; }

        [Column("adminname")]
        public string AdminName { get; set; }

        [Column("username")]
        public string UserName { get; set; }

        [Column("begintime")]
        public string BeginTime { get; set; }

        [Column("endtime")]
        public string Endtime { get; set; }

        [Column("status")]
        public int Status { get; set; }
    }
}
