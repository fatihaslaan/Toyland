using UnityEngine;
using UnityEngine.EventSystems;
using UnityStandardAssets.Characters.FirstPerson;

public class Movement : MonoBehaviour
{
    public FixedJoystick joystick;

    void Update()
    {
        var fps = GetComponent<RigidbodyFirstPersonController>();
        fps.runaxis = joystick.Direction;
    }
}
   