using UnityEngine;
using System.Collections;
using GoogleSheetsToUnity;
using System.Collections.Generic;
using System;
using UnityEngine.Events;
using GoogleSheetsToUnity.ThirdPary;

#if UNITY_EDITOR
using UnityEditor;
#endif
public class QuestionSheet : ScriptableObject
{
    public string associatedSheet = "";
    public string associatedWorksheet = "";

    
    internal void UpdateStats(List<GSTU_Cell> list, string QuestionIDX)
    {
        for (int i = 0; i < list.Count; i++)
        {
            switch (list[i].columnId)
            {
                case "Script":
                    {
                        GameManager.InGameData.QuestionDictionary[QuestionIDX] = list[i].value;
                        Debug.Log($"{QuestionIDX}ÀÇ {list[i].value}");
                        break;

                    }
                default: {
                    break;
                    }
            }

        }
    }

}
class Question 
{
    public int QuestionIDX;
    public string Script;
}

