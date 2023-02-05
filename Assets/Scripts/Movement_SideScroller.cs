using UnityEngine;

public class Movement_SideScroller : MonoBehaviour
{
    public float Speed = 2f;
    public float Smoothness = 0.01f;
    public float JumpForce = 5f;

    //Activated when player starts running
    public GameObject StartSmoke;
    public float RunningSoundVolume = 0.2f;
    public AudioClip JumpSound;
    public bool isStationary = false;


    private bool _wasGrounded;
    private bool _wasRunning;
    private Rigidbody2D _rb;
    private Animator _animator;
    private SpriteRenderer _spriteRenderer;
    private AudioSource _audioSource;

    void Start()
    {
        _wasGrounded = true;
        _wasRunning = false;
        _rb = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _audioSource = GetComponent<AudioSource>();
        _audioSource.volume = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isStationary)
        {
            _animator.SetBool("IsRunning", false);
            _animator.SetBool("IsJumping", false);
            _animator.SetBool("IsMidAir", false);
            _audioSource.volume = 0;
            return;
        }
            //Set velocity to the horizontal input multiplied by the speed.
        Vector2 velocity = Vector2.right * (Speed * Input.GetAxis("Horizontal"));

        //If speed is 0, the same direction is kept.
        if(Input.GetAxis("Horizontal")>0)
            transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x),transform.localScale.y,transform.localScale.z);
        else if(Input.GetAxis("Horizontal")<0)
            transform.localScale = new Vector3(-Mathf.Abs(transform.localScale.x),transform.localScale.y,transform.localScale.z);

        //If the player is on the ground and presses the jump button, set the velocity to 5.
        if (Input.GetAxis("Vertical") > 0.5f && _wasGrounded)
        {
            velocity.y = JumpForce;
            _wasGrounded = false;
            _animator.SetBool("IsJumping", true);
            _animator.SetBool("IsMidAir", true);
            _audioSource.PlayOneShot(JumpSound);
            _audioSource.volume = 1f;
        }
        else
        {
            velocity.y = _rb.velocity.y;
        }

        //If the player is on the ground or on a rko, give the player an ability to jump.
        if (!_wasGrounded)
        {
            _wasGrounded = Physics2D.Raycast(transform.position - new Vector3(-0.5f, transform.localScale.y / 2, 0),
                Vector2.down, 0.3f, 1 << LayerMask.NameToLayer("Ground") | 1 << LayerMask.NameToLayer("Rko"))
                ||
                Physics2D.Raycast(transform.position - new Vector3(0.5f, transform.localScale.y / 2, 0),
                    Vector2.down, 0.3f, 1 << LayerMask.NameToLayer("Ground") | 1 << LayerMask.NameToLayer("Rko"));
            if (_wasGrounded)
            {
                _animator.SetBool("IsJumping", false);
                _animator.SetBool("IsMidAir", false);
            }
        }

        //Set the animator's IsRunning parameter to true if the player is moving.
        _animator.SetBool("IsRunning", velocity.x != 0);

        if (velocity.x != 0 || _audioSource.clip == JumpSound)
            _audioSource.volume = RunningSoundVolume;
        else
            _audioSource.volume = Mathf.Lerp(_audioSource.volume, 0, Smoothness);
        
        DeploySmoke(velocity);

        _rb.velocity = Vector2.Lerp(_rb.velocity, velocity, Smoothness);
    }

    private void DeploySmoke(Vector2 velocity)
    {
        //If the player is running and wasn't running before, activate the start smoke.
        if (velocity.x != 0 && !_wasRunning)
        {
            GameObject smoke = Instantiate(StartSmoke);

            //Set the smoke's position to the player's position, but a bit lower.
            smoke.transform.position =
                transform.position - new Vector3(transform.localScale.x / 2, transform.localScale.y / 3);
            smoke.transform.localScale = transform.localScale;
            SpriteRenderer renderer = smoke.GetComponent<SpriteRenderer>();
            renderer.color = _spriteRenderer.color;
            renderer.sortingOrder = _spriteRenderer.sortingOrder;

            Destroy(smoke, 1f);

            _wasRunning = true;
        }
        else if (velocity.x == 0 && _wasRunning)
        {
            _wasRunning = false;
        }
    }
}