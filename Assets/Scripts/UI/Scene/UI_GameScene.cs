
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using System.Collections.Generic;
using Client;

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

    #endregion Buttons


}
