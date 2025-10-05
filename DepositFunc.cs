using UnityEngine;

public class SwitchText1Button : MonoBehaviour
{
    public GameObject textToHide;
    public GameObject textToShow;
    public GameObject button1ToHide;
    public GameObject button2ToHide;
    public GameObject textLineToShow;


    public void OnButton1Click()
    {
        if (textToHide != null) textToHide.SetActive(false);
        if (textToShow != null) textToShow.SetActive(true);
        if (button1ToHide != null) button1ToHide.SetActive(false);
        if (button2ToHide != null) button2ToHide.SetActive(false);
        if (textLineToShow != null) textLineToShow.SetActive(true);
    }
}
