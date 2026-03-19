using System.Collections;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed = 180f;
    [SerializeField] private float _floatAmplitude = 0.3f;
    [SerializeField] private float _floatSpeed = 2f;

    private Vector3 _startPosition;
    private Coroutine _animationCoroutine;

    private void Start()
    {
        _startPosition = transform.position;
        _animationCoroutine = StartCoroutine(AnimateCoin());
    }

    private IEnumerator AnimateCoin()
    {
        while (true)
        {
            transform.Rotate(Vector3.up, _rotationSpeed * Time.deltaTime);

            float newY = _startPosition.y + Mathf.Sin(Time.time * _floatSpeed) * _floatAmplitude;
            transform.position = new Vector3(transform.position.x, newY, transform.position.z);

            yield return null;
        }
    }

    private void OnDestroy()
    {
        if (_animationCoroutine != null)
            StopCoroutine(_animationCoroutine);
    }
}