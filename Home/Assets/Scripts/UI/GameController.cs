using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum BtnName
{
    ComputerBtn,

}

public class GameController : MonoBehaviour
{

    public GameObject computerPanel;
    public GameObject homePanel;

    // Use this for initialization
    void Start()
    {
        computerPanel = transform.Find("ComputerPanel").gameObject;
        homePanel = transform.Find("HomePanel").gameObject;

        foreach (var homeChild in homePanel.transform.GetComponentsInChildren<Button>())
        {
            switch (homeChild.name)
            {
                case "ComputerBtn":
                    homeChild.onClick.AddListener(() => OpenComputerPanel());
                    break;

                default:
                    break;
            }
        }


    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OpenComputerPanel()
    {
        computerPanel.SetActive(true);
    }

}
