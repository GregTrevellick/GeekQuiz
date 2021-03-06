﻿using Quiz.Questions.Entities;
using RestSharp;
using System;
using System.Diagnostics;

namespace Quiz.Questions
{
    internal class ErrorHelper
    {
        internal static string HandleArgumentOutOfRangeException(string argumentName, int argumentValue)
        {
            var ex = new ArgumentOutOfRangeException($"argumentName={argumentName};argumentValue={argumentValue}");
            Debug.WriteLine(ex.Message);
            var exceptionTypeName = ex.GetType().Name;
            return $"An unexpected error of type {exceptionTypeName} has occurred ({argumentName}{argumentValue}).";
        }

        internal static void HandleUnexpectedError(Exception ex, ResponseDto responseDto)
        {
            Debug.WriteLine(ex.Message);
            var exceptionTypeName = ex.GetType().Name;
            responseDto.ErrorDetails = $"An unexpected error of type {exceptionTypeName} has occurred (possible JSON de-serialization error).";
        }

        internal static void HandleUnexpectedError(string url, Exception ex, ResponseDto responseDto)
        {
            Debug.WriteLine(ex.Message);
            var exceptionTypeName = ex.GetType().Name;
            responseDto.ErrorDetails = $"An unexpected error of type {exceptionTypeName} has occurred (possible communication error with {url}).";
        }

        internal static bool HasErrorOccured(IRestResponse response)
        {
            var errorHasOccured = 
                response == null ||
                response.ErrorException != null ||
                !string.IsNullOrEmpty(response.ErrorMessage);

            return errorHasOccured;
        }

        internal static string GetErrorDetails(IRestResponse response, string timeOutInMilliSecondsOptionLabel, string optionName)
        {
            string errorDetails;

            if (response == null)
            {
                errorDetails = "An indeterminate error has occurred";
            }
            else
            {
                errorDetails =
                    response.ResponseStatus + " " +
                    "(" + response.StatusCode + ") " +
                    response.StatusDescription + " " +
                    response.ErrorMessage + " ";

                if (response.ErrorException != null &&
                    response.ErrorException.Message != response.ErrorMessage)
                {
                    errorDetails = errorDetails + " " + response.ErrorException.Message;
                }

                if (response.ResponseStatus == ResponseStatus.TimedOut)
                {
                    errorDetails += $"{Environment.NewLine}{Environment.NewLine}Try increasing the value for '{timeOutInMilliSecondsOptionLabel}' in Tools | Options | {optionName}";
                }
            }

            return errorDetails;
        }

        internal static void SetQuizQuestionErrorDetailsFromErrorDetails(QuizQuestion quizQuestion, string errorDetails)
        {
            quizQuestion.ErrorDetails = errorDetails;
        }
    }
}