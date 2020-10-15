using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class ToolTips : MonoBehaviour
{
    [Header("Object Text Information")]
    public string objectName;
   // [TextArea]
   // public string objectInfo;

    [Header("Display the inforation")]
    public GameObject toolTipWindow;
    public Text displayName;
   // public Text displayInfo;


    void OnMouseEnter()
    {
        toolTipWindow.SetActive(true);

        if (toolTipWindow != null)
        {
            displayName.text = objectName;
          //  displayInfo.text = objectInfo;
        }
    }

    void OnMouseExit()
    {
        toolTipWindow.SetActive(false);
    }
}
