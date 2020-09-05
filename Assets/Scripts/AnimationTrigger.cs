using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTrigger : MonoBehaviour
{
    Animator anim;
    public bool Trigger1 = false;
    public bool Trigger2 = false;
    public bool Trigger3 = false;
    public bool Trigger4 = false;
    public bool Trigger5 = false;
    void Start()
    {
        //Get the Animator attached to the GameObject you are intending to animate.
        anim = gameObject.GetComponent<Animator>();
    }

    void Update()
    {

    }
        void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Trigger1")
        {
            Trigger1 = true;
        }
        else if (other.tag == "Trigger2")
        {
            Trigger2 = true;
        }
        else if (other.tag == "Trigger3")
        {
            Trigger3 = true;
        }
        else if (other.tag == "Trigger4")
        {
            Trigger4 = true;
        }
        else if (other.tag == "Trigger5")
        {
            Trigger5 = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Trigger1")
        {
            Trigger1 = false;
        }
        else if (other.tag == "Trigger2")
        {
            Trigger2 = false;
        }
        else if (other.tag == "Trigger3")
        {
            Trigger3 = false;
        }
        else if (other.tag == "Trigger4")
        {
            Trigger4 = false;
        }
        else if (other.tag == "Trigger5")
        {
            Trigger5 = false;
        }
    }
}
