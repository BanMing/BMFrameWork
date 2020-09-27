using UnityEngine;
using System.Collections;
using System;
using System.Threading.Tasks;

public class InstantitateTest : MonoBehaviour
{

    public GameObject go;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void InstantiateByAsync()
    {
        int index = 0;

        Action<GameObject> callbcak = (go) =>
        {
            go.transform.localScale = Vector3.one;
            go.transform.position = Vector3.one * index;
            index++;
        };
        InstantiateTool.Instance.InstantiateByAsync(go, 1000, callbcak, 100);
        Debug.Log("finish?");
    }
}
