using UnityEngine;

public class SwitchTextButton : MonoBehaviour
{
    public GameObject textToHide;
    public GameObject textToShow;
    public GameObject buttonToHide;
    public GameObject button1ToShow;
    public GameObject button2ToShow;


    public void OnButtonClick()
    {
        if (textToHide != null) textToHide.SetActive(false);
        if (textToShow != null) textToShow.SetActive(true);
        if (buttonToHide != null) buttonToHide.SetActive(false);
        if (button1ToShow != null) button1ToShow.SetActive(true);
        if (button2ToShow != null) button2ToShow.SetActive(true);
    }
}
