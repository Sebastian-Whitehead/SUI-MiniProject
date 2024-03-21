using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GestureEventProcessor : MonoBehaviour
{
    public float simmilarityThreshold = 0.5f;
    public UnityEvent m_LWritstFlickEvent;
    public UnityEvent m_RWritstFlickEvent;


    // Start is called before the first frame update
    void Start()
    {
        if (m_LWritstFlickEvent == null) m_LWritstFlickEvent = new UnityEvent();
        if (m_RWritstFlickEvent == null) m_RWritstFlickEvent = new UnityEvent();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnGestureCompleted(GestureCompletionData gestureCompletionData)
    {
        if (gestureCompletionData.gestureID < 0)
        {
            string errorMessage = GestureRecognition.getErrorMessage(gestureCompletionData.gestureID);
            return;
        }

        if(gestureCompletionData.similarity >= simmilarityThreshold)
        {
            //// Test gestureID to determine which gesture is being detected.
            /// if(gestureID = x){ m_LWristFlick.invoke() }
            /// ...
        }
    }


}
