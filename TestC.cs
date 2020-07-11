using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestC : MonoBehaviour
{
    private Dictionary<int, string> dic_a = new Dictionary<int, string>();
    
    private Dictionary<int, List<string>> dic_list = new Dictionary<int, List<string>>();
    
    // Start is called before the first frame update
    void Start()
    {
        dic_a.Add(0, "ken");
        dic_a.Add(1, "taro");

        for (int i = 2; i < 10; i++)
        {
            dic_a.Add(i, "maruko" + i);
        }

        foreach (KeyValuePair<int, string> kvp in dic_a)
        {
            Debug.Log(kvp.Key + " " + kvp.Value);
        }
        
        Debug.Log(dic_a[0]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
