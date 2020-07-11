using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestB : MonoBehaviour
{
    private bool _tf; //  = false
    private int _x; // = 0
    private Bleder _bleder = new Bleder();
    


    
    // Start is called before the first frame update
    void Start()
    {
        var x1 = new Bleder();
        var v = x1.DogAndCat();
        
        var x2 = new Bleder();
        var vv = x2.KeepDogAndCat(1, 1);
        
        var vvv = new Bleder().KeepDogAndCat(1, 1);
        
        Poteto.Chairo();

        var i = 0; // int
        var ii = 0.0f; // foart
        var iii = 0.0d; // double

        if (_tf)
        {
            
        }
        else
        {
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        _bleder.Pok();
    }
}

public class Bleder
{
    private int Dog = 2;
    private int Cat = 2;
    
    public Bleder()
    {
        
    }

    public void Pok()
    {
        
    }

    public int DogAndCat()
    {
        return Dog + Cat * 2;
    }
    
    public void GetDogAndCat(int dog, int cat)
    {
        Dog += dog;
        Cat += cat;
    }
    
    public int KeepDogAndCat(int dog, int cat)
    {
        Dog += dog;
        Cat += cat;
        
        return Dog + Cat;
    }
}

public static class Poteto
{
    public static void Chairo()
    {
        
    }
}