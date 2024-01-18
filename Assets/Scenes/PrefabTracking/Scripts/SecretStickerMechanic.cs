using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SecretStickerMechanic : MonoBehaviour
{
    [SerializeField] private ScrollRect aboutScroll;
    [SerializeField] private TextMeshProUGUI lockedText;

    private ScannedStickers m_ScannedStickers;

    private void OnEnable()
    {
        m_ScannedStickers = FindObjectOfType<ScannedStickers>();

        if (m_ScannedStickers.scannedStickersCount >= 3)
        {
            aboutScroll.gameObject.SetActive(true);
            lockedText.gameObject.SetActive(false);
        }
        else
        {
            aboutScroll.gameObject.SetActive(false);
            lockedText.gameObject.SetActive(true);
        }
    }
}
