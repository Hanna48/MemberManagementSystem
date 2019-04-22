using System;
using System.Collections.Generic;
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
            public int Age { get; set; }
            public string Address { get; set; }
            public string Tel { get; set; }
        }
    }

}