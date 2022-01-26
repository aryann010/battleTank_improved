using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletModel 
{
   public BulletModel(int Damage, int speed)
   {
      giveDamage = Damage;
      bulletSpeed = speed;
   }

   public int giveDamage { get; private set; }
   public int bulletSpeed { get; private set; }
}
