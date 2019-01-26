using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComputerController : MonoBehaviour
{
    public Button closeComputerBtn;

    // Use this for initialization
    void Start()
    {
        foreach (var child in transform.GetComponentsInChildren<Button>())
        {
            switch (child.name)
            {
                case "CloseComputerBtn":
                    child.onClick.AddListener(() => CloseComputer());
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

    public void CloseComputer()
    {
        transform.gameObject.SetActive(false);
    }
}
