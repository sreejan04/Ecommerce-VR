using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class PanelController : MonoBehaviour
{
    public Button but1;
    public Button but2;
    public Toggle tog1;
    public Toggle tog2;
    public GameObject a1;
    public GameObject a2;
    public Material m1;
    // Start is called before the first frame update
    void Start()
    {
        a2.SetActive(false);
        m1.color = Color.white;
    }

    void but1click()
    {
        a2.SetActive(true);
        a1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        but1.onClick.AddListener(but1click);
        if(tog1.isOn)
        {
            m1.color = Color.white;
        }
        else 
        {
            m1.color = Color.green;
        }
    }
}
