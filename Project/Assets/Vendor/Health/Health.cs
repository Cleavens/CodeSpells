using System.Collections;
using System.Timers;
using System;
using UnityEngine;

public class Health : MonoBehaviour {
  public double myHealth;

  void Start () {
	
  }

  double getHealth() {
    return myHealth;
  }

  //string percentOfTotalHealth() {
    //return Math.Round((myHealth - minHealth)/maxHealth*100.0, 1)+"%";
  //}

  public void decreaseHealth(double dec) {
   //implement
	myHealth -= dec;
  }

  public void increaseHealth(double inc) {
   //implement
	myHealth += inc;
  }
	
  
}