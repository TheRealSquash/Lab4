using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;
using FMOD.Studio;

public class SantaSoundEmitter : MonoBehaviour
{
    [SerializeField] private EventReference terrorRadiusSound;
    private EventInstance terrorRadius;

    void Start()
    {
        terrorRadius = AudioManager.instance.CreatEventInstance(terrorRadiusSound);
        terrorRadius.start();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
