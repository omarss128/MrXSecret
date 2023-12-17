//using unityengine;
//using unityengine.ui;

//public class healthbar1 : monobehaviour
//{
//    public slider slider; // reference to the slider component of the health bar
//    public playerstats playerstats; // reference to the playerstats script

//    private void start()
//    {
//        if (slider == null)
//        {
//            debug.logerror("slider reference not set in playerhealthbar script.");
//            return;
//        }

//        if (playerstats == null)
//        {
//            debug.logerror("playerstats reference not set in playerhealthbar script.");
//            return;
//        }

//        // set the maximum value of the slider based on the player's initial max health
//        slider.maxvalue = playerstats.maxhealth;
//        updatehealthbar();
//    }

//    private void updatehealthbar()
//    {
//        if (slider != null && playerstats != null)
//        {
//            slider.value = playerstats.currenthealth;
//        }
//    }
//}
