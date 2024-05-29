using System.Diagnostics;
using MainToolModel;
using MainTools;
using System.Reflection;

namespace MainToolTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task MateAttributeTest()
        {
            var mateData = new MateModel();
            var cook=await Cook();
             await Egg();
            var tea=await Tea();
            Assert.IsTrue(tea=="tea");
            Console.ReadKey();
        }


        public async Task<string> Cook()
        {
            Debug.WriteLine("Cook");
            return await Task.FromResult("Cook");
        }
        
        public async Task<string> Egg()
        {
            Thread.Sleep(3000);
            Debug.WriteLine("Egg");
            return await  Task.FromResult("Egg");
        }
        
        public async Task<string> Tea()
        {
            Debug.WriteLine("Tea");
            return await Task.FromResult("Tea");
        }

    }
    
    
   
}