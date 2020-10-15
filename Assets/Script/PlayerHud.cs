using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHud : MonoBehaviour
{
    public Text pName;
    // Start is called before the first frame update
    void Start()
    {
        pName = GetComponentInChildren<Text>();
        pName.text = "" + PlayerPrefs.GetString("name");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
