using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StickerStatusUI : MonoBehaviour
{
    [SerializeField] private Text statusMain;
    [NonSerialized] public bool isMainUnlocked = false;

    [SerializeField] private Text statusArchitecture;
    [NonSerialized] public bool isArchitectureUnlocked = false;

    [SerializeField] private Text statusAppelbergen;
    [NonSerialized] public bool isAppelbergenUnlocked = false;

    [SerializeField] private Text statusArt;
    [NonSerialized] public bool isArtUnlocked = false;

    [SerializeField] private Text statusSecret;
    [NonSerialized] public bool isSecretUnlocked = false;

    private void Update()
    {
        if (!isMainUnlocked)
        {
            statusMain.text = "Locked";
        }
        else
        {
            statusMain.text = "Unlocked";
        }

        if (!isArchitectureUnlocked)
        {
            statusArchitecture.text = "Locked";
        }
        else
        {
            statusArchitecture.text = "Unlocked";
        }

        if (!isAppelbergenUnlocked)
        {
            statusAppelbergen.text = "Locked";
        }
        else
        {
            statusAppelbergen.text = "Unlocked";
        }

        if (!isArtUnlocked)
        {
            statusArt.text = "Locked";
        }
        else
        {
            statusArt.text = "Unlocked";
        }

        if (!isSecretUnlocked)
        {
            statusSecret.text = "Locked";
        }
        else
        {
            statusSecret.text = "Unlocked";
        }
    }
}
