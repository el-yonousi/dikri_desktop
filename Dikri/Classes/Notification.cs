using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Dikri
{
    public class Notification
    {
        /*attribut*/
        public static string pathNotification = "Notification.xml";
        int number;
        int count;
        string dikr;

        /*proprties*/
        public int Number { get => number; set => number = value; }
        public int Count { get => count; set => count = value; }
        public string Dikr { get => dikr; set => dikr = value; }

        /*Constructer*/
        public Notification() { }

        public Notification(int number, int count, string dikr)
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

        static public List<Notification> Upload(List<Notification> notifications)
        {
            try
            {
                FileStream file = new FileStream(pathNotification, FileMode.Open);
                XmlSerializer xml = new XmlSerializer(typeof(List<Notification>));
                notifications = (List<Notification>)xml.Deserialize(file);
                file.Close();
                return notifications;
            }
            catch
            {
                return notifications;
            }
        }

        public void Save(List<Notification> notifications)
        {
            try
            {
                FileStream file = new FileStream(pathNotification, FileMode.Create);
                XmlSerializer xml = new XmlSerializer(typeof(List<Notification>));
                xml.Serialize(file, notifications);
                file.Close();
            }
            catch { }
        }
    }
}
