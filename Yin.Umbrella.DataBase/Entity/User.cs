using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Yin.Umbrella.DataBase;

namespace SpiderDataBase.Entity
{
    [Table("user")]
    public class User: EntityBase
    {

        [Column("UserName")]
        public string Name { get; set; }

        [Column("PassWord")]
        public string PassWord { get; set; }

        [Column("Gender")]
        public string Gender { get; set; }

        [Column("Email")]
        public string Email { get; set; }

        [Column("Province")]
        public string Province { get; set; }

        [Column("City")]
        public string City { get; set; }

        [Column("Birthday")]
        public DateTime Birthday { get; set; }

        [Column("Type")]
        public int Type { get; set; }

        [Column("ClassId")]
        public Guid ClassId { get; set; }

    }
}
