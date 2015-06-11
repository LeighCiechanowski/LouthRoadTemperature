using System.Linq;
using System.Threading;
using LouthRoad.Core;

namespace LouthRoad.Droid
{
    using Android.App;
    using Android.OS;
    using Android.Views;
    using Android.Widget;

    public class CurrentTemperatureFragment : Fragment
    {
        private TextView currentTemp;
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            if (container == null)
            {
                // Currently in a layout without a container, so no reason to create our view.
                return null;
            }

            var view = inflater.Inflate(Resource.Layout.CurrentTemperature, container, false);
            currentTemp = view.FindViewById<TextView>(Resource.Id.textViewCurrenttemperature);

            var service = new TemperatureService();
            var temp = service.GetTemperatureList().FirstOrDefault();
            if (temp != null)
                currentTemp.Text = temp.Value + "\u2103";
            
            return view;
        }      
    }
}