﻿//namespace Quiz.Ui.Core
//{
//    public static class StringExtensions
//    {
//        public static bool IsNonNegativeInteger(this string str)
//        {
//            var isInteger = int.TryParse(str, out int x);
//            if (isInteger)
//            {
//                if (x < 0)
//                {
//                    isInteger = false;
//                }
//            }
//            return isInteger;
//        }

//        public static bool IsWithinRecommendedTimeoutLimits(this string str)
//        {
//            var isInteger = int.TryParse(str, out int x);

//            bool isWithinRecommendedTimeoutLimits = false;

//            if (isInteger)
//            {
//                if (x >= Constants.RecommendedMinimumTimeoutMilliSeconds && 
//                    x <= Constants.RecommendedMaximumTimeoutMilliSeconds)
//                {
//                    isWithinRecommendedTimeoutLimits = true;
//                }
//            }

//            return isWithinRecommendedTimeoutLimits;
//        }

//        public static int GetAsInteger(this string str)
//        {
//            var isInteger = int.TryParse(str, out int x);
//            return isInteger ? x : 0;
//        }
//    }
//}
