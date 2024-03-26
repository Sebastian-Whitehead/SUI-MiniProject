using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GestureEventProcessor : MonoBehaviour
{
    public float simmilarityThreshold = 0.3f;
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

        Debug.Log($"gesture ID: {gestureCompletionData.gestureID} // gesture Name: {gestureCompletionData.gestureName} // simmilarity: {gestureCompletionData.similarity}");

        if(gestureCompletionData.similarity >= simmilarityThreshold)
        {
            //// Test gestureID to determine which gesture is being detected.
            /// if(gestureID = x){ m_LWristFlick.invoke() }
            /// ...
            if (gestureCompletionData.gestureID == 0) {
                Debug.Log("invoking 0");
                m_RWritstFlickEvent.Invoke(); 
            }

            if (gestureCompletionData.gestureID == 1) {
                Debug.Log("invoking 1");
                m_LWritstFlickEvent.Invoke(); 
            }
        }
    }


}
