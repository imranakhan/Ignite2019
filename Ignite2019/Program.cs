using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;

namespace Ignite2019
{
    class Program
    {

        public static List<string> ProductExcludeList = new List<string>() { 
            "Dynamics 365", "Microsoft 365", "Power Platform"
        };
        static void Main(string[] args)
        {
            string URL = "https://api-myignite.techcommunity.microsoft.com/api/session/all";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            request.ContentType = "application/json; charset=utf-8";
            //request.Headers["Authorization"] = "Basic " + Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes("username:password"));
            request.PreAuthenticate = true;
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            string responseString = null;
            using (Stream responseStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                responseString = reader.ReadToEnd();

            }

            var topicList = new List<string>();
            var selectedList = new List<string>();
            if (!string.IsNullOrWhiteSpace(responseString))
            {
                List<Session> sessionsList = JsonConvert.DeserializeObject<List<Session>>(responseString);

                if(sessionsList != null && sessionsList.Count > 0)
                {
                    //Getting the list of Sessions
                    foreach(var session in sessionsList)
                    {                    
                        if (!topicList.Contains(session.topic))
                        {
                            topicList.Add(session.topic);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("None Found!");
                }
                

                foreach(string topic in topicList)
                {
                    int sessionCount = 0;
                    foreach(var session in sessionsList)
                    {
                        if(session.topic == topic)
                        {
                            sessionCount++;
                        }
                    }

                    Console.WriteLine("TOPIC-"+topic + ":" + sessionCount);
                }

                int totalSessionCount = 0;


                List<Session> filteredSessionList = new List<Session>();
                foreach (var session in sessionsList)
                {
                    if(!session.products.Any(x => ProductExcludeList.Contains(x)))
                    {
                        totalSessionCount++;
                        filteredSessionList.Add(session);
                    }
                }
                Console.WriteLine("PRODUCTLIST-"+totalSessionCount);


                //Session list per topic counts
                foreach (string topic in topicList)
                {
                    int sessionCount = 0;
                    foreach (var session in filteredSessionList)
                    {
                        if (session.topic == topic)
                        {
                            sessionCount++;
                        }
                    }

                    Console.WriteLine("TOPIC-" + topic + ":" + sessionCount);
                }


                //Console.WriteLine(string.Join(",\n", productList));
            }
        }
    }
}

// Topics
//Development,
//Productivity,
//Infrastructure,
//Diversity and Inclusion,
//Fundamentals,
//Data,
//Management,
//Thought Leadership,
//Compliance,
//Identity,
//Security,
//How Microsoft transforms IT internally,
//Intelligence,
//Deployment,
//Customer Success,
//,
//Devices,
//Tooling,
//Citizen Dev,
//Diversity & Tech
