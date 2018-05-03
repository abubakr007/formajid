using QuestionsPro.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StackExchange.StacMan;
namespace QuestionsPro.Models
{
    public class Question
    {

        public Dictionary<int, String> getTitles()
        {
            questionsData qd = new questionsData();
            return qd.getTitles();
        }
        public StackExchange.StacMan.Question getQuestionById(int? id)
        {

            questionsData qd = new questionsData();
            return qd.getQuestionById(id);
        }
    }
   

    
   
    
}