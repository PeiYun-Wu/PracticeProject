using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0916Json
{
    class Program
    {//序列與反序列化

        public class Member
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public string Sex { get; set; }
        }
        static void Main(string[] args)
        {
            List<Member> lstStuModel = new List<Member>()
            {
                new Member(){ID=1,Name="Penny",Age=25,Sex="F"},
                new Member(){ID=2,Name="Wade",Age=30,Sex="M"}
            };
            //序列化
            string jsonData = JsonConvert.SerializeObject(lstStuModel);
            Console.WriteLine("序列化: " + jsonData);
            Console.WriteLine();

            //反序列化
            string jsonStr = @"{ 'Name':'Penny','Age':'25','ID':'1','Sex':'F'}";
            Member descJsonStr = JsonConvert.DeserializeObject<Member>(jsonStr);//反序列化
            Console.WriteLine(string.Format("反序列化： ID={0},Name={1},Sex={2},Sex={3}", descJsonStr.ID, descJsonStr.Name, descJsonStr.Age, descJsonStr.Sex));

            Console.ReadKey();
        }
    }
}
