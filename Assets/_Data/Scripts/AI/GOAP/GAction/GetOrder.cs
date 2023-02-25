using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetOrder : GAction
{

    GameObject resource;
    public override bool PostPerform()
    {
        // if(target == null) return false;

        // GWorld.Instance.GetQueue("orderTables").AddResource(target);
        GWorld.Instance.GetWorld().ModifyState("waitingOrder", -1);
        
        
        return true;
    }

    public override bool PrePerform()
    {
        target = GWorld.Instance.GetQueue("clients").RemoveResource();
        
       
        if (target == null)
            return false;
        
        
        return true; 
    }

    
}
