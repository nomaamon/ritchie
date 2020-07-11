using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestA : MonoBehaviour
{
    private int[] points_a = new[]
    {
        90,100,2001029
    };
    
    private int[] points_b = new int[1];
    
    private List<int> list_a = new List<int>();
    
    // Start is called before the first frame update
    void Start()
    {
        list_a.Add(100);
        list_a.Add(200);

        for (int i = 0; i < 10; i++)
        {
            list_a.Add(i);
        }

        int k = 0;
        foreach (var value in list_a)
        {
            Debug.Log("index: " + k + " " + value);
            k++;
        }
        k = 0;
        
        Debug.Log("--------- remove value 0 ---------");
        
        list_a.Remove(0);
        foreach (var value in list_a)
        {
            Debug.Log("index: " + k + " " + value);
            k++;
        }
        k = 0;
        
        Debug.Log("--------- remove index 0 ---------");
        list_a.RemoveAt(0);
        
        foreach (var value in list_a)
        {
            Debug.Log("index: " + k + " " + value);
            k++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
