using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorezoneController : MonoBehaviour {

    public int Count;
    private bool IsFloorOpen;

    private void Start()
    {
        Count = 0;
        IsFloorOpen = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (IsFloorOpen)
        {
            Count++;
        }
    }

    public int GetAndResetCount()
    {
        int tmp = Count;
        Count = 0;
        return tmp;
    }

    public void SetIsFloorOpen(bool isFloorOpen)
    {
        IsFloorOpen = isFloorOpen;
    }
}
