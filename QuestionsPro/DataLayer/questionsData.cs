using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using StackExchange.StacMan;

namespace QuestionsPro.DataLayer
{
    public class questionsData
    {
        public Dictionary<int,String> getTitles()
        {
            Dictionary<int, String> titles = new Dictionary<int, String>();
            var client = new StacManClient(key: "ZooTQP9hfBOle)91FBc)uQ((", version: "2.1");
            DateTime today = DateTime.Today;
            today.AddDays(-1);
            DateTime today2 = DateTime.Today;
            //today2.AddDays(-1);
            var dateTime = new DateTime();
            //dateTime = dateTime.AddDays(-1);

            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            var unixDateTime = (dateTime.ToUniversalTime() - epoch).TotalSeconds;

            var response = client.Questions.GetAll("stackoverflow",
                page: 1,
                pagesize: 50,
                //fromdate: today,
                //todate: today2,
                sort: StackExchange.StacMan.Questions.AllSort.Creation,
                order: Order.Desc).Result;

            foreach (var question in response.Data.Items)
            {
                titles.Add(question.QuestionId, question.Title);
                //Console.WriteLine(question.Title);
            }
            return titles;
        }
        public Question getQuestionById(int? id)
        {
            var client = new StacManClient(key: "ZooTQP9hfBOle)91FBc)uQ((", version: "2.1");
            int[] idss = new int[1];
            
            idss[0] = (int)id ;
            var response = client.Questions.GetByIds("stackoverflow", ids: idss, filter: "withbody").Result;
            //var response1 = client.Posts.GetByIds("stackoverflow", ids: idss).Result;
            
            if (response.Data.Items == null)
                return null;
            return response.Data.Items[0];
        }
    }
}