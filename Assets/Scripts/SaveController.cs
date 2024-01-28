using UnityEngine;

public class SaveController : MonoBehaviour
{
    public Points points;
    public Modificador mod1;
    public Modificador mod2;
    public Modificador mod3;
    public Modificador mod4;
    public Modificador mod5;
    public Modificador mod6;

    private int ft1 = 1;
    private int ft2 = 1;
    private int ft3 = 1;
    private int ft4 = 1;
    private int ft5 = 1;
    private int ft6 = 1;

    private int ft1_ = 1;
    private int ft2_ = 1;
    private int ft3_ = 1;
    private int ft4_ = 1;
    private int ft5_ = 1;
    private int ft6_ = 1;

    /*private void Start()
    {
        mod1.firstTime = true;
        mod2.firstTime = true;
        mod3.firstTime = true;
        mod4.firstTime = true;
        mod5.firstTime = true;
        mod6.firstTime = true;
    }*/

    private void Awake()
    {
        points.points = PlayerPrefs.GetFloat("puntos");
        points.pps = PlayerPrefs.GetFloat("pps");
        points.progress = PlayerPrefs.GetFloat("progreso");
        mod1.cantidad = PlayerPrefs.GetInt("cantidad1");
        mod2.cantidad = PlayerPrefs.GetInt("cantidad2");
        mod3.cantidad = PlayerPrefs.GetInt("cantidad3");
        mod4.cantidad = PlayerPrefs.GetInt("cantidad4");
        mod5.cantidad = PlayerPrefs.GetInt("cantidad5");
        mod6.cantidad = PlayerPrefs.GetInt("cantidad6");
        mod1.coste = PlayerPrefs.GetFloat("coste1");
        mod2.coste = PlayerPrefs.GetFloat("coste2");
        mod3.coste = PlayerPrefs.GetFloat("coste3");
        mod4.coste = PlayerPrefs.GetFloat("coste4");
        mod5.coste = PlayerPrefs.GetFloat("coste5");
        mod6.coste = PlayerPrefs.GetFloat("coste6");

        if(ft1_ == 0)
        {
            mod1.firstTime = false;
        }
        else
        {
            mod1.firstTime = true;
        }

        if (ft2_ == 0)
        {
            mod2.firstTime = false;
        }
        else
        {
            mod2.firstTime = true;
        }

        if (ft3_ == 0)
        {
            mod3.firstTime = false;
        }
        else
        {
            mod3.firstTime = true;
        }

        if (ft4_ == 0)
        {
            mod4.firstTime = false;
        }
        else
        {
            mod4.firstTime = true;
        }

        if (ft5_ == 0)
        {
            mod5.firstTime = false;
        }
        else
        {
            mod5.firstTime = true;
        }

        if (ft6_ == 0)
        {
            mod6.firstTime = false;
        }
        else
        {
            mod6.firstTime = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(mod1.firstTime == true)
        {
            ft1 = 1;
        }
        if (mod1.firstTime == false)
        {
            ft1 = 0;
        }
        if (mod2.firstTime == true)
        {
            ft2 = 1;
        }
        if (mod2.firstTime == false)
        {
            ft2 = 0;
        }
        if (mod3.firstTime == true)
        {
            ft3 = 1;
        }
        if (mod3.firstTime == false)
        {
            ft3 = 0;
        }
        if (mod4.firstTime == true)
        {
            ft4 = 1;
        }
        if (mod4.firstTime == false)
        {
            ft4 = 0;
        }
        if (mod5.firstTime == true)
        {
            ft5 = 1;
        }
        if (mod5.firstTime == false)
        {
            ft5 = 0;
        }
        if (mod6.firstTime == true)
        {
            ft6 = 1;
        }
        if (mod6.firstTime == false)
        {
            ft6 = 0;
        }

        PlayerPrefs.SetFloat("puntos", points.points);
        PlayerPrefs.SetFloat("pps", points.pps);
        PlayerPrefs.SetFloat("progreso", points.progress);
        PlayerPrefs.SetInt("cantidad1", mod1.cantidad);
        PlayerPrefs.SetInt("cantidad2", mod2.cantidad);
        PlayerPrefs.SetInt("cantidad3", mod3.cantidad);
        PlayerPrefs.SetInt("cantidad4", mod4.cantidad);
        PlayerPrefs.SetInt("cantidad5", mod5.cantidad);
        PlayerPrefs.SetInt("cantidad6", mod6.cantidad);
        PlayerPrefs.SetFloat("coste1", mod1.coste);
        PlayerPrefs.SetFloat("coste2", mod2.coste);
        PlayerPrefs.SetFloat("coste3", mod3.coste);
        PlayerPrefs.SetFloat("coste4", mod4.coste);
        PlayerPrefs.SetFloat("coste5", mod5.coste);
        PlayerPrefs.SetFloat("coste6", mod6.coste);
        PlayerPrefs.SetInt("ft1", ft1);
        PlayerPrefs.SetInt("ft2", ft2);
        PlayerPrefs.SetInt("ft3", ft3);
        PlayerPrefs.SetInt("ft4", ft4);
        PlayerPrefs.SetInt("ft5", ft5);
        PlayerPrefs.SetInt("ft6", ft6);

        ft1_ = PlayerPrefs.GetInt("ft1", ft1);
        ft2_ = PlayerPrefs.GetInt("ft2", ft2);
        ft3_ = PlayerPrefs.GetInt("ft3", ft3);
        ft4_ = PlayerPrefs.GetInt("ft4", ft4);
        ft5_ = PlayerPrefs.GetInt("ft5", ft5);
        ft6_ = PlayerPrefs.GetInt("ft6", ft6);
    }
}
