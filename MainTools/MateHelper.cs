using System.Reflection;

namespace MainTools;

public abstract class MateHelper
{
    /// <summary>
    /// 获取属性
    /// </summary>
    /// <returns></returns>
    public virtual MateAttribute GetMetaObjectAttribute()
    {
        return this.GetType().GetCustomAttribute<MateAttribute>();
    }

    /// <summary>
    /// 获取名称
    /// </summary>
    /// <returns></returns>
    public virtual string GetMateName()
    {
        return this.GetMetaObjectAttribute().MateName;
    }
    
    
}