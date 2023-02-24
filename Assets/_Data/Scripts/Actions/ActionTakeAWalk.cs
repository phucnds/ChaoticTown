using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ActionTakeAWalk", menuName = "ChaoticTown/Actions/TakeAWalk", order = 10)]
public class ActionTakeAWalk : ActionBasic
{
    public override void StartAction(Character character, Interactable target)
    {
        base.StartAction(character, target);
    }

    public override void UpdateAction(Character character, Interactable target)
    {
        // base.UpdateAction(character, target);
        // character.AddActionProgress(1 * Time.deltaTime);
        // Debug.Log(character.GetActionProgress());
        // if(character.GetActionProgress() > 1f)
        // {
        //     character.Stop();
        // }

        
    }

    public override void StopAction(Character character, Interactable target)
    {
        base.StopAction(character, target);
    }

    public override bool CanDoAction(Character character, Interactable target)
    {
        return base.CanDoAction(character, target);
    }
}
