﻿using System.Collections.Generic;

namespace Quiz.Ui.Gateway
{
    public class QuestionsMine
    {
        public static IEnumerable<GatewayResponse> GetGatewayResponses()
        {
            var gatewayResponses = new List<GatewayResponse>
            {
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", ""),

            };

            return gatewayResponses;
        }
    }
}
