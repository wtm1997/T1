using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{

    public GameObject startPanel;
    public GameObject selectPanel;
    public Button startBtn;

    // Use this for initialization
    void Start()
    {
        startPanel = transform.Find("StartGame").gameObject;
        selectPanel = transform.Find("SelectionPanel").gameObject;

        startBtn = startPanel.GetComponentInChildren<Button>();
        startBtn.onClick.AddListener(() => StartBtn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartBtn()
    {
        if(startPanel != null)
        {
            startPanel.SetActive(false);
            selectPanel.SetActive(true);
        }
    }
}
