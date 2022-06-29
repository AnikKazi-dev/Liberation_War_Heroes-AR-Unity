using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class TrackableEventHandler : DefaultTrackableEventHandler
{
    public UnityEvent onTrakingFoundEvent;
    public UnityEvent onTrakingLostEvent;
    public GameObject UIText;

    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();
        UIText.SetActive(false);
        onTrakingFoundEvent.Invoke();
    }
    protected override void OnTrackingLost()
    {
        base.OnTrackingLost();
        UIText.SetActive(true);
        onTrakingLostEvent.Invoke();
    }


}
