using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppliedMathIncrement : MonoBehaviour
{
    int intval = 0;
    float floatval = 1.345f;


    public Text inttext;
    public Text floattext;


    public void StartCount() {

        intval += 1;
        floatval += floatval / 100f;

        inttext.GetComponent<Text>().text = intval.ToString();
        floattext.GetComponent<Text>().text = floatval.ToString();

    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
