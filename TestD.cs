using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class TestD : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Mark(Mark2);
        Mark(() =>
        {
            
        });
        
        Pancer(Pancer2);
        
        
    }

    private async Task Doraemon()
    {
        // scene 切り替わる処理
        
        // scene 暗転アニメ―ション

        // ローディング
        var x = await Doramichan(); // 通信
        
        // 新しいscene遷移後の処理
    }
    
    private async Task<int> Doramichan()
    {
        return 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Mark(Action action)
    {
        action();
    }

    private void Mark2()
    {
        
    }

    private void Pancer(Action<int, string> action)
    {
        action(10, "aaa");
    }

    private void Pancer2(int i, string s)
    {
        
    }
    
}
