using System;
using System.Collections.Generic;
using System.Text;

namespace Yin.Umbrella.DTO.ApiDTO
{
    public class AddUser3DTO
    {
        public string Name { get; set; }

        public string PassWord { get; set; }

        public string Gender { get; set; }


        public string Email { get; set; }


        public string Province { get; set; }


        public string City { get; set; }


        public DateTime Birthday { get; set; }


        public int Type { get; set; }


        public Guid ClassId { get; set; }
    }
}
