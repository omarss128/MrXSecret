//using system.collections;
//using system.collections.generic;
//using unityengine;
//using unityengine.ui;

//public class healthmanager : monobehaviour
//{
//    public image healthbar;
//    public float healthamount = 100f;
//    start is called before the first frame update
//    void start()
//    {

//    }

//    update is called once per frame
//    void update()
//    {
//        if (healthamount <= 0)
//        {
//            application.loadlevel(application.loadedlevel);
//        }

//    }
//    public void takedamage(float damage)
//    {
//        healthamount -= damage;
//        healthbar.fillamount = healthamount / 100f;

//    }

//}