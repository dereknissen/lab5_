using System.Runtime.CompilerServices;
using UnityEditor.UI;
using UnityEngine;

public class GoalMovementScript : MonoBehaviour
{
    public float distance = 5f;
    public float speed = 2f;
    private Vector3 startPosition;
    void Start()
    {
        startPosition = transform.position;
    }

    private void Update()
    {
        float movement = Mathf.PingPong(Time.time * speed, distance);
        transform.position = startPosition + Vector3.right * movement;
    }


}
