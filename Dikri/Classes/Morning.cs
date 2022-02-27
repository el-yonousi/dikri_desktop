using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Dikri
{
    public class Morning
    {
        /*attribut*/
        public static string pathMorning = "Morning.xml";
        int number;
        int count;
        string dikr;

        /*proprties*/
        public int Number { get => number; set => number = value; }
        public int Count { get => count; set => count = value; }
        public string Dikr { get => dikr; set => dikr = value; }

        /*Constructer*/
        public Morning() { }

        public Morning(int number, int count, string dikr)
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

        static public List<Morning> Upload(List<Morning> mornings)
        {
            try
            {
                FileStream file = new FileStream(pathMorning, FileMode.Open);
                XmlSerializer xml = new XmlSerializer(typeof(List<Morning>));
                mornings = (List<Morning>)xml.Deserialize(file);
                file.Close();
                return mornings;
            }
            catch
            {
                return mornings;
            }
        }

        public void Save(List<Morning> mornings)
        {
            try
            {
                FileStream file = new FileStream(pathMorning, FileMode.OpenOrCreate);
                XmlSerializer xml = new XmlSerializer(typeof(List<Morning>));
                xml.Serialize(file, mornings);
                file.Close();
            }
            catch { }
        }
    }
}
