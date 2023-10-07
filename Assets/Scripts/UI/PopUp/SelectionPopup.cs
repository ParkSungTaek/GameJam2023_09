using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SelectionPopup : UI_Popup
{
    UI_GameScene uI_GameScene;
    System.Random rand = new System.Random();
    const int SelectionNum = 4;
    enum Buttons
    {
        Select0Btn,
        Select1Btn,
        Select2Btn,
        Select3Btn,
    }
    enum Texts
    {
        Select0Txt,
        Select1Txt,
        Select2Txt,
        Select3Txt,
    }
    InGameDataManager data;
    int[] _bindedSelection = new int[SelectionNum];

    // Start is called before the first frame update
    


    public override void Init()
    {
        base.Init();
        Bind<Button>(typeof(Buttons));
        Bind<TMP_Text>(typeof(Texts));

        data = GameManager.InGameData;
        uI_GameScene = GameManager.UI.ShowSceneUI<UI_GameScene>();

        Txt_Setting();
        BindEventBtn();


    }


    
    #region Btn 
    void BindEventBtn()
    {
        BindEvent(GetButton((int)Buttons.Select0Btn).gameObject, Btn_Select0);
        BindEvent(GetButton((int)Buttons.Select1Btn).gameObject, Btn_Select1);
        BindEvent(GetButton((int)Buttons.Select2Btn).gameObject, Btn_Select2);
        BindEvent(GetButton((int)Buttons.Select3Btn).gameObject, Btn_Select3);

    }

    void Btn_Select0(PointerEventData evt)
    {
        int num = data.PopUseableQuestion(0);

        if (data.AnswerDictionary.ContainsKey(num.ToString()))
        {
            int randrange = rand.Next(data.AnswerDictionary[num.ToString()].Count);
            Debug.Log(randrange);
            
        }
        GameManager.UI.ClosePopupUI();
    }
    void Btn_Select1(PointerEventData evt)
    {
        int num = data.PopUseableQuestion(1);
        if (data.AnswerDictionary.ContainsKey(num.ToString()))
        {
            int randrange = rand.Next(data.AnswerDictionary[num.ToString()].Count);
            Debug.Log(randrange);
        }
        GameManager.UI.ClosePopupUI();
    }
    void Btn_Select2(PointerEventData evt)
    {
        int num = data.PopUseableQuestion(2);
        if (data.AnswerDictionary.ContainsKey(num.ToString()))
        {
            int randrange = rand.Next(data.AnswerDictionary[num.ToString()].Count);
            Debug.Log(randrange);
        }
        GameManager.UI.ClosePopupUI();

    }
    void Btn_Select3(PointerEventData evt)
    {
        int num = data.PopUseableQuestion(3);
        if (data.AnswerDictionary.ContainsKey(num.ToString()))
        {
            int randrange = rand.Next(data.AnswerDictionary[num.ToString()].Count);
            Debug.Log(randrange);
        }
        GameManager.UI.ClosePopupUI();
    }

    #endregion Btn 

    #region Txt
    void Txt_Setting()
    {
        InGameDataManager Data = GameManager.InGameData;
        GetText((int)Texts.Select0Txt).text = Data.QuestionDictionary[Data.UseableQuestion[0].ToString()];
        GetText((int)Texts.Select1Txt).text = Data.QuestionDictionary[Data.UseableQuestion[1].ToString()];
        GetText((int)Texts.Select2Txt).text = Data.QuestionDictionary[Data.UseableQuestion[2].ToString()];
        GetText((int)Texts.Select3Txt).text = Data.QuestionDictionary[Data.UseableQuestion[3].ToString()];
    }
    #endregion Txt

}
