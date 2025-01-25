using UnityEngine;

public class CounterView : MonoBehaviour
{
    [SerializeField] private Counter _counter;

    public void OnEnable()
    {
        _counter.CountChanged += DisplayCount;
    }

    public void OnDisable()
    {
        _counter.CountChanged -= DisplayCount;
    }
    public void DisplayCount(int count)
    {
        Debug.Log(count);
    }
}