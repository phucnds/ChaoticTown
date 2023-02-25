using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackToStart : GAction
{
    public override bool PostPerform()
    {
        return true;
    }

    public override bool PrePerform()
    {
        return true;
    }

    
}
