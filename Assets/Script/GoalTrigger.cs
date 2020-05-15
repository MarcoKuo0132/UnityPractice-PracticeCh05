using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalTrigger : MonoBehaviour
{
    public MyCharacter character;
    public GameObject FinishText;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.name == "Constructor")
        {
            FinishText.SetActive(true);
            character.CharacterStop();
        }
    }
}
