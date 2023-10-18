using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moover : MonoBehaviour
{
    [SerializeField] private float legsSpeed;
    [SerializeField] private List<Rigidbody> _legs = new List<Rigidbody>();
    [SerializeField] private Rigidbody _rb;
    private float timer = 0.5f;
    private int counter = 0;

    private void FixedUpdate()
    {
        
        if (timer <= 0 && counter < 4)
        {
            _legs[counter].velocity = new Vector3(legsSpeed, 0, 0);
            timer = 1;
            counter++;
        } else if (counter >= 4)
        {
            counter = 0;
        }
        timer -= Time.deltaTime;
    }
}
