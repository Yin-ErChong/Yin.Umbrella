using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Yin.Umbrella.DataBase;

namespace SpiderDataBase.Entity
{
    [Table("book")]
    public class Book 
    {
        // [Key]
        [Column("id")]
        public Guid Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("card")]
        public string Card { get; set; }

        [Column("autho")]
        public string Autho { get; set; }

        [Column("num")]
        public int Num { get; set; }

        [Column("press")]
        public string Press { get; set; }

        [Column("type")]
        public string Type { get; set; }
    }
}
