using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAcessGameManager : MonoBehaviour
{
    private object instance;

    // Start is called before the first frame update
    void Start()
    {
        if (instance != null)
        {
            GameManager.instance.ReduceLivesByOne();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance != null)
        {
            GameManager.instance.PrintHello();
        }
    }

}
