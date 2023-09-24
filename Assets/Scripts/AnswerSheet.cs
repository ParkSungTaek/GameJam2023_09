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
public class AnswerSheet : ScriptableObject
{
    public string associatedSheet = "";
    public string associatedWorksheet = "";

    string AnswerIDX;
    string Gender;
    internal void UpdateStats(List<GSTU_Cell> list, string QuestionIDX)
    {
        if(GameManager.InGameData.AnswerDictionary[QuestionIDX] == null)
        {
            GameManager.InGameData.AnswerDictionary[QuestionIDX] = new Dictionary<string, List<Client.InGameDataManager.Answer>>();
        }
        Client.InGameDataManager.Answer answer = new Client.InGameDataManager.Answer();
        bool Empty = false;

        for (int i = 0; i < list.Count; i++)
        {
            switch (list[i].columnId)
            {
                case "AnswerIDX":
                    {
                        if (list[i].value != null)
                        {

                            AnswerIDX = list[i].value;
                            if (GameManager.InGameData.AnswerDictionary[QuestionIDX][AnswerIDX] == null)
                            {
                                GameManager.InGameData.AnswerDictionary[QuestionIDX][AnswerIDX] = new List<Client.InGameDataManager.Answer>();
                            }
                        }
                        break;
                    }
                case "Gender":
                    {
                        if (list[i].value != null)
                        {

                            Gender = list[i].value;
                            
                        }
                        answer.Gender = Gender;
                        break;

                    }

                case "Face":
                    {
                        answer.Face = list[i].value;
                        break;

                    }
                case "Person":
                    {
                        answer.Person = list[i].value;
                        break;

                    }
                case "Script":
                    {
                        if (list[i].value ==null)
                        {
                            Empty = true;
                        }
                        else
                        {
                            answer.Script = list[i].value;
                        }
                        break;

                    }
                default: {
                    break;
                    }
            }


        }
        if (!Empty)
        {
            GameManager.InGameData.AnswerDictionary[QuestionIDX][AnswerIDX].Add(answer);
            Debug.Log($"QuestionIDX : {QuestionIDX}, AnswerIDX: {AnswerIDX}, Gender : {answer.Gender}, Person : {answer.Person}, Face : {answer.Face}");
        }
    }

}


