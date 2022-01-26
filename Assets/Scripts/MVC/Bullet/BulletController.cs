using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController 
{
   public BulletController(BulletModel bulletModel, BulletView bulletView)
   {
      BulletModel = bulletModel;
     // BulletView = GameObject.Instantiate<BulletView>(bulletPrefab);
   }
   public BulletModel BulletModel { get; }
   public BulletView BulletView { get; }
}
