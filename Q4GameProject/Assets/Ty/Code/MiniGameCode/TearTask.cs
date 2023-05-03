using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TearTask : MonoBehaviour
{
    public List<SwipePoint> _swipePoints = new List<SwipePoint>();
    
    private int _currentSwipePointIndex = 0;

    private void Update()
    {
        if (_currentSwipePointIndex != 0)
        {
            _currentSwipePointIndex = 0;
            Debug.Log("Error");
        }
    }
    private IEnumerator FinishTask(bool wasSuccessful)
    {
        if (wasSuccessful) {
            Debug.Log("NextTask");
                            }
        else
        {
            Debug.Log("None");
        }

        yield return new WaitForSeconds(1);
    }
    public void SwipePointTrigger(SwipePoint swipePoint)
    {
        if (swipePoint == _swipePoints[_currentSwipePointIndex])
        {
            _currentSwipePointIndex++;
        }

        if (_currentSwipePointIndex >= _swipePoints.Count)
        {
            _currentSwipePointIndex = 0;
            Debug.Log("Finished");
        }
    }
}
