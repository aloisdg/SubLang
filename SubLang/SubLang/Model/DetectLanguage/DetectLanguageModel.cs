using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubLang.Model.DetectLanguage
{
    public class DetectLanguageModel
    {
        public class Result
        {
            public Data data { get; set; }
        }

        public class Data
        {
            public List<Detection> detections { get; set; }
        }

        public class Detection
        {
            public bool isReliable { get; set; }
            public float confidence { get; set; }
            public string language { get; set; }
        }
    }
}
