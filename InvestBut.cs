using UnityEngine;

public class InvestBut : MonoBehaviour
{
    public PlayerMovement player;
    public GameObject scenePanel;

    private bool isSceneOpen = false;

    public void OnToggleButtonClick()
    {
        if (player == null || scenePanel == null) return;

        if (isSceneOpen == false)
        {
            scenePanel.SetActive(true);
            Time.timeScale = 0f;
            player.canMove = false;
            isSceneOpen = true;
        }
        else
        {
            scenePanel.SetActive(false);
            Time.timeScale = 1f;
            player.canMove = true;
            isSceneOpen = false;
        }
    }
} 
