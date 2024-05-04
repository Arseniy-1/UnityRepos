using System.Collections;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] private float _delay;
    [SerializeField] private ScoreView _scoreView;

    private int _currentScore = 0;
    private bool _isActive = false;
    private Coroutine _counting;

    public void SwitchActive()
    {
        if (!_isActive)
        {
            _counting = StartCoroutine(Counting());
        }
        else
        {
            StopCoroutine(_counting);
        }

        _isActive = !_isActive;
    }

    private IEnumerator Counting()
    {
        var wait = new WaitForSeconds(_delay);

        while (true)
        {
            Debug.Log(_currentScore);
            _currentScore += 1;
            _scoreView.ShowCurrentScore(_currentScore);
            yield return wait;
        }
    }
}
