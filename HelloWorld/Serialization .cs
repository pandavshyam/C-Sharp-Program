using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace HelloWorld
{
    [Serializable]
    public class ClassToSerialize
    {
        public int age = 100;
        public string name = "shyam";
    }
    class Serialization
    {
        public void SerializeNow()
        {
            ClassToSerialize c = new ClassToSerialize();
            Stream s = new FileStream("D:\\Example.txt", FileMode.Create, FileAccess.Write);
            BinaryFormatter b = new BinaryFormatter();
            b.Serialize(s, c);
            s.Close();
        }
        public void DeSerializeNow()
        {
            ClassToSerialize c = new ClassToSerialize();
            Stream s = new FileStream("D:\\Example.txt", FileMode.Open, FileAccess.Read);
            BinaryFormatter b = new BinaryFormatter();
            c = (ClassToSerialize)b.Deserialize(s);
            Console.WriteLine(c.name);
            s.Close();
        }
        static void Main(string[] args)
        {
            Serialization obj = new Serialization();
            //obj.SerializeNow();
            obj.DeSerializeNow();
        }
    }
}
