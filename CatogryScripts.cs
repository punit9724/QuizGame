using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


[System.Serializable]
    class Catogry
    { 
        public string CatName;
        public questions[] AllQuestions;
    }
    [System.Serializable]
    class questions
    {
        public string QuestionName;
        public Options[] AllOptions;
        public string Answers;
}
[System.Serializable]
    class Options
    {
        public string OPTIONS;
       
    }


