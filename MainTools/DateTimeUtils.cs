
namespace MainTools
{
    /// <summary>
    /// 时间工具类
    /// 时间戳相互转换
    /// </summary>
    public static class DateTimeUtils
    {
        /// <summary>
        /// 时间戳计时开始时间
        /// </summary>
        private static DateTime timeStampStartTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        /// <summary>
        /// DateTime转换为10位时间戳（单位：秒）
        /// </summary>
        /// <param name="dateTime"> DateTime</param>
        /// <returns>10位时间戳（单位：秒）</returns>
        public static long DateTimeToTimeStamp(this DateTime dateTime)
        {
            return (long)(dateTime.ToUniversalTime() - timeStampStartTime).TotalSeconds;
        }

        /// <summary>
        /// 10位时间戳（单位：秒）转换为DateTime
        /// </summary>
        /// <param name="timeStamp">10位时间戳（单位：秒）</param>
        /// <returns>DateTime</returns>
        public static DateTime TimeStampToDateTime(this long timeStamp)
        {
            return timeStampStartTime.AddSeconds(timeStamp).ToLocalTime();
        }

        /// <summary>
        /// DateTime转换为13位时间戳（单位：毫秒）
        /// </summary>
        /// <param name="dateTime"> DateTime</param>
        /// <returns>13位时间戳（单位：毫秒）</returns>
        public static long DateTimeToLongTimeStamp(this DateTime dateTime)
        {
            return (long)(dateTime.ToUniversalTime() - timeStampStartTime).TotalMilliseconds;
        }

        /// <summary>
        /// 13位时间戳（单位：毫秒）转换为DateTime
        /// </summary>
        /// <param name="longTimeStamp">13位时间戳（单位：毫秒）</param>
        /// <returns>DateTime</returns>
        public static DateTime LongTimeStampToDateTime(this long longTimeStamp)
        {
            return timeStampStartTime.AddMilliseconds(longTimeStamp).ToLocalTime();
        }

        /// <summary>
        /// 将给定的DateTime转换成毫秒 (跟java或其他语言 通用对接使用) 解决C#环境或windows相差8个小时的时区问题
        /// </summary>
        public static long DateTimeToTimeMillisecondsStamp(this DateTime dt)
        {
            DateTime dt_1970 = new DateTime(1970, 1, 1);
            TimeSpan span = dt - dt_1970;

            // .net开发中计算的都是标准时区的差，但java的解析时间跟时区有关，
            // 而我们的java服务器系统时区不是标准时区，解析时间会差8个小时。
            span -= TimeSpan.FromHours(8);

            return (long)span.TotalMilliseconds;
        }

        /// <summary> 
        /// 将给定的毫秒数转换成DateTime (跟java或其他语言 通用对接使用) 解决C#环境或windows相差8个小时的时区问题
        /// </summary>
        public static DateTime TimeMillisecondsStampToDateTime(this long milliseconds)
        {
            DateTime dt_1970 = new DateTime(1970, 1, 1);

            //// .net开发中计算的都是标准时区的差，但java的解析时间跟时区有关，
            // 而我们的java服务器系统时区不是标准时区，解析时间会差8个小时。
            TimeSpan span = TimeSpan.FromMilliseconds(milliseconds) + TimeSpan.FromHours(8);

            return dt_1970 + span;
        }

    }
}