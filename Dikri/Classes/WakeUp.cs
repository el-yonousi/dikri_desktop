using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Dikri
{
    public class WakeUp
    {
        /*attribut*/
        public static string pathWakeUp = "WakeUp.xml";
        int number;
        int count;
        string dikr;

        /*proprties*/
        public int Number { get => number; set => number = value; }
        public int Count { get => count; set => count = value; }
        public string Dikr { get => dikr; set => dikr = value; }

        /*Constructer*/
        public WakeUp() { }

        public WakeUp(int number, int count, string dikr)
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

        static public List<WakeUp> Upload(List<WakeUp> wakeUps)
        {
            try
            {
                FileStream file = new FileStream(pathWakeUp, FileMode.Open);
                XmlSerializer xml = new XmlSerializer(typeof(List<WakeUp>));
                wakeUps = (List<WakeUp>)xml.Deserialize(file);
                file.Close();
                return wakeUps;
            }
            catch
            {
                return wakeUps;
            }
        }

        public void Save(List<WakeUp> wakeUps)
        {
            try
            {
                FileStream file = new FileStream(pathWakeUp, FileMode.OpenOrCreate);
                XmlSerializer xml = new XmlSerializer(typeof(List<WakeUp>));
                xml.Serialize(file, wakeUps);
                file.Close();
            }
            catch { }
        }
    }
}
