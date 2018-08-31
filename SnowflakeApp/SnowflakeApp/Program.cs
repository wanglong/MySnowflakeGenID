using System;

namespace SnowflakeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("41bit的时间戳可以支持该算法使用的年限：{0}", (1L << 41) / (3600L * 24 * 365 * 1000.0));
            Console.WriteLine("5bit数据中心的数量：{0}", (1L << 5) - 1);
            Console.WriteLine("5bit工作机器的数量：{0}", (1L << 5) - 1);
            Console.WriteLine("10bit节点的数量：{0}", (1L << 10) - 1);
            Console.WriteLine("12bit序列Id的数量：{0}", (1L << 12) - 1);
            Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("开始执行 " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:ffffff") + "    " + Snowflake.Instance().GetId());
                Console.WriteLine("Snowflake.maxMachineId:" + Snowflake.maxMachineId);
            }
            Console.ReadLine();
        }
    }
}
