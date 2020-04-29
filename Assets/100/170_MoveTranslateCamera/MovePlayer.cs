using UnityEngine;
using System.Collections;

namespace _170_MoveTranslate
{
    public class MovePlayer : MonoBehaviour
    {
        public float speed = 2f;
        public float jump = 1000f;
        public float cameraRotSpeed = 50f;
        public float rotClampMin = -50;
        public float rotClampMax = 70;
        Rigidbody rigidbody;
        //public GameObject rot;
        public GameObject cameraRot;
        //public GameObject getAnim;
        //private Animator anim;
        private float angle;
        // Use this for initialization
        void Start()
        {
            //cameraRot = transform.GetChild(1).gameObject;
            //anim = getAnim.GetComponent<Animator>();
            rigidbody = GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void Update()
        {
            //anim.SetFloat("VelocityX", Input.GetAxis("Horizontal"));
            //anim.SetFloat("VelocityY", Input.GetAxis("Vertical"));
            float _h = Input.GetAxis("Horizontal");
            float _v = Input.GetAxis("Vertical");
            transform.Translate(_h * speed * Time.deltaTime, 0, _v * speed * Time.deltaTime);

            if (Input.GetMouseButton(1))
            {
                float _mouseX = Input.GetAxis("Mouse X");
                float _mouseY = Input.GetAxis("Mouse Y");
                transform.Rotate(0, _mouseX * cameraRotSpeed * Time.deltaTime, 0);
                angle -= _mouseY * cameraRotSpeed * Time.deltaTime;
                var clampedAngle = Mathf.Clamp(angle, rotClampMin, rotClampMax);
                cameraRot.transform.localRotation = Quaternion.Euler(clampedAngle, 0, 0);
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rigidbody.AddForce(jump * Vector3.up);
            }
        }
    }
}