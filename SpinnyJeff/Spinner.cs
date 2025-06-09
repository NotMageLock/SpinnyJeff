using UnityEngine;

namespace SpinnyJeff;

public class Spinner : MonoBehaviour
{
    float degreesPerSecond = 360f;

    void Awake()
    {
        Debug.Log("Jeff is a spinny boy");
    }

    private void Update()
    {
        this.gameObject.transform.Rotate(0f, 0f, -degreesPerSecond * Time.deltaTime);
        Debug.Log("Jeff spin spin");
    }
}