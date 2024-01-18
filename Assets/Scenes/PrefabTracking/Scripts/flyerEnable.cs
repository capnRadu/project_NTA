using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class flyerEnable : MonoBehaviour
{
    /*
    [SerializeField] private ScrollRect aboutScroll;
    [SerializeField] private Button historyButton;

    [SerializeField] private ScrollRect historyScroll;
    [SerializeField] private Button backButton;
    */

    private ScannedStickers m_ScannedStickers;
    private bool alreadyScanned = false;

    private void OnEnable()
    {
        m_ScannedStickers = FindObjectOfType<ScannedStickers>();

        if (!alreadyScanned)
        {
            m_ScannedStickers.scannedStickersCount++;
            alreadyScanned = true;
        }

        /*
        historyScroll.gameObject.SetActive(false);
        backButton.gameObject.SetActive(false);

        aboutScroll.gameObject.SetActive(true);
        historyButton.gameObject.SetActive(true);

        GetComponent<Animator>().enabled = false;
        GetComponent<Animator>().enabled = true;
        */
    }
}
