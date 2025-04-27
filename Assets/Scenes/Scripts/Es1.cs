using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Es1 : MonoBehaviour

{
    public int num = 0;
    public int index = 10;
    // Start is called before the first frame update
    void Start()
    {
        while (index >= 0)
        {
            Debug.Log($"{num}");
            num++;
            index--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
