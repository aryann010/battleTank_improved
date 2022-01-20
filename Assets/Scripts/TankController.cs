using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoSingletonGeneric<TankController>
{
    private Joystick JoyStick;
    
    
    public void HandleLeftJoyStickInput(Rigidbody tankRigidBody)
    {
        if(JoyStick.Vertical != 0)
        {
            Vector3 ZAxisMovement = tankRigidBody.transform.position + (tankRigidBody.transform.forward * JoyStick.Vertical * TankModel.Speed * SpeedMultipier);
            tankRigidBody.MovePosition(ZAxisMovement);
        }
        
        if(JoyStick.Horizontal != 0)
        {
            Quaternion newRotation = tankRigidBody.transform.rotation * Quaternion.Euler(Vector3.up * JoyStick.Horizontal * TankModel.RotationSpeed * RotationSpeedMultiplier);
            tankRigidBody.MoveRotation(newRotation);
        }
        
    }
}
