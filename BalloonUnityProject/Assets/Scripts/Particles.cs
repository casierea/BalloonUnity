﻿using UnityEngine;
using System.Collections;

public class Particles : MonoBehaviour
{
    private ParticleSystem ps;

    void Start()
    {
        ps = GetComponent<ParticleSystem>();
        ps.Stop(); // Cannot set duration whilst Particle System is playing

        var main = ps.main;
        main.duration = 10.0f;

        ps.Play();
    }
}