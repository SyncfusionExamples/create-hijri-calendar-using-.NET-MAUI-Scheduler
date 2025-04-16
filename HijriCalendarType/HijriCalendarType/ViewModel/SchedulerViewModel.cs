using Syncfusion.Maui.Scheduler;
using System.Collections.ObjectModel;
using System.Globalization;

namespace HijriCalendarType
{
    public class SchedulerViewModel
    {
        /// <summary>
        /// Gets or sets appointments.
        /// </summary>
        public List<SchedulerAppointment> Tasks { get; set; }

        /// <summary>
        /// Gets or sets resources to the scheduler.
        /// </summary>
        public List<SchedulerResource>? Resources { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchedulerViewModel" /> class.
        /// </summary>
        public SchedulerViewModel()
        {
            this.Tasks = this.GetEmployeeTasks();
        }


        /// <summary>
        /// Method to get resources or employees to the scheduler.
        /// </summary>
        /// <param name="resourceColors"></param>
        /// <returns></returns>
        private List<SchedulerResource> GetSchedulerResources(List<Brush> resourceColors)
        {
            Random random = new();
            List<SchedulerResource> resources = new();
            List<string> employeeNames = new List<string>
            {
                  "Robert", "Sophia", "Emilia" , "Stephen", "Johnny", "Daniel",
            };

            for (int i = 0; i < 6; i++)
            {
                SchedulerResource employees = new();
                employees.Name = employeeNames[i];
                employees.Foreground = Colors.White;
                employees.Background = resourceColors[random.Next(resourceColors.Count)];
                employees.Id = i + 1;
                resources.Add(employees);
            }

            return resources;
        }

        /// <summary>
        /// Method to get tasks for employees.
        /// </summary>
        /// <returns>Employee tasks</returns>
        private List<SchedulerAppointment> GetEmployeeTasks()
        {
            List<Brush> resourceColors = this.GetResourceColors();
            this.Resources = this.GetSchedulerResources(resourceColors);

            Random random = new();
            List<SchedulerAppointment> tasks = new();
            List<string> events = new List<string>
           { "GoToMeeting", "Business Meeting", "Conference", "Project Status Discussion",
                                                             "Auditing", "Client Meeting", "Generate Report", "Target Meeting", "General Meeting" };

            for (int i = 0; i < 6; i++)
            {
                SchedulerResource resource = this.Resources[i];

                // Adding schedule appointment in the schedule appointment collection.
                tasks.Add(new SchedulerAppointment()
                {
                    Subject = events[random.Next(events.Count)],
                    // StartTime and EndTime value specified with calendar type and respective calendar date.
                    StartTime = new DateTime(1444, 08, 8, 10, 0, 0, new HijriCalendar()),
                    EndTime = new DateTime(1444, 08, 8, 11, 0, 0, new HijriCalendar()),
                    Background = resourceColors[random.Next(resourceColors.Count)],
                    ResourceIds = new ObservableCollection<object>() { resource.Id },
                });

                tasks.Add(new SchedulerAppointment()
                {
                    Subject = events[random.Next(events.Count)],
                    // StartTime and EndTime values specified with local system date will be converted to the Hijri calendar mentioned.
                    StartTime = new DateTime(2023, 02, 28, 11, 0, 0, 0),
                    EndTime = new DateTime(2023, 02, 28, 12, 0, 0, 0),
                    Background = resourceColors[random.Next(resourceColors.Count)],
                    ResourceIds = new ObservableCollection<object>() { resource.Id },
                });
            }

            return tasks;
        }

        /// <summary>
        /// Method to get colors for employee task and scheduler resources.
        /// </summary>
        /// <returns>resource colors</returns>
        private List<Brush> GetResourceColors()
        {
            return new List<Brush>
            {
                new SolidColorBrush(Color.FromArgb("#FF8B1FA9")),
                new SolidColorBrush(Color.FromArgb("#FFD20100")),
                new SolidColorBrush(Color.FromArgb("#FFFC571D")),
                new SolidColorBrush(Color.FromArgb("#FF36B37B")),
                new SolidColorBrush(Color.FromArgb("#FF3D4FB5")),
                new SolidColorBrush(Color.FromArgb("#FFE47C73")),
                new SolidColorBrush(Color.FromArgb("#FF85461E")),
                new SolidColorBrush(Color.FromArgb("#FF0F8644")),
            };
        }

    }
}
