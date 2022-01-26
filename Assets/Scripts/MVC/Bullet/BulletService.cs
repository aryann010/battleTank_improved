using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletService : MonoBehaviour
{
   public BulletView bulletView;
   private void Start()
   {
      BulletModel bulletModel = new BulletModel(20, 5);
      BulletController bulletController = new BulletController(bulletModel, bulletView);
   }
}
