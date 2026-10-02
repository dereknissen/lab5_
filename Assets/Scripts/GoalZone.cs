using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
public class GoalZone : MonoBehaviour
{
    public int score = 0;
    public List<GameObject> Spikes;
    
    void OnTriggerEnter(Collider other)
    {
        EnergyCore core = other.GetComponent<EnergyCore>();
        if (core != null)
        {
            score++;
            Debug.Log(
            "Energy Core delivered! Score: " + score
            );
            core.ResetCore();
        }
        for (int i = 0; i < Spikes.Count; i++)
        {
            Spikes[i].transform.position = new Vector3(0, -10, 0);
        }
    }
}