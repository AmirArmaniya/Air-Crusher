using UnityEngine;

public class shoot2 : MonoBehaviour
{
    public static shoot2 iduno;

    float Delay = 2;

    public static bool Active = true;
    public GameObject bullet;

    public GameObject ShootFromHere1;
    public GameObject ShootFromHere2;

    private int overheattime;
    public static int overheattimeRange = 20;

    [SerializeField] private GameObject ShowCold;
    [SerializeField] private GameObject ShowHot;
    [SerializeField] private GameObject DONTShowCold;
    [SerializeField] private GameObject DONTShowHot;

    private void Awake()
    {
        iduno = this;
    }

    void Update()
    {

        if (Active)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (overheattime < overheattimeRange)
                {
                    shoot();
                    overheattime += 1;
                }
            }
        }
        /////////

        if (overheattime >= overheattimeRange)
        {
            if (true)
            {
                Delay -= Time.deltaTime;
                //Debug.Log("UU start --- " + Delay);
                AmmuReloadingTimer.timer = System.Convert.ToInt32(Delay);
                showHot();
            }
            if (Delay <= 0)
            {
                overheattime = 0;
                ammoCunter.ammo = overheattimeRange;
                Delay = 2;
                //Debug.Log("UU end --- " + Delay);
                showCold();
            }
        }
    }

    public void shoot()
    {
        GameObject BBullet = Instantiate(bullet);
        BBullet.transform.position = transform.position + transform.forward;
        Destroy(BBullet, 2F);
    }

    public void shootmobile()
    {
        if (overheattime < overheattimeRange)
        {
            GameObject BB1ullet = Instantiate(bullet);
            GameObject BB2ullet = Instantiate(bullet);

            BB1ullet.transform.position = ShootFromHere1.transform.position;
            BB2ullet.transform.position = ShootFromHere2.transform.position;

            Destroy(BB1ullet, 2F);
            Destroy(BB2ullet, 2F);

            overheattime += 1;
            ammoCunter.ammo -= 1;
        }
    }

    private void showCold()
    {
        iduno.ShowCold.SetActive(true);
        iduno.DONTShowHot.SetActive(false);
    }

    private void showHot()
    {
        iduno.ShowHot.SetActive(true);
        iduno.DONTShowCold.SetActive(false);
    }
}
