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

    private StickerStatusUI m_StickerStatusUI;

    private void OnEnable()
    {
        m_ScannedStickers = FindObjectOfType<ScannedStickers>();
        m_StickerStatusUI = FindObjectOfType<StickerStatusUI>();

        if (this.gameObject.tag != "Main Flyer" && this.gameObject.tag != "Secret Sticker" && !alreadyScanned)
        {
            m_ScannedStickers.scannedStickersCount++;
            alreadyScanned = true;
        }
        
        switch (this.gameObject.tag)
        {
            case "Main Flyer":
                m_StickerStatusUI.isMainUnlocked = true;
                break;
            case "Architecture Sticker":
                m_StickerStatusUI.isArchitectureUnlocked = true;
                break;
            case "Appelbergen Sticker":
                m_StickerStatusUI.isAppelbergenUnlocked = true;
                break;
            case "Art Sticker":
                m_StickerStatusUI.isArtUnlocked = true;
                break;
            case "Secret Sticker":
                if (m_StickerStatusUI.isArchitectureUnlocked && m_StickerStatusUI.isAppelbergenUnlocked && m_StickerStatusUI.isArtUnlocked)
                {
                    m_StickerStatusUI.isSecretUnlocked = true;
                }
                break;
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
