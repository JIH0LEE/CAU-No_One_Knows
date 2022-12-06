using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShoeGrabController : MonoBehaviour
{

    public Text shoeText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void grab(string name){
        shoeText.text = name;
    }
}
