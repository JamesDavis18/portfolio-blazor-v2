using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;
//@Inject NavigationManager Navigator;

namespace portfolio_blazor_v2
{
    public class NavigationSubscriber : IDisposable
    {
        private readonly NavigationManager _navManager;

        private NavigationSubscriber(NavigationManager navigationManager)
        {
            _navManager = navigationManager;
            _navManager.LocationChanged += OnLocationChanged;
        }

        private void OnLocationChanged(object sender, LocationChangedEventArgs e)
        {
            // Handle the location change event here
            Console.WriteLine($"Location changed to: {e.Location} using [Service]");
        }

        public void Dispose()
        {
            _navManager.LocationChanged -= OnLocationChanged;
        }
    }
}
