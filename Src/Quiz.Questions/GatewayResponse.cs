﻿using System.Collections.Generic;
using Quiz.Questions.Entities;

namespace Quiz.Questions
{
    public class GatewayResponse 
    {
        public Category Category { get; set; }
        public DifficultyLevel DifficultyLevel { get; set; }
        public IEnumerable<string> MultipleChoiceAnswers { get; set; }
        public string MultipleChoiceCorrectAnswer { get; set; }
        public string Question { get; set; }
        public QuestionType QuestionType { get; set; }
        public string ErrorDetails { get; set; }
    }
}
