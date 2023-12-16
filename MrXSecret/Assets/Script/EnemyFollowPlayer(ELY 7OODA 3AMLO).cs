//using system.collections;
//using system.collections.generic;
//using unityengine;

//public class enemyfollowplayerawlmara3mlnah : monobehaviour
//{
//    public float speed;
//    public float lineofsite;
//    public float shootingrange;
//    public gameobject bullet;
//    public gameobject bulletparent;

//    private transform player;
//    // start is called before the first frame update
//    void start()
//    {
//        player = gameobject.findgameobjectwithtag("player").transform;
//    }

//    // update is called once per frame
//    void update()
//    {
//        float distancefromplayer = vector2.distance(player.position, transform.position);
//        if (distancefromplayer < lineofsite && distancefromplayer > shootingrange)
//        {
//            transform.position = vector2.movetowards(this.transform.position, player.position, speed * time.deltatime);
//        }
//        else if (distancefromplayer <= shootingrange)
//        {
//            instantiate(bullet, bulletparent.transform.position,quaternion.identity);
//        }
//    }
//    private void ondrawgizmosselected()
//    {
//        gizmos.color = color.green;
//        gizmos.drawwiresphere(transform.position, lineofsite);
//        gizmos.drawwiresphere(transform.position, shootingrange);
//    }
//}
