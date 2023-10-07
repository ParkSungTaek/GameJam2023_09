
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UI_Title : UI_Scene
{

    enum Buttons
    {
        Start,
        ExitGame,
        Gallery,
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
        Bind<Button>(typeof(Buttons));

        ButtonBind();



    }



    #region Buttons
    void ButtonBind()
    {
        BindEvent(GetButton((int)Buttons.Start).gameObject, Btn_Start);

    }
    void Btn_Start(PointerEventData evt)
    {
        Debug.Log("Btn_Start");
        SceneManager.LoadScene(Define.Scenes.Game);
    }
    public void PlayList(int QuestionIDX)
    {

        Debug.Log(QuestionIDX);
    }

    #endregion Buttons


}
