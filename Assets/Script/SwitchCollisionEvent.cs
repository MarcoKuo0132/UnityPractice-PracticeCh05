using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCollisionEvent : MonoBehaviour
{
    public MyCharacter character;
    bool SwitchEnable = true;

    void OnCollisionEnter(Collision collision)
    {
        if (SwitchEnable)
        {
            character.CharacterWalk();
            SwitchEnable = false;
        }
    }
}
