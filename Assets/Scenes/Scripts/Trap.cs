using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public GameObject TrapFloor;
    AudioSource TrapDoor;

    // Start is called before the first frame update
    void Start()
    {
        TrapDoor = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        TrapDoor.Play(0);
        GameObject.Destroy(TrapFloor);
    }
}
