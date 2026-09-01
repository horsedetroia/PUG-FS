using UnityEngine;

public class PJMove : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private float velocidade = 5.0f;
    public Rigidbody2D rb;
    Vector2 forçaPulo;
    bool podePular = true;
    void Start()
    {
        forçaPulo = new Vector2(0.0f, 5.0f);
    }

    // Update is called once per frame
    void Update()
    {
        float mX = Input.GetAxisRaw("Horizontal");
        rb.linearVelocityX = mX * velocidade;
    }
}
