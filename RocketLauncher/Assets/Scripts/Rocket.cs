using UnityEngine;

public class Rocket : MonoBehaviour
{
    private Rigidbody2D _rb2d;
    private float fuel = 100f;
    
    private readonly float SPEED = 5f;
    private readonly float FUELPERSHOOT = 10f;
    
    void Awake()
    {
        _rb2d = GetComponent<Rigidbody2D>();
    }
    
    public void Shoot()
    {

        if (fuel > 9f)
        {
            fuel -= 10f;
            _rb2d.AddForce(Vector2.up * SPEED, ForceMode2D.Impulse);
        }
        
    }
}
