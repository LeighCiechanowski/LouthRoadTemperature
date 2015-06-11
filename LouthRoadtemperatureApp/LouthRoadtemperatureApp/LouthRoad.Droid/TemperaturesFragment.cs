namespace LouthRoad.Droid
{    
    using Android.App;
    using Android.OS;
    using Android.Widget;
    using Core;

    public class TemperaturesFragment : ListFragment
    {        
        public override void OnCreate(Bundle savedInstanceState)
        {
            var service = new TemperatureService();
            base.OnCreate(savedInstanceState);

            var data = service.GetTemperatureList();           
            var adapter = new ArrayAdapter<SensorValue>(
                this.Activity,
                Android.Resource.Layout.SimpleListItem1, data
                );

            this.ListAdapter = adapter;
        }
    }
}