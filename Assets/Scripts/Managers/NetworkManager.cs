using UnityEngine;
using System.Collections;
using GoogleSheetsToUnity;
using System.Collections.Generic;
using System;
using UnityEngine.Events;
using GoogleSheetsToUnity.ThirdPary;

//https://console.developers.google.com/

public class NetworkManager
{
    QuestionSheet data1;
    AnswerSheet data2;
    // Start is called before the first frame update
    public void Init()
    {
        data1 = Resources.Load<QuestionSheet>("ScriptableObj/TestData");
        data2 = Resources.Load<AnswerSheet>("ScriptableObj/AnswerSheet");

        if (data2 != null)
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
        UpdateStats1(UpdateMethodOne1);
        UpdateStats2(UpdateMethodOne2);

    }
    void UpdateStats1(UnityAction<GstuSpreadSheet> callback, bool mergedCells = false)
    {
        SpreadsheetManager.Read(new GSTU_Search(data1.associatedSheet, data1.associatedWorksheet), callback, mergedCells);
    }

    void UpdateMethodOne1(GstuSpreadSheet ss)
    {
        int num = ss.rows.secondaryKeyLink.Count - 1;
        try
        {
            for (int idx = 0; idx < num; idx++)
            {
                data1.UpdateStats(ss.rows[idx.ToString()], idx.ToString());
            }
        }
        catch
        (Exception e)
        {
            return;
        }
        finally
        {
            Debug.Log("QuestionFinish");
            Resources.UnloadAsset(data2);
            GameManager.InGameData.Clear();

        }

    }

    void UpdateStats2(UnityAction<GstuSpreadSheet> callback, bool mergedCells = false)
    {
        SpreadsheetManager.Read(new GSTU_Search(data2.associatedSheet, data2.associatedWorksheet), callback, mergedCells);
    }

    void UpdateMethodOne2(GstuSpreadSheet ss)
    {
        int num = ss.rows.secondaryKeyLink.Count - 1;
        Debug.Log(num);

        try
        {
            for (int idx = 0; idx < num; idx++)
            {
                data2.UpdateStats(ss.rows[idx.ToString()]);

            }
        }
        catch
        {
            return;
        }
        finally
        {
            Debug.Log("AnswerFinish");
            Resources.UnloadAsset(data2);
        }

    }
}
