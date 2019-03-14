﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtController : IHurtable {

    public HurtController(float maxhealth)
    {
        MaxHealth = maxhealth;
        Health = MaxHealth;
    }
   
    public float Health { get; set; }
    public float MaxHealth { get; set; }
    public HurtCallBack _HurtCallBack { get; set; }
    public DieCallBack _DieCallBack { get; set; }
    public bool isdie = false;
    public void GetHurt(float attack)
    {
        if (isdie)
            return;

        this.Health -= attack;
        if (_HurtCallBack != null)
        {

            _HurtCallBack();
        }
        if (Health <= 0)
        {
            if (_DieCallBack != null)
            {
              
                _DieCallBack();
            }
            isdie = true;
        }
    }
}