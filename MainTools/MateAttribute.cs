using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainTools
{

    public class MateAttribute : Attribute
    {
        public MateAttribute(string name, string code, string Id)
        {
            this.MateName = name;
            this.MateCode = code;
            this.MateId = Id;
        }

        /// <summary>
        /// Code
        /// </summary>
        public string MateCode { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        public string MateName { get; set; }

        /// <summary>
        /// Id
        /// </summary>
        public string MateId { get; set; }
    }
}
