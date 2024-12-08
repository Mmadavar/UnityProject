using UnityEngine;

public class CircleTransformation : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform pos1;
    // Update is called once per frame
    void Update()
    {
        // translating the object.
        transform.Translate(Vector3.forward * Time.deltaTime);
        // scaling the object
        transform.localScale = new Vector3(2,2,2);  
    }
}
