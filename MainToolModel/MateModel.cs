using System.Reflection;
using MainTools;

namespace MainToolModel
{
    [Mate("MateName", "MateCode", "MateId")]
    public class MateModel
    {
        public static string MetaName => typeof(MateModel).GetCustomAttributes<MateAttribute>(true).FirstOrDefault()!.MateName;
        
        public string Name { get; set; }
        
        public string Email { get; set; }
       
        public string IdNumber { get; set; }
    }
}
