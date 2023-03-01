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
		//// To localize the text (Today, Allowed scheduler views) used in the scheduler.
        SfSchedulerResources.ResourceManager = new ResourceManager("HijriCalendarType.Resources.SfScheduler", Application.Current.GetType().Assembly);

        MainPage = new MainPage();

	}
}
