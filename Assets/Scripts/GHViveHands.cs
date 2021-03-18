using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GHViveHands : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //This debug's the current state of the hands
        if (ViveHandTracking.GestureProvider.LeftHand != null)
            Debug.Log("Left gesture is " + ViveHandTracking.GestureProvider.LeftHand.gesture);
        if (ViveHandTracking.GestureProvider.RightHand != null)
            Debug.Log("Right gesture is " + ViveHandTracking.GestureProvider.RightHand.gesture);
    }
}
