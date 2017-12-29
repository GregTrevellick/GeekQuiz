﻿using VsixRatingChaser;
using VsixRatingChaser.Interfaces;

namespace Quiz.Rating
{
    public class ChaserGateway
    {
        public static IChaseOutcomeDto Probe(IRatingDetailsDto ratingDetailsDto, IExtensionDetailsDto extensionDetailsDto)
        {
            var chaser = new Chaser();
            var chaseOutcomeDto = chaser.Chase(ratingDetailsDto, extensionDetailsDto);
            return chaseOutcomeDto;
        }
    }
}