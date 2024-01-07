using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class flyerEnable : MonoBehaviour
{
    [SerializeField] private Text generalText;
    [SerializeField] private Text aboutText;
    [SerializeField] private Button historyButton;
    [SerializeField] private Button backButton;

    private void OnEnable()
    {
        aboutText.gameObject.SetActive(false);
        backButton.gameObject.SetActive(false);
        generalText.gameObject.SetActive(true);
        historyButton.gameObject.SetActive(true);
        GetComponent<Animator>().enabled = false;
        GetComponent<Animator>().enabled = true;
    }
}
