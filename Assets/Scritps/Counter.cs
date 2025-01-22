using System.Collections;
using UnityEngine;

public class Counter : MonoBehaviour
{
    private int _count = 0;
    private bool _active = false;
    private float _interval = 0.5f;

    private Coroutine _increaseCoroutine;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _active = !_active;

            if (_active)
            {
                _increaseCoroutine = StartCoroutine(Increase());
            }
            else
            {
                StopCoroutine(_increaseCoroutine);
            }
        }
    }

    private IEnumerator Increase()
    {
        while (_active)
        {
            _count++;
            Debug.Log(_count);
            yield return new WaitForSeconds(_interval);
        }
    }
}