using UnityEngine;

public class moveJet1 : MonoBehaviour
{
    public static bool Active = true;
    public float frontSpeed;
    public float XandYspeed;

    public float curentHeal;
    public float maxHeal;

    void Update()
    {
        if (Active)
        {
            transform.position += new Vector3(0, 0, frontSpeed * Time.deltaTime);

            if (Input.GetKey(KeyCode.A))
            {
                transform.position -= new Vector3(XandYspeed * Time.deltaTime, 0, 0);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.position += new Vector3(XandYspeed * Time.deltaTime, 0, 0);
            }
            if (Input.GetKey(KeyCode.W))
            {
                transform.position += new Vector3(0, XandYspeed * Time.deltaTime, 0);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.position -= new Vector3(0, XandYspeed * Time.deltaTime, 0);
            }
        }
    }
}
