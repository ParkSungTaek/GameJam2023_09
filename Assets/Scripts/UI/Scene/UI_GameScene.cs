
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using System.Collections.Generic;
using static InGameDataManager;

public class UI_GameScene : UI_Scene
{
    enum GameObjects
    {

    }
    enum Buttons
    {
        Option,
    }
    enum Texts
    {

    }
    private void Start()
    {
        Init();
    }
    public override void Init()
    {
        base.Init();
        Bind<GameObject>(typeof(GameObjects));
        Bind<Button>(typeof(Buttons));
        Bind<TMP_Text>(typeof(Texts));

        ButtonBind();



    }



    #region Buttons
    void ButtonBind()
    {
        BindEvent(GetButton((int)Buttons.Option).gameObject, Btn_Option);

    }
    void Btn_Option(PointerEventData evt)
    {
        GameManager.UI.ShowPopupUI<OptionPopup>();
    }
    public void PlayList(int QuestionIDX)
    {
        List<Answer> answers;

        //answers = GameManager.InGameData.QuestionDictionary[QuestionIDX][];
        
        Debug.Log(QuestionIDX);
    }

    #endregion Buttons


}
