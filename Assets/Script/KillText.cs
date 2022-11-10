using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class KillText : MonoBehaviour
{
    public MainSystem MS;
    public float numberShow;
    public TextMeshProUGUI TM;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        numberShow = 8 - MS.WinPoint;
        TM.text = numberShow.ToString();
    }
}
