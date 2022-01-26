using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankService: MonoSingletonGeneric<TankService>
{
   public TankView tankView;
   private void start()
   {
      TankModel tankModel = new TankModel(5, 100f);
      TankController tankController = new TankController(tankModel, tankView);
   }
}
