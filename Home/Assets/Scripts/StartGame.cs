using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    private GameObject UIPanel = null;
    // Use this for initialization
    void Start()
    {
        GameObject UIPanelPrefab = (GameObject)Resources.Load("Prefab/UIPanel");

        UIPanel = Instantiate(UIPanelPrefab) as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
         
    }
}
