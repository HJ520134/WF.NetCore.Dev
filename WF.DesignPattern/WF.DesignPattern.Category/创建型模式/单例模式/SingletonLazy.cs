using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF.DesignPattern.Category.单例模式
{
    /// <summary>
    /// 使用.NET 4 的Lazy 类型：线程安全
    /// </summary>
    public sealed class SingletonLazy
    {
        private SingletonLazy() { }

        public static SingletonLazy Instance { get {  return _singletonLazy.Value; } }

        private static readonly Lazy<SingletonLazy> _singletonLazy= new Lazy<SingletonLazy>(() => new SingletonLazy());

        public string LogMessage(string message) {
          
            return $"日志写入信息：{message}";
        }
    }
}
