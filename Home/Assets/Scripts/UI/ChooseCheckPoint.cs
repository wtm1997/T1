using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseCheckPoint : MonoBehaviour
{
    public Button firstCheckPoint;
    public GameObject HomePanel;
    public Object Home;
    // Use this for initialization
    void Start()
    {
        foreach (var checkPoint in transform.GetComponentsInChildren<Button>())
        {
            checkPoint.onClick.AddListener(() => EnterHomeMap());
        }
        Home = Resources.Load("Prefab/GamePanel");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void EnterHomeMap()
    {
        this.transform.gameObject.SetActive(false);
        HomePanel = Instantiate(Home) as GameObject;
    }
}
