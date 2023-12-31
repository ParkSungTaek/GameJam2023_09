using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class InGameDataManager
{

    public List<int> UseableQuestion;


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

    /// <summary>
    /// idx 번째 숫자를 반환하고 Pop함
    /// </summary>
    /// <param name="idx"></param>
    /// <returns></returns>
    public int PopUseableQuestion(int idx)
    {
        int tmp = UseableQuestion[idx];
        UseableQuestion.RemoveAt(idx);
        return tmp;
    }
    /// <summary> 게임 플레이 정보 초기화 </summary>
    public void Clear()
    {
        System.Random rand = new System.Random();
        //UseableQuestion = Enumerable.Range(0, QuestionDictionary.Count).ToList();
        ///지금은 11번 질문까지만 정상 작동 
        UseableQuestion = Enumerable.Range(0, 12).ToList();

        UseableQuestion = UseableQuestion.OrderBy(x => rand.Next()).ToList();
        
    }
}

