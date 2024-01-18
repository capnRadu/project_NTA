using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsUI : MonoBehaviour
{
    [SerializeField] private Button stickersButton;
    [SerializeField] private GameObject stickersInventory;

    [SerializeField] private ScrollRect mainScroll;
    [SerializeField] private ScrollRect architectureScroll;
    [SerializeField] private ScrollRect appelbergenScroll;
    [SerializeField] private ScrollRect artScroll;
    [SerializeField] private ScrollRect secretScroll;

    private StickerStatusUI m_StickerStatus;

    private void Start()
    {
        m_StickerStatus = FindObjectOfType<StickerStatusUI>();
    }

    public void HandleInventory(bool open)
    {
        if (open)
        {
            stickersButton.gameObject.SetActive(true);
            stickersInventory.SetActive(false);
        }

        if (!open)
        {
            stickersButton.gameObject.SetActive(false);
            stickersInventory.SetActive(true);
        }
    }

    public void HandleScrollMenuClose(bool open)
    {
        if (!open)
        {
            GameObject.FindWithTag("Sticker UI").SetActive(false);
            stickersInventory.SetActive(true);
        }
    }

    public void OpenSticker(string sticker)
    {
        switch (sticker)
        {
            case "main":
                if (m_StickerStatus.isMainUnlocked)
                {
                    mainScroll.gameObject.SetActive(true);
                    stickersInventory.SetActive(false);
                }
                break;
            case "architecture":
                if (m_StickerStatus.isArchitectureUnlocked)
                {
                    architectureScroll.gameObject.SetActive(true);
                    stickersInventory.SetActive(false);
                }
                break;
            case "appelbergen":
                if (m_StickerStatus.isAppelbergenUnlocked)
                {
                    appelbergenScroll.gameObject.SetActive(true);
                    stickersInventory.SetActive(false);
                }
                break;
            case "art":
                if (m_StickerStatus.isArtUnlocked)
                {
                    artScroll.gameObject.SetActive(true);
                    stickersInventory.SetActive(false);
                }
                break;
            case "secret":
                if (m_StickerStatus.isSecretUnlocked)
                {
                    secretScroll.gameObject.SetActive(true);
                    stickersInventory.SetActive(false);
                }
                break;
        }
    }
}
