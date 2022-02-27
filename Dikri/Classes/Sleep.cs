using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Dikri
{
    public class Sleep
    {
        /*attribut*/
        public static string pathSleep = "Sleep.xml";
        int number;
        int count;
        string dikr;

        /*proprties*/
        public int Number { get => number; set => number = value; }
        public int Count { get => count; set => count = value; }
        public string Dikr { get => dikr; set => dikr = value; }

        /*Constructer*/
        public Sleep() { }

        public Sleep(int number, int count, string dikr)
        {
            this.number = number;
            this.count = count;
            this.dikr = dikr;
        }

        /*functions*/
        public override string ToString()
        {
            return string.Format("{0:D2},{1:D2},{2}", number, count, dikr);
        }

        static public List<Sleep> Upload(List<Sleep> sleeps)
        {
            try
            {
                FileStream file = new FileStream(pathSleep, FileMode.Open);
                XmlSerializer xml = new XmlSerializer(typeof(List<Sleep>));
                sleeps = (List<Sleep>)xml.Deserialize(file);
                file.Close();
                return sleeps;
            }
            catch
            {
                return sleeps;
            }
        }

        public void Save(List<Sleep> sleeps)
        {
            try
            {
                FileStream file = new FileStream(pathSleep, FileMode.OpenOrCreate);
                XmlSerializer xml = new XmlSerializer(typeof(List<Sleep>));
                xml.Serialize(file, sleeps);
                file.Close();
            }
            catch { }
        }
    }
}
