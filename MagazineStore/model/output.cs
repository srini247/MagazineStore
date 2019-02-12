using System.Collections.Generic;

namespace MagazineStore.Model
{
    class Output
    {
        public Result Data { get; set; }       
        public bool Success { get; set; }
        public string Message { get; set; }
    }

    class Result
    {
        public string TotalTime { get; set; }
        public bool AnswerCorrect { get; set; }
        public List<string> ShouldBe { get; set; }
       
    }
}

