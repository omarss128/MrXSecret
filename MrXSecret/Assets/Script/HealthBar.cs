//using system.collections;
//using system.collections.generic;
//using unityengine;
//using unityengine.ui;

//public class healthbar : monobehaviour
//{
//    private float _maxhealth=100;
//    private float _currenthealth;
//    [serializefield] private image _healthbarfill;

//    void start()
//    {
//        _currenthealth = _maxhealth;
        
//    }

    
//    public void updatehealth(float amount)
//    {
//        _currenthealth += amount;
//        updatehealthbar();
//    }
//    private void updatehealthbar()
//    {
//        float targetfillamount = _currenthealth / _maxhealth;
//        _healthbarfill.fillamount = targetfillamount;
//    }
//}

