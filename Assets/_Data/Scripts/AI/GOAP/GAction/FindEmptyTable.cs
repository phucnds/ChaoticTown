using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindEmptyTable : GAction
{
    public override bool PostPerform()
    {
        GWorld.Instance.GetWorld().ModifyState("waitingOrder", 1);
        GWorld.Instance.GetQueue("clients").AddResource(gameObject);
        return true;
    }

    public override bool PrePerform()
    {
        target = GWorld.Instance.GetQueue("tables").RemoveResource();
        if (target == null)
            return false;

        GWorld.Instance.GetWorld().ModifyState("FreeTable", -1);
        return true;
    }

    
}
