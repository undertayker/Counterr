using System.Collections;
using UnityEngine;

public class Counter : MonoBehaviour
{
    private int _count = 0;
    private int _number = 0;
    private bool _active = false;
    private float _interval = 0.5f;

    private WaitForSeconds _waitForSeconds;

    private Coroutine _increaseCoroutine;
    public CounterView View;

    private void Start()
    {
        _waitForSeconds = new WaitForSeconds(_interval);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(_number))
        {
            _active = !_active;

            if (_active)
            {
                StartCounter();
            }
            else
            {
                StopCounter();
            }
        }
    }

    private void StartCounter()
    {
        _increaseCoroutine = StartCoroutine(Increase());
    }

    private void StopCounter()
    {
        if (_increaseCoroutine != null)
        {
            StopCoroutine(_increaseCoroutine);
        }
    }

    private IEnumerator Increase()
    {
        while (_active)
        {
            _count++;
            View.DisplayCount(_count);
            yield return _waitForSeconds;
        }
    }
}