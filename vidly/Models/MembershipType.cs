using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace vidly.Models
{
    public class MembershipType
    {
        public static readonly byte Unknown = 0;
        public static readonly byte PayAsYouGo = 1;
        public string Name { get; set; }
        [Required]
        public byte Id { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
    }
}