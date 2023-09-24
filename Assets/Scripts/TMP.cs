using GoogleSheetsToUnity;
using System.Collections;
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

public class TMP : MonoBehaviour
{
    QuestionSheet data;
    // Start is called before the first frame update
    void Start()
    {
        data = Resources.Load<QuestionSheet>("ScriptableObj/TestData");
        if(data != null)
        {
            Debug.Log("GET");
            Run();
        }
        else
        {
            Debug.Log("Can't");
        }
    }
    public void Run()
    {
        UpdateStats(UpdateMethodOne);
    }
    void UpdateStats(UnityAction<GstuSpreadSheet> callback, bool mergedCells = false)
    {
        SpreadsheetManager.Read(new GSTU_Search(data.associatedSheet, data.associatedWorksheet), callback, mergedCells);
    }

    void UpdateMethodOne(GstuSpreadSheet ss)
    {
        int num = ss.rows.secondaryKeyLink.Count-1;

        for(int idx = 0; idx < num; idx++)
        {
            data.UpdateStats(ss.rows[idx.ToString()], idx.ToString());
        }

            
    }

}
