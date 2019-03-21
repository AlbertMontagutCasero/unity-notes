using UnityEngine;

public class Cube : MonoBehaviour
{
    private void Awake()
    {
        EventController.OnTestDelegated += OnTest;
    }

    void OnTest(int i)
    {
        Debug.Log("tonto");
    }
}