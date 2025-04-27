using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Es2 : MonoBehaviour
{
    public int [] numbers = { 10, 20, 30, 40 };
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            if(i == 2)
            {
                break;
            }
            Debug.Log($"La somma è: {numbers[i] + numbers[i]}");
            Debug.Log($"Il prodotto è: {numbers[i] * numbers[i]}");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
