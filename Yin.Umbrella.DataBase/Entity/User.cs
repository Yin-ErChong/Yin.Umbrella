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

        [Column("username")]
        public string Name { get; set; }

        [Column("password")]
        public string PassWord { get; set; }

        [Column("gender")]
        public string Gender { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("province")]
        public string Province { get; set; }

        [Column("city")]
        public string City { get; set; }

        [Column("birthday")]
        public DateTime Birthday { get; set; }

        [Column("type")]
        public int Type { get; set; }

        [Column("classid")]
        public Guid ClassId { get; set; }

    }
}
