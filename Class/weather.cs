using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Instant.Class
{
   public class weather
    {

        public static   Conditions GetCurrentConditions(string city)
        {
            Conditions cond = new Conditions();
            XmlDocument doc = new XmlDocument();
            XmlTextReader reader = null;

            try
            {
                reader = new XmlTextReader(string.Format("http://www.google.com/ig/api?weather={0}", city));
                doc.Load(reader);

                if (doc.SelectSingleNode("xml_api_reply/weather/problem_cause") != null)
                {
                    cond = null;
                }
                else
                {
                    cond.City = doc.SelectSingleNode("/xml_api_reply/weather/forecast_information/city").Attributes["data"].InnerText;
                    cond.Condition = doc.SelectSingleNode("/xml_api_reply/weather/current_conditions/condition").Attributes["data"].InnerText;
                    cond.TempC = doc.SelectSingleNode("/xml_api_reply/weather/current_conditions/temp_c").Attributes["data"].InnerText;
                    cond.TempF = doc.SelectSingleNode("/xml_api_reply/weather/current_conditions/temp_f").Attributes["data"].InnerText;
                    cond.Humidity = doc.SelectSingleNode("/xml_api_reply/weather/current_conditions/humidity").Attributes["data"].InnerText;
                    cond.Wind = doc.SelectSingleNode("/xml_api_reply/weather/current_conditions/wind_condition").Attributes["data"].InnerText;
                }
            }
            catch (Exception)
            {
                cond = null;
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }

            return cond;
        }


        public static  List<Conditions> GetForecastConditions(string city)
        {
            Conditions cond = new Conditions();
            XmlDocument doc = new XmlDocument();
            XmlTextReader reader = null;
            List<Conditions> conditions = new List<Conditions>();

            try
            {
                reader = new XmlTextReader(string.Format("http://www.google.com/ig/api?weather={0}", city));
                doc.Load(reader);

                if (doc.SelectSingleNode("xml_api_reply/weather/problem_cause") != null)
                {
                    conditions = null;
                }
                else
                {
                    foreach (XmlNode node in doc.SelectNodes("/xml_api_reply/weather/forecast_conditions"))
                    {
                        cond = new Conditions();
                        cond.City = doc.SelectSingleNode("/xml_api_reply/weather/forecast_information/city").Attributes["data"].InnerText;
                        cond.Condition = node.SelectSingleNode("condition").Attributes["data"].InnerText;
                        cond.High = node.SelectSingleNode("high").Attributes["data"].InnerText;
                        cond.Low = node.SelectSingleNode("low").Attributes["data"].InnerText;
                        cond.Day = node.SelectSingleNode("day_of_week").Attributes["data"].InnerText;
                        conditions.Add(cond);
                    }
                }
            }
            catch (Exception)
            {
                conditions = null;
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }

            return conditions;
        }

    }


   public class Conditions
    {
        public string City { get; set; }
        public string Condition { get; set; }
        public string TempF { get; set; }
        public string TempC { get; set; }
        public string Humidity { get; set; }
        public string Wind { get; set; }
        public string Day { get; set; }
        public string High { get; set; }
        public string Low { get; set; }
    }

}
