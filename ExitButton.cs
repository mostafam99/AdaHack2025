using UnityEngine;

public class ExitButton : MonoBehaviour
{
    public PlayerMovement player;
    public GameObject panelToClose;

    public void ExitButtonClick()
    {
        if (player != null && panelToClose != null)
        {
            player.CloseScreen(panelToClose);
        }
    }
}
