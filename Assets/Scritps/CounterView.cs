using UnityEngine;
using System;

public class CounterView : MonoBehaviour
{
    public void OnEnable()
    {
        Counter.OnCountChanged += DisplayCount;
    }

    public void OnDisable()
    {
        Counter.OnCountChanged -= DisplayCount;
    }
    public void DisplayCount(int count)
    {
        Debug.Log(count);
    }
}