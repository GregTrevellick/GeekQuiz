﻿using System;
using Quiz.Questions.Entities;

namespace Quiz.Ui.Core
{
    public class QuizHelperDto
    {
        public Category Category;
        public DateTime LastPopUpDateTime;
        public string OptionsName;
        public int PopUpCountToday;
        public string PopUpTitle;
        public SearchEngine SearchEngine;
        public bool SuppressClosingWithoutSubmitingAnswerWarning;
        public int TimeOutInMilliSeconds;
        public int TotalQuestionsAnsweredCorrectlyEasy;
        public int TotalQuestionsAnsweredCorrectlyHard;
        public int TotalQuestionsAnsweredCorrectlyMedium;
        public int TotalQuestionsAsked;
    }
}