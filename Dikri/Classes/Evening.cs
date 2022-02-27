using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Dikri
{
    public class Evening
    {
        /*attribut*/
        public static string pathEvening = "Evening.xml";
        int number;
        int count;
        string dikr;

        /*proprties*/
        public int Number { get => number; set => number = value; }
        public int Count { get => count; set => count = value; }
        public string Dikr { get => dikr; set => dikr = value; }

        /*Constructer*/
        public Evening() { }

        public Evening(int number, int count, string dikr)
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

        static public List<Evening> Upload(List<Evening> evnings)
        {
            try
            {
                FileStream file = new FileStream(pathEvening, FileMode.Open);
                XmlSerializer xml = new XmlSerializer(typeof(List<Evening>));
                evnings = (List<Evening>)xml.Deserialize(file);
                file.Close();
                return evnings;
            }
            catch
            {
                return evnings;
            }
        }

        public void Save(List<Evening> evnings)
        {
            try
            {
                FileStream file = new FileStream(pathEvening, FileMode.OpenOrCreate);
                XmlSerializer xml = new XmlSerializer(typeof(List<Evening>));
                xml.Serialize(file, evnings);
                file.Close();
            }
            catch { }
        }
    }
}
