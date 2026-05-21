using UnityEngine;

public class MoveDrone : MonoBehaviour
{
    float horizontal, vertical;
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }
}
