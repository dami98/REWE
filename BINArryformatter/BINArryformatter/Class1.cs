using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace BINArryformatter
{
    [Serializable()]
    public class Animal : ISerializable
    {

        public int AnimalID { get; set; }
        public string Name { get; set; }
        public double  Weight { get; set; }
        public double Height { get; set; }
        public Animal()
        {
                
        }
        public Animal(string _name = "noName", double _weight = 0, double _height = 0)
        {
            Name = _name;
            Weight = _weight;
            Height = _height;
        }


        public override string ToString()
        {
            return string.Format("{0} weighs {1} kg and is {2} tall", Name, Weight, Height);
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            // Assign key value pair for your data
            info.AddValue("Name", Name);
            info.AddValue("Weight", Weight);
            info.AddValue("Height", Height);
            info.AddValue("AnimalID", AnimalID);
        }


        public Animal(SerializationInfo info, StreamingContext ctxt)
        {
            //Get the values from info and assign them to the properties
            Name = (string)info.GetValue("Name", typeof(string));
            Weight = (double)info.GetValue("Weight", typeof(double));
            Height = (double)info.GetValue("Height", typeof(double));
            AnimalID = (int)info.GetValue("AnimalID", typeof(int));
        }
    }
}
