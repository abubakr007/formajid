using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuestionsPro.Models
{
    public class item
    {
        List<String> tags;
        owner Owner;
        bool is_answered;
        int view_count;
        int answer_count;
        int score;
        long last_activity_date;
        long creation_date;
        long last_edit_date;
        int question_id;
        String link;
        String title;

    }
}