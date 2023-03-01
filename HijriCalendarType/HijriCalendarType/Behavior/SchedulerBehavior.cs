using Syncfusion.Maui.Scheduler;
using System.Collections.ObjectModel;
using System.Globalization;

namespace HijriCalendarType
{
    internal class SchedulerBehavior : Behavior<SfScheduler>
    {
        protected override void OnAttachedTo(SfScheduler scheduler)
        {


            // DateTime value specified with calendar type and respective calendar date.
            scheduler.MinimumDateTime = new DateTime(1443, 08, 8, 10, 0, 0, new HijriCalendar());
            scheduler.MaximumDateTime = new DateTime(1445, 08, 8, 10, 0, 0, new HijriCalendar());

            // DateTime value with system time.
            scheduler.MinimumDateTime = new DateTime(2022, 02, 28, 11, 0, 0, 0);
            scheduler.MaximumDateTime = new DateTime(2023, 12, 28, 11, 0, 0, 0);

            // DateTime value specified with calendar type and respective calendar date.
            scheduler.DisplayDate = new DateTime(1444, 08, 8, 10, 0, 0, new HijriCalendar());

            // DateTime value with system time.
            scheduler.DisplayDate = new DateTime(2023, 02, 28, 11, 0, 0, 0);

            // DateTime value specified with calendar type and respective calendar date.
            scheduler.SelectedDate = new DateTime(1444, 08, 8, 10, 0, 0, new HijriCalendar());

            // DateTime value with system time.
            scheduler.SelectedDate = new DateTime(2023, 02, 28, 11, 0, 0, 0);

            ObservableCollection<SchedulerTimeRegion> timeRegions = new ObservableCollection<SchedulerTimeRegion>
            {
                new SchedulerTimeRegion
                {
                    // StartTime and EndTime value specified with calendar type and respective calendar date.
                    StartTime = new DateTime(1444, 08, 8, 9, 0, 0, new HijriCalendar()),
                    EndTime = new DateTime(1444, 08, 8, 10, 0, 0, new HijriCalendar()),
                    Background = new SolidColorBrush(Colors.LightGray),
                    Text = "Busy",
                    ResourceIds = new ObservableCollection<object> { 1, 3 }
                },

                new SchedulerTimeRegion
                {
                    // StartTime and EndTime value specified with local system date will be converted to the Hijri calendar mentioned.
                    StartTime = new DateTime(2023, 02, 28, 8, 0, 0, 0),
                    EndTime = new DateTime(2023, 02, 28, 9, 0, 0, 0),
                    Text = "Busy",
                    Background = new SolidColorBrush(Colors.LightGray),
                    ResourceIds = new ObservableCollection<object> { 2 }
                }
            };

            scheduler.TimelineView.TimeRegions = timeRegions;
            scheduler.TimelineView.StartHour = 8;
            scheduler.TimelineView.EndHour = 15;
            scheduler.TimelineView.TimeIntervalWidth = 100;
        }
    }

    

    }
