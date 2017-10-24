﻿using EnvDTE;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using Quiz2.GeekQuiz.Common;
using Quiz2.Options;
using System;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Quiz2
{
    [ProvideAutoLoad(UIContextGuids80.SolutionExists)]
    [PackageRegistration(UseManagedResourcesOnly = true)]
    [InstalledProductRegistration(productName: "#110", productDetails: "#112", productId: Vsix.Version, IconResourceID = 400)]
    [Guid(Vsix.Id)]
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "pkgdef, VS and vsixmanifest are valid VS terms")]
    [ProvideOptionPage(typeof(GeneralOptions), Vsix.Name, CommonConstants.CategorySubLevel, 0, 0, true)]
    public sealed class VSPackage : Package
    {
        public const string PackageGuidString = "64f118a1-8d56-45f4-a39f-8972bb67fb2f";

        private DTE dte;
        private SolutionEvents solutionEvents;

        protected override void Initialize()
        {
            base.Initialize();

            IServiceContainer serviceContainer = this as IServiceContainer;
            dte = serviceContainer.GetService(typeof(SDTE)) as DTE;
            solutionEvents = dte.Events.SolutionEvents;

            if (GeneralOptionsDto.ShowTriviaUponOpeningSolution)
            {
                solutionEvents.Opened += OnSolutionOpenedAndOrClosed;
            }

            if (GeneralOptionsDto.ShowTriviaUponClosingSolution)
            {
                solutionEvents.AfterClosing += OnSolutionOpenedAndOrClosed;
            }
        }

        private void OnSolutionOpenedAndOrClosed()
        {
            //ChaseRatings();

            ////////////MessageBoxes.ConfirmCloseWithoutSubmitingAnswer("foo quiz2");

            var shouldShowTrivia = new DecisionMaker().ShouldShowTrivia(GeneralOptionsDto);

            if (shouldShowTrivia)
            {
                var popUpTitle = CommonConstants.GetCaption(Vsix.Name, Vsix.Version);
                var triviaMessage = new TriviaMessage();

                var hiddenOptionsDto = triviaMessage.ShowTrivia(popUpTitle, GeneralOptionsDto.LastPopUpDateTime, GeneralOptionsDto.PopUpCountToday, GeneralOptionsDto.TimeOutInMilliSeconds, Vsix.Name, GeneralOptionsDto.SuppressClosingWithoutSubmitingAnswerWarning, GeneralOptionsDto.TotalQuestionsAnsweredCorrectly, GeneralOptionsDto.TotalQuestionsAsked);

                if (hiddenOptionsDto != null)
                {
                    UpdateHiddenOptions(hiddenOptionsDto);
                }

                triviaMessage.PersistHiddenOptionsEventHandler2 += UpdateHiddenOptions;
            }
        }

        //private void ChaseRatings()
        //{
        //    var hiddenChaserOptions = (IHiddenChaserOptions)GetDialogPage(typeof(HiddenChaserOptions));

        //    var imageByteArray = GetImageByteArray();

        //    var ratingInstructionsDto = new RatingInstructionsDto
        //    {
        //        AggressionLevel = AggressionLevel.High,
        //        CostCategory = CostCategory.Free,
        //        DialogType = DialogType.NonModal,
        //        ImageByteArray = imageByteArray,
        //        VsixAuthor = Vsix.Author,
        //        VsixName = Vsix.Name,
        //    };

        //    RatingChaser.ChaseRatings(hiddenChaserOptions, ratingInstructionsDto);
        //}

        private static byte[] GetImageByteArray()
        {
            byte[] imageByteArray;
            ////////////////////var imageResourceNameArray = Assembly.GetExecutingAssembly().GetManifestResourceNames();
            var imageResourceName = "Trivial.Ui.GeekQuiz.Resources.VsixExtensionIcon_90x90_Embedded.png";//imageResourceNameArray[2];
            var assembly = Assembly.GetExecutingAssembly();
            var stream = assembly.GetManifestResourceStream(imageResourceName);

            if (stream == null)
            {
                imageByteArray = null;
            }
            else
            {
                using (stream)
                {
                    imageByteArray = new byte[stream.Length];
                    stream.Read(imageByteArray, 0, imageByteArray.Length);
                }
            }

            return imageByteArray;
        }

        private void UpdateHiddenOptions(int? totalQuestionsAsked, int? totalQuestionsAnsweredCorrectly)
        {
            var hiddenOptions = (HiddenOptions)GetDialogPage(typeof(HiddenOptions));
            hiddenOptions.TotalQuestionsAnsweredCorrectly = totalQuestionsAnsweredCorrectly.HasValue ? totalQuestionsAnsweredCorrectly.Value : 0;
            hiddenOptions.TotalQuestionsAsked = totalQuestionsAsked.HasValue ? totalQuestionsAsked.Value : 0;
            hiddenOptions.SaveSettingsToStorage();
        }

        private void UpdateHiddenOptions(HiddenOptionsDto hiddenOptionsDto)
        {
            var hiddenOptions = (HiddenOptions)GetDialogPage(typeof(HiddenOptions));
            hiddenOptions.LastPopUpDateTime = hiddenOptionsDto.LastPopUpDateTime;
            hiddenOptions.PopUpCountToday = hiddenOptionsDto.PopUpCountToday;
            hiddenOptions.SaveSettingsToStorage();
        }

        private GeneralOptionsDto GeneralOptionsDto
        {
            get
            {
                var generalOptions = (GeneralOptions)GetDialogPage(typeof(GeneralOptions));
                var hiddenOptions = (HiddenOptions)GetDialogPage(typeof(HiddenOptions));

                return new GeneralOptionsDto
                {
                    LastPopUpDateTime = hiddenOptions.LastPopUpDateTime,
                    MaximumPopUpsWeekDay = generalOptions.MaximumPopUpsWeekDay.GetAsInteger(),
                    MaximumPopUpsWeekEnd = generalOptions.MaximumPopUpsWeekEnd.GetAsInteger(),
                    PopUpIntervalInMins = generalOptions.PopUpIntervalInMins.GetAsInteger(),
                    PopUpCountToday = hiddenOptions.PopUpCountToday,
                    ShowTriviaUponClosingSolution = generalOptions.ShowTriviaUponClosingSolution,
                    ShowTriviaUponOpeningSolution = generalOptions.ShowTriviaUponOpeningSolution,
                    SuppressClosingWithoutSubmitingAnswerWarning = generalOptions.SuppressClosingWithoutSubmitingAnswerWarning,
                    TimeOutInMilliSeconds = generalOptions.TimeOutInMilliSeconds.GetAsInteger(),
                    TotalQuestionsAnsweredCorrectly = hiddenOptions.TotalQuestionsAnsweredCorrectly,
                    TotalQuestionsAsked = hiddenOptions.TotalQuestionsAsked,
                };
            }
        }
    }
}