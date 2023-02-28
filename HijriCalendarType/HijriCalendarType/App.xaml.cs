using System.Globalization;
using System.Resources;
using Syncfusion.Maui.Scheduler;

namespace HijriCalendarType;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        CultureInfo.CurrentUICulture = new CultureInfo("ar-AE");
        SfSchedulerResources.ResourceManager = new ResourceManager("HijriCalendarType.Resources.SfScheduler", Application.Current.GetType().Assembly);

        MainPage = new MainPage();

	}
}
