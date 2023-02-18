using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Character : MonoBehaviour
{

    private ActionBasic current_action = null;
    private ActionBasic next_action = null;
    private Interactable action_target = null;
    private float action_progress = 0f;

    public UnityAction onStartAction;
    public UnityAction onStopAction;

    public static event UnityAction<Character> OnAnyCharacterSpawned;
    public static event UnityAction<Character> OnAnyCharacterDead;

    private void Start()
    {
        OnAnyCharacterSpawned?.Invoke(this);
    }

    private void Update()
    {
        UpdateAction();
    }

    public void StartAction(ActionBasic action, Interactable target)
    {
        if(action != null && action.CanDoAction(this, target))
        {
            current_action = action;
            next_action = null;
            action_target = target;
            action_progress = 0f;
            current_action.StartAction(this, target);
            onStartAction?.Invoke();
        }
    }

    private void UpdateAction()
    {
        if (current_action == null)
            return;

        //Stop action if condition become false
        if (!current_action.CanDoAction(this, action_target))
        {
            Stop();
            return;
        }

        //Update action
        current_action.UpdateAction(this, action_target);
    }

    public void Stop()
    {
        StopAction();
        StopMove();
    }

    public void StopAction()
    {
        if (next_action != null)
            StopMove();
        if (current_action != null)
            current_action.StopAction(this, action_target);
        current_action = null;
        action_target = null;
        next_action = null;
        onStopAction?.Invoke();
    }

    public void StopMove()
    {

    }

    public void SetActionProgress(float value)
    {
        action_progress = value;
    }

    public void AddActionProgress(float value)
    {
        action_progress += value;
    }

    public float GetActionProgress()
    {
        return action_progress;
    }
}
