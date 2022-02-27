using System;
using System.IO;
using System.Xml.Serialization;

namespace Dikri
{
    public class TotaleRead
    {
        /*attributs*/
        public static string pathTotaleRead = "TotalCount.txt";

        /*constructers*/
        public TotaleRead() { }

        /*functions*/
        static public int Upload()
        {
            int totale = 0;
            try
            {
                using (StreamReader sr = new StreamReader(pathTotaleRead))
                {
                    totale = int.Parse(sr.ReadLine());
                    sr.Close();
                }
                return totale;
            }
            catch (Exception ex)
            {
                LogFile.Message(ex);
                return totale;
            }
        }

        static public void Save(int totale)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(pathTotaleRead))
                {
                    sw.Write(totale);
                    sw.Close();
                }
            }
            catch (Exception ex) 
            {
                LogFile.Message(ex);
            }
        }
    }
}
