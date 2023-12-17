//using system.collections;
//using system.collections.generic;
//using unityengine;
//public class walkingenemy : enemycontroller
//{
//    private bool canflip = true; // flag to control flipping

//    void fixedupdate()
//    {
//        if (isfacingright)
//        {
//            getcomponent<rigidbody2d>().velocity = new vector2(maxspeed, getcomponent<rigidbody2d>().velocity.y);
//        }
//        else
//        {
//            getcomponent<rigidbody2d>().velocity = new vector2(-maxspeed, getcomponent<rigidbody2d>().velocity.y);
//        }
//    }

//    void ontriggerenter2d(collider2d collider)
//    {
//        if (collider != null && canflip)
//        {
//            if (collider.comparetag("wall") || collider.comparetag("enemy"))
//            {
//                flip();
//                startcoroutine(flipcooldown());
//            }
//            else if (collider.comparetag("player"))
//            {
//                debug.log("player collision");
//                findobjectoftype<playerstats>().takedamage(damage);
//            }
//        }
//    }

//    ienumerator flipcooldown()
//    {
//        canflip = false;
//        yield return new waitforseconds(1.0f); // adjust the cooldown duration as needed
//        canflip = true;
//    }
//}
