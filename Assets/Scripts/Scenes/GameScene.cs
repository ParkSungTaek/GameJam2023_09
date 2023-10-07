using UnityEngine;

public class GameScene : MonoBehaviour
{
    private void Start()
    {
        GameManager.UI.ShowPopupUI<SelectionPopup>();
    
    }
}
