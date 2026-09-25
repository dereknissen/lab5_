using UnityEngine;

public class LeavesMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float rotationSpeed = 10f;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float randRotation = Random.Range(-2, 2);
        transform.Rotate(randRotation * Time.deltaTime * rotationSpeed, randRotation * Time.deltaTime * rotationSpeed, randRotation * Time.deltaTime * rotationSpeed);
    }
}
