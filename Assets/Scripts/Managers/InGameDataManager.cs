using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Client
{
    public class InGameDataManager
    {


        public Dictionary<string, string> QuestionDictionary = new Dictionary<string, string>();
        
        public Dictionary<string, Dictionary<string, List<Answer>>> AnswerDictionary = new Dictionary<string, Dictionary<string, List<Answer>>>();

        public class Answer 
        {
            public string Gender;
            public string Person;
            public string Face;
            public string Script;
        }


        // <summary> InGameData 게임 시작시 초기화</summary>
        public void Init()
        {
            
        }


        /// <summary> 게임 플레이 정보 초기화 </summary>
        public void Clear()
        {
            
        }
    }

}
