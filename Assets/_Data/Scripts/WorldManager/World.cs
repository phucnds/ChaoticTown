using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World : MonoBehaviour
{
    public static World Instance { get; private set; }

    [SerializeField] private Transform startPoints;
    [SerializeField] private Transform endPoints;

    private void Awake()
    {
        Instance = this;
    }

    public Interactable getStartPoint()
    {
        return startPoints.GetComponent<Interactable>();
    }

    public Interactable getEndStart()
    {
        return endPoints.GetComponent<Interactable>();
    }
}
