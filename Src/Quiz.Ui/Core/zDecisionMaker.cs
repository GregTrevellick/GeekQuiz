﻿//using System;

//namespace Quiz.Ui.Core
//{
//    public class DecisionMaker
//    {
//        public bool ShouldShowQuiz(GeneralOptionsDto generalOptionsDto)
//        {
//            var dateTimeNow = DateTime.Now;

//            if (!HaveExceededTodaysPopUpCount(generalOptionsDto, dateTimeNow))
//            {
//                if (LastPopUpMoreThanXMinutesAgo(generalOptionsDto.LastPopUpDateTime, generalOptionsDto.PopUpIntervalInMins, dateTimeNow))
//                {
//                    return true;
//                }
//            }

//            return false;
//        }

//        private bool HaveExceededTodaysPopUpCount(GeneralOptionsDto generalOptionsDto, DateTime dateTimeNow)
//        {
//            var isWeekend = IsWeekend(dateTimeNow);
//            bool haveExceededPopUpCountToday;

//            if (isWeekend)
//            {
//                haveExceededPopUpCountToday = HaveExceededTodaysPopUpCount(generalOptionsDto.PopUpCountToday, generalOptionsDto.MaximumPopUpsWeekEnd);
//            }
//            else
//            {
//                haveExceededPopUpCountToday = HaveExceededTodaysPopUpCount(generalOptionsDto.PopUpCountToday, generalOptionsDto.MaximumPopUpsWeekDay);
//            }

//            return haveExceededPopUpCountToday;
//        }

//        private bool IsWeekend(DateTime dateTimeNow)
//        {
//            return dateTimeNow.DayOfWeek == DayOfWeek.Saturday ||
//                   dateTimeNow.DayOfWeek == DayOfWeek.Sunday;
//        }

//        internal bool HaveExceededTodaysPopUpCount(int popUpCountToday, int maximumPopUps)
//        {
//            return popUpCountToday >= maximumPopUps;
//        }

//        internal bool LastPopUpMoreThanXMinutesAgo(DateTime lastPopUpDateTime, int popUpIntervalInMins, DateTime dateTimeNow)
//        {
//            var acceptableLastPopUpDateTime = dateTimeNow.AddMinutes(-1 * popUpIntervalInMins);
//            var result = lastPopUpDateTime <= acceptableLastPopUpDateTime;
//            return result;
//        }
//    }
//}
