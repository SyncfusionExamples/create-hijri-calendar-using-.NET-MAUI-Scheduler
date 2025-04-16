using System.Diagnostics;
using System.Globalization;
using System.Resources;
using Syncfusion.Maui.Scheduler;

namespace HijriCalendarType;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        try
        {
            CultureInfo.CurrentUICulture = new CultureInfo("ar-AE");
        }
        catch (CultureNotFoundException)
        {
            CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
        }
        if (Application.Current != null)
        {
            SfSchedulerResources.ResourceManager = new ResourceManager(
                "HijriCalendarType.Resources.SfScheduler",
                Application.Current.GetType().Assembly);
        }
        else
        {
            Debug.WriteLine("Warning: Application.Current is null. Scheduler resources may not be localized.");
        }
    }
    protected override Window CreateWindow(IActivationState? activationState)
    {
        return new Window(new MainPage());
    }
}
