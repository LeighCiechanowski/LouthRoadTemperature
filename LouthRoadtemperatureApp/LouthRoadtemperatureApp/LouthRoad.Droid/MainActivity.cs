namespace LouthRoad.Droid
{
    using Android.App;
    using Android.OS;

    [Activity(Label = "LouthRoad.Droid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity, ActionBar.ITabListener
    {
        Fragment[] _fragments;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            this.ActionBar.NavigationMode = ActionBarNavigationMode.Tabs;
            SetContentView(Resource.Layout.Main);   
         
            _fragments = new Fragment[]
                             {
                                 new CurrentTemperatureFragment(), 
                                 new TemperaturesFragment() 
                             };        
            this.AddTabToActionBar(Resource.String.CurrentTemperature, Resource.Drawable.ic_action_my_schedule);
            this.AddTabToActionBar(Resource.String.LatestTemperatures, Resource.Drawable.ic_action_sessions);
        }

        void AddTabToActionBar(int labelResourceId, int iconResourceId)
        {
            ActionBar.Tab tab = this.ActionBar.NewTab()
                                           .SetText(labelResourceId)
                                           .SetIcon(iconResourceId)
                                           .SetTabListener(this);
            this.ActionBar.AddTab(tab);
        }

        public void OnTabReselected(ActionBar.Tab tab, FragmentTransaction ft)
        {
          
        }

        public void OnTabSelected(ActionBar.Tab tab, FragmentTransaction ft)
        {
            FragmentManager.PopBackStack(null, FragmentManager.PopBackStackInclusive);

            Fragment frag = _fragments[tab.Position];
            ft.Replace(Resource.Id.content_frame, frag);
        }

        public void OnTabUnselected(ActionBar.Tab tab, FragmentTransaction ft)
        {
           
        }
    }
}

