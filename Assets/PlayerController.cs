using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float speed = 5f;

    PlayerMotor motor;

    private void Start() {
        motor = GetComponent<PlayerMotor>();
    }  

    private void Update() {
        // Calculate movement velocity as a 3d vector

        float _xMov = Input.GetAxisRaw("Horizontal");
        float _zMov = Input.GetAxisRaw("Vertical");

        Vector3 _movHorizontal = transform.right * _xMov; 
        Vector3 _movVertical = transform.forward * _zMov; 

        // Final movement vector
        Vector3 _velocity = (_movHorizontal + _movVertical).normalized * speed;

        // Apply movement
        motor.Move(_velocity);
    }
}
