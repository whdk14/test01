using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class TextSp : MonoBehaviour
{
    public TMP_Text text;

    string TextBar;

    private void Start()
    {
        text = GetComponent<TMP_Text>();
        TextBar = "Hello World, Test massage";
        StartCoroutine(Typing(TextBar));
    }

    IEnumerator Typing(string Talk)
    {
        text.text = null;

        for(int i = 0; i < Talk.Length; i++)
        {
            text.text += Talk[i];

            yield return new WaitForSeconds(0.1f);
        }
    }
}