using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Score_And_Grade___Teacher_side__.Models
{
    public class Question
    {
        public int QuestionId { get; set; }
        public string QuestionText { get; set; }
        public string Difficulty { get; set; }
        public int Points { get; set; }
        public List<Option> Options { get; set; } = new List<Option>();
    }
}
