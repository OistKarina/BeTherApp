using Microsoft.Maui.Handlers;
using Microsoft.UI.Xaml;
using IMap = BeThere.Controls.IMap;

namespace BeThere.Handlers
{
    public partial class MapHandler : ViewHandler<IMap, FrameworkElement>
    {
        protected override FrameworkElement CreatePlatformView() => throw new PlatformNotSupportedException();

        public static void MapMapType(IMapHandler handler, IMap map) => throw new PlatformNotSupportedException("No Map control on Windows.");

        public static void MapHasZoomEnabled(IMapHandler handler, IMap map) => throw new PlatformNotSupportedException("No Map control on Windows.");

        public static void MapHasScrollEnabled(IMapHandler handler, IMap map) => throw new PlatformNotSupportedException("No Map control on Windows.");

        public static void MapHasTrafficEnabled(IMapHandler handler, IMap map) => throw new PlatformNotSupportedException("No Map control on Windows.");

        public static void MapIsShowingUser(IMapHandler handler, IMap map) => throw new PlatformNotSupportedException("No Map control on Windows.");
    }
}
