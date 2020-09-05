using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MudarCorObjetos : MonoBehaviour
{
    public Material background;
    public Material TouchColor;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().material = background;
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        GetComponent<Renderer>().material = TouchColor;        
    }
    void OnMouseUp()
    {
        GetComponent<Renderer>().material = background;
    }
}
