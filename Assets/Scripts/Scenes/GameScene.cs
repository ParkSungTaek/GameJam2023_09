using UnityEngine;

public class GameScene : MonoBehaviour
{
    private void Start()
    {
        GameManager.UI.ShowSceneUI<UI_GameScene>();
        //GameManager.UI.ShowPopUpUI<UI_ClassSelect>();

        
        //StartCoroutine(GameManager.InGameData.Cooldown.CooldownCoroutine());
    }
}
