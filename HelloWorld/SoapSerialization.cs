using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HelloWorld
{
    public class SoapSerialization
    {
        public void SerializeNow()
        {
            ClassToSerialize c = new ClassToSerialize();
            FileStream s = new FileStream("D:\\Example.txt", FileMode.Create, FileAccess.Write);
            //SoapFormatter b = new SoapFormatter();
            //b.Serialize(s, c);
            s.Close();
        }
        public void DeSerializeNow()
        {
            ClassToSerialize c = new ClassToSerialize();
            Stream s = new FileStream("D:\\Example.txt", FileMode.Open, FileAccess.Read);
            //SoapFormatter b = new SoapFormatter();
            //c = (ClassToSerialize)b.Deserialize(s);
            //Console.WriteLine(c.name);
            s.Close();
        }
    }
}
