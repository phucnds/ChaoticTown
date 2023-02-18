using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ActionScheduler : MonoBehaviour
{
    IAction currentAction;

    private ActionBasic current_action = null;
    private ActionBasic next_action = null;
    private Interactable action_target = null;
    private float action_progress = 0f;

    public UnityAction onStartAction;
    public UnityAction onStopAction;

    private Character character;

    private void Awake()
    {
        
    }

    public void StartAction(IAction action)
    {
        if (currentAction == action) return;
        if (currentAction != null)
        {
            currentAction.Cancel();
        }
        currentAction = action;
    }

    public void StartAction(ActionBasic action, Interactable target)
    {


        if (action != null && action.CanDoAction(character, target))
        {
            current_action = action;
            next_action = null;
            action_target = target;
            action_progress = 0f;
            current_action.StartAction(character, target);
            onStartAction?.Invoke();
        }
    }

    public void CancelCurrentAction()
    {
        StartAction(null);
    }
}
