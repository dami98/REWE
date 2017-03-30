using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace BINArryformatter
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Animal("Flipper", 2, 5);
            Stream str = File.Open("AnimalData.dat", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(str, cat);
            str.Close();
            cat = null;

            str = File.OpenRead("AnimalData.dat");
            cat = (Animal)bf.Deserialize(str);

            Console.WriteLine(cat);





            //XmlSerializer serializer = new XmlSerializer(typeof(Animal));
            //using (TextWriter twr = new StreamWriter(@"C:\users\dkaestner\desktop\antohertest.html"))
            //{
            //    serializer.Serialize(twr, Bowser);
            //}

            //XmlSerializer Deserializer = new XmlSerializer(typeof(Animal));
            //TextReader tread = new StreamReader(@"C:\users\dkaestner\desktop\antohertest.html");
            //object obj = Deserializer.Deserialize(tread);
            //Bowser = (Animal)obj;
            //Console.WriteLine(Bowser.ToString());


            List<Animal> theAnimals = new List<Animal>
            {
	            new Animal("Guardian",23,12),
	            new Animal("Trammpler",23,11),
	            new Animal("LangBein",23,555)
            };

            XmlSerializer Serializer2 = new XmlSerializer(typeof(List<Animal>));

            using (Stream fs = new FileStream(@"C:\users\dkaestner\desktop\ANimalList1.xml", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                Serializer2.Serialize(fs, theAnimals);
            }

            using (FileStream fs2 = File.OpenRead(@"C:\users\dkaestner\desktop\ANimalList1.xml"))
            {
                theAnimals = (List<Animal>)Serializer2.Deserialize(fs2);
            }

            foreach (Animal a in theAnimals)
            {
                Console.WriteLine(a.ToString());
            }




            /*
XmlSerializer Serializer2 = new XmlSerializer(typeof(List<Animal>));
            using(Stream fs = new FileStream(@"C:\users\dkaestner\desktop\theAnimals.xml",FileMode.Create, FileAccess.Write,FileShare.None))
{
	Serializer2.Serialize(fs, theAnimals);
}

using( FileStream fs2 = File.OpenRead(@"C:\users\dkaestner\desktop\theAnimals.xml"))
{
	theAnimals = (List<Animal>)Serializer2.Deserialize(fs2);
}

foreach(Animal a in theAnimals)
{
    Console.WriteLine(a.ToString());
} */



            //first instantiate a list 
            //second instantiate a xmlSerializer
            //third instantiate a using stream
            //fourth using another stream to connect to the data and add to the list 
            //fith print out each item in the list



            //List<Animal> theAnimals = new List<Animal>
            //{
            //    new Animal ("Damian Kästner",100,1.85),
            //    new Animal ("Max Lütters",78,1.78),
            //    new Animal ("Bastian Kästner",75,1.78)
            //};

            //using (Stream fs = new FileStream(@"C:\users\dkaestner\desktop\ListOfAnimals.xml", FileMode.Create, FileAccess.Write, FileShare.None))
            //{
            //    XmlSerializer serializer2 = new XmlSerializer(typeof(List<Animal>));
            //}
            //theAnimals = null;

            //XmlSerializer serializer3 = new XmlSerializer(typeof(List<Animal>));

            //using(FileStream fs2 = File.OpenRead(@"C:\users\dkaestner\desktop\ListOfAnimals.xml"))
            //{
            //    theAnimals = (List<Animal>) serializer3.Deserialize(fs2);
            //}

            //foreach (Animal a in theAnimals)
            //{
            //    Console.WriteLine(a.ToString());
            //}







            Console.ReadLine();



        }
    }
}
