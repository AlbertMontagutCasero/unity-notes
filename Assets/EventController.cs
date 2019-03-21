using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventController : MonoBehaviour
{
    public delegate void TestDelegated(int testNum); // Creamos un delegado 
    public static event TestDelegated OnTestDelegated; // Creamos un evento del tipo del delegado

    public static event Action<int> OnEvent; // declaramos un evento del tipo UnityAction 
    
    private void Awake()
    {
        OnEvent += EventController_OnEvent; // suscribimos a los eventos unas  funciones
        OnTestDelegated += EventController_OnTestDelegated;
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            OnEvent(3); // Emit event
            OnTestDelegated(6);// Emit event
        }
    }

    private void EventController_OnEvent(int a)
    {
        Debug.Log(a);
    }

    private void EventController_OnTestDelegated(int test)
    {
        Debug.Log(test);
    }
}
