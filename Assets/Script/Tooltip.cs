/*using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using CodeMonkey.Utils;
using System;

public class Tooltip : MonoBehaviour
{
    [Serializable]
    private Camera uiCamera;

    private Text tooltipText;
    private RectTransform backgroundRectTransform;

    private void Awake()
    {
        backgroundRectTransform = backgroundRectTransform.Find("background").GetComponent<RectTransform>();
        tooltipText = transform.Find("text").GetComponent<Text>();

        ShowTooltip("Random tooltip text");

        FunctionPeriodic.Create(() =>
        {
            string abc = "abcoiwo iehgosdnk afnfp+\ngpjgidfbasjbdwqwrioj";
            string showText = "";
            for (int i = 0; i < UnityEngine.Random.Range(30, 150); i++)
            {
                showText += abc[UnityEngine.Random.Range(0, abc.Length)];
            }
            ShowTooltip(showText);
        }, .5f);
    }

    public void Update()
    {
        Vector2 localPoint;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(transform.parent.GetComponent<RectTransform>(), Input.mousePosition, uiCamera, out localPoint);
        transform.localPosition = localPoint;
    
    }

    private void ShowTooltip(string tooltipString)
    {
        gameObject.SetActive(true);

        tooltipText.text = tooltipString;
        float textPaddingSize = 4f;
        Vector2 backgroundSize = new Vector2(tooltipText.preferredWidth + textPaddingSize * 2f, tooltipText.preferredHeight + textPaddingSize * 2f);
        backgroundRectTransform.sizeDelta = backgroundSize;
    }

    private void HideTooltip()
    {
        gameObject.SetActive(false);
    }

}*/
