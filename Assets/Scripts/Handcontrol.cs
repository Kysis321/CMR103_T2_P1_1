using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Handcontrol : MonoBehaviour
{
    //Reference to components that can be grabbed
    public GameObject ComponentOne;
    public GameObject ComponentTwo;
    public GameObject ComponentThree;

    



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      

    }

    private void OnCollisionStay(Collision collision)
    {
        if (ViveHandTracking.GestureProvider.RightHand.gesture == ViveHandTracking.GestureType.OK)
        {
            Pickup();
        }
        else
        {
            Drop();
        }


    }

    public void Pickup()
    {

    }

    public void Drop()
    {

    }


}
