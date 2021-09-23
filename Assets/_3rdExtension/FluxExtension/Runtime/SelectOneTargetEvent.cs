using Flux;
using UnityEngine;

[FEvent("SelectTarget/Select One Target")]
public class SelectOneTargetEvent : FEvent
{

    protected override void OnInit()
    {
        base.OnInit();
        Debug.LogError("OnInit= " + Sequence.name);
    }

    protected override void OnTrigger(float timeSinceTrigger)
    {
        base.OnTrigger(timeSinceTrigger);
        Debug.LogError("OnTrigger");
    }

    protected override void OnFinish()
    {
        base.OnFinish();
        Debug.LogError("OnFinish");
    }

    protected override void OnStop()
    {
        base.OnStop();
        Debug.LogError("OnStop");
    }

    protected override void OnUpdateEvent(float timeSinceTrigger)
    {
        base.OnUpdateEvent(timeSinceTrigger);
        Debug.LogError("OnUpdateEvent");
    }

}
