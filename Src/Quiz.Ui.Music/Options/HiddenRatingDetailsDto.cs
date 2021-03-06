﻿using System;
using Microsoft.VisualStudio.Shell;
using VsixRatingChaser.Interfaces;

namespace Quiz.Ui.Music.Options
{
    public class HiddenRatingDetailsDto : DialogPage, IRatingDetailsDto
    {
        public DateTime PreviousRatingRequest { get; set; }
        public int RatingRequestCount { get; set; }      
    }
}