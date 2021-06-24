using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SpiderDataBase.Entity
{
    [Table("admin")]
    public class Admin
    {
        // [Key]
        [Column("id")]
        public Guid Id { get; set; }

        [Column("username")]
        public string UserName { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("password")]
        public string Password { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("phone")]
        public string Phone { get; set; }

        [Column("status")]
        public int Status { get; set; }

        [Column("lendnum")]
        public int LendNum { get; set; }

        [Column("maxnum")]
        public int MaxNum { get; set; }
    }
}

