using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    [SerializeField] private Text generalText;
    [SerializeField] private Text aboutText;
    [SerializeField] private Button historyButton;
    [SerializeField] private Button backButton;

    public void About(bool open)
    {
        if (open)
        {
            generalText.gameObject.SetActive(false);
            historyButton.gameObject.SetActive(false);

            aboutText.gameObject.SetActive(true);
            backButton.gameObject.SetActive(true);
        }

        if (!open)
        {
            generalText.gameObject.SetActive(true);
            historyButton.gameObject.SetActive(true);

            aboutText.gameObject.SetActive(false);
            backButton.gameObject.SetActive(false);
        }
    }

    public void OpenURL(string URL)
    {
        Application.OpenURL(URL);
    }
}
