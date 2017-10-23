﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GeekQuiz.Ui.GeekQuiz.Common;
using GeekQuiz.Ui.GeekQuiz.Gateway;

namespace GeekQuiz.Ui
{
    /// <summary>
    /// Interaction logic for GeekDialog.xaml
    /// </summary>
    public partial class GeekDialog : UserControl
    {
        private string _correctAnswer;
        private string _optionsName;
        public QuestionType _questionType;
        public bool _suppressClosingWithoutSubmitingAnswerWarning;
        public int? _totalQuestionsAnsweredCorrectly;
        public int? _totalQuestionsAsked;
        private bool _userStatusTotalsIncremented;
        public delegate void MyEventHandler(int? totalQuestionsAsked, int? totalQuestionsAnsweredCorrectly);
        public event MyEventHandler PersistHiddenOptionsEventHandler;

        public GeekDialog(string optionsName)
        {
            _optionsName = optionsName;
            _userStatusTotalsIncremented = false;

            InitializeComponent();

            InitializeTriviaDialog();

            DataContext = this;

            StackPanelGeekQuiz.Visibility = Visibility.Visible;
        }

        private void InitializeTriviaDialog()
        {
            //HasMaximizeButton = true;
            //HasMinimizeButton = true;
            //SizeToContent = SizeToContent.WidthAndHeight;
            //WindowStartupLocation = WindowStartupLocation.CenterScreen;

            //var iconUri = new TriviaMessage().GetIconUri();
            //Icon = new BitmapImage(iconUri);
        }

        private void AppBtnHelp_OnClick(object sender, RoutedEventArgs e)
        {
            if (TextBlockHelp.Visibility == Visibility.Visible)
            {
                TextBlockHelp.Visibility = Visibility.Collapsed;
            }
            else
            {
                TextBlockHelp.Text = $"To alter frequency and volume of delivery go to Tools | Options | {_optionsName}";
                TextBlockHelp.Visibility = Visibility.Visible;
            }
        }

        private void AppBtnClose_OnClick(object sender, RoutedEventArgs e)
        {
            var shouldClose = true;

            if (_questionType != QuestionType.None)
            {
                if (AppBtnGeekQuizSubmitMultiChoiceAnwser.IsEnabled)
                {
                    if (!_suppressClosingWithoutSubmitingAnswerWarning)
                    {
                        var closeWithoutSubmitingAnswer = MessageBoxes.ConfirmCloseWithoutSubmitingAnswer(_optionsName);

                        if (!closeWithoutSubmitingAnswer)
                        {
                            shouldClose = false;
                        }
                    }
                }
            }

            if (shouldClose)
            {
                //Close();
            }
        }

        private void AppBtnSubmitMultiChoiceAnwser_OnClick(object sender, RoutedEventArgs e)//GeekQuiz
        {
            string response;

            if (RadioBtn1.IsChecked == true)
            {
                response = RadioBtn1.Content.ToString();
            }
            else
            {
                if (RadioBtn2.IsChecked == true)
                {
                    response = RadioBtn2.Content.ToString();
                }
                else
                {
                    if (RadioBtn3.IsChecked == true)
                    {
                        response = RadioBtn3.Content.ToString();
                    }
                    else
                    {
                        if (RadioBtn4.IsChecked == true)
                        {
                            response = RadioBtn4.Content.ToString();
                        }
                        else
                        {
                            response = null;
                        }
                    }
                }
            }

            ActOnAnswerGivenGeekQuiz(response);
        }

        private void ActOnAnswerGivenGeekQuiz(string response)
        {
            GeekQuizReplyEmoticonCorrect.Visibility = Visibility.Collapsed;
            GeekQuizReplyEmoticonIncorrect.Visibility = Visibility.Collapsed;

            var isResponseCorrect = IsResponseCorrectGeekQuiz(response);

            if (isResponseCorrect)
            {
                TextBlockGeekQuizReply.Text = "Well,done - correct answer !";
                SetQuizReplyColourGeekQuiz(Colors.Green);
                AppBtnGeekQuizSubmitMultiChoiceAnwser.IsEnabled = false;
                GeekQuizReplyEmoticonCorrect.Visibility = Visibility.Visible;

                if (!_userStatusTotalsIncremented && _totalQuestionsAnsweredCorrectly.HasValue)
                {
                    _totalQuestionsAnsweredCorrectly++;
                }
            }
            else
            {
                if (response == null)
                {
                    TextBlockGeekQuizReply.Text = "No cheating please - you must supply an answer.";
                    SetQuizReplyColourGeekQuiz(Colors.Orange);
                }
                else
                {
                    TextBlockGeekQuizReply.Text = "Oh dear - wrong answer.";

                    if (_questionType == QuestionType.MultiChoice)
                    {
                        TextBlockGeekQuizReply.Text += $" The correct answer is {_correctAnswer}";
                    }

                    AppBtnGeekQuizSubmitMultiChoiceAnwser.IsEnabled = false;
                    SetQuizReplyColourGeekQuiz(Colors.Red);
                    GeekQuizReplyEmoticonIncorrect.Visibility = Visibility.Visible;
                }
            }

            TextBlockGeekQuizReply.Visibility = Visibility.Visible;

            if (!_userStatusTotalsIncremented && _totalQuestionsAsked.HasValue)
            {
                _totalQuestionsAsked++;
                _userStatusTotalsIncremented = true;
            }
            var userStatus = GetUserStatusGeekQuiz(_totalQuestionsAnsweredCorrectly, _totalQuestionsAsked);
            AppTextBlockGeekQuizUserStatus.Text = userStatus;

            PersistHiddenOptionsEventHandler?.Invoke(_totalQuestionsAsked, _totalQuestionsAnsweredCorrectly);
        }

        internal string GetUserStatusGeekQuiz(int? totalQuestionsAnsweredCorrectly, int? totalQuestionsAsked)
        {
            int percentageSuccess;

            if (totalQuestionsAsked == 0 ||
                !totalQuestionsAnsweredCorrectly.HasValue ||
                !totalQuestionsAsked.HasValue)
            {
                percentageSuccess = 0;
            }
            else
            {
                //gregt unit test required
                double percentage = ((double)totalQuestionsAnsweredCorrectly.Value / totalQuestionsAsked.Value) * 100;
                percentageSuccess = (int)Math.Round(percentage, MidpointRounding.AwayFromZero);
            }

            var userStatusDescription = percentageSuccess.UserStatusDescription();

            var ranking = "Your rank: " + userStatusDescription;

            var successRate = percentageSuccess + "% success rate (" +
                              totalQuestionsAnsweredCorrectly + " out of " +
                              totalQuestionsAsked + ")";

            var userStatus = ranking + " " + successRate;

            return userStatus;
        }

        private void SetQuizReplyColourGeekQuiz(Color color)
        {
            TextBlockGeekQuizReply.Foreground = new SolidColorBrush(color);
        }

        private bool IsResponseCorrectGeekQuiz(string response)
        {
            var rightAnswer = response == _correctAnswer;

            return rightAnswer;
        }

    }
}
