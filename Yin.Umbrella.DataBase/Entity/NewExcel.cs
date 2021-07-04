using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Yin.Umbrella.DataBase.Entity
{
    [Table("newexcel")]
    public class NewExcel
    {
        [Column("id")]
        public Guid Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("gender")]
        public string Gender { get; set; }

        [Column("age")]
        public string Age { get; set; }
    }
}
