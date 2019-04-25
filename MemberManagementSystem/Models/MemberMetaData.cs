using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MemberManagementSystem.Models
{
    [MetadataType(typeof(MemberMetaData))]
    public partial class MemberData
    {
        public class MemberMetaData
        {
            public int ID { get; set; }
            public string Name { get; set; }
            [Range(0, 100, ErrorMessage = "年齡格式不符")]
            public int Age { get; set; }
            public string Address { get; set; }
            [RegularExpression(@"^09[0-9]{2}-[0-9]{6}$", ErrorMessage= "手機格式不符")]
            public string Tel { get; set; }
        }
    }

}