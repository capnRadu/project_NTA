using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    [SerializeField] private ScrollRect aboutScroll;
    [SerializeField] private Button historyButton;

    [SerializeField] private ScrollRect historyScroll;
    [SerializeField] private Button backButton;

    public void About(bool open)
    {
        if (open)
        {
            aboutScroll.gameObject.SetActive(false);
            historyButton.gameObject.SetActive(false);

            historyScroll.gameObject.SetActive(true);
            backButton.gameObject.SetActive(true);
        }

        if (!open)
        {
            aboutScroll.gameObject.SetActive(true);
            historyButton.gameObject.SetActive(true);

            historyScroll.gameObject.SetActive(false);
            backButton.gameObject.SetActive(false);
        }
    }
}
