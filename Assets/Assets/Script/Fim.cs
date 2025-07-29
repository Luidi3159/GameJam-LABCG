using UnityEngine;

public class Fim : MonoBehaviour
{
    private Rigidbody rb;
    private float x;
    private float y;
    private float z;
    private Vector3 impulso;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        rb = GetComponent<Rigidbody>();
        x = Random.Range(-1f, 1f);
        y = Random.Range(-1f, 1f);
        z = Random.Range(-1f, 1f);
        impulso = new Vector3(x, y, z);
        rb.AddForce(impulso, ForceMode.Impulse);
    }    
}
