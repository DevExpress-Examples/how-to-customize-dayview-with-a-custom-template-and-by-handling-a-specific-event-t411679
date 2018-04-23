using System;
using System.Windows;
using System.Windows.Input;
using DevExpress.Xpf.Core.Commands;
using System.Collections.ObjectModel;

namespace VisualDayViewExample {
    public class SchedulerViewModel {
        public ObservableCollection<ModelAppointment> Appointments { get; private set; }
        public ObservableCollection<ModelResource> Resources { get; private set; }

        public SchedulerViewModel() {
            Appointments = new ObservableCollection<ModelAppointment>();
            Resources = new ObservableCollection<ModelResource>();
            AddTestData();
        }
        private void AddTestData() {
            ModelResource res1 = new ModelResource() {
                Id = 0,
                Name = "Resource 1",
                Color = 0xebecf0
            };

            ModelResource res2 = new ModelResource() {
                Id = 1,
                Name = "Resource 2",
                Color = 0xc1c5d6
            };

            ModelResource res3 = new ModelResource() {
                Id = 2,
                Name = "Resource 3",
                Color = 0x787fa0
            };

            Resources.Add(res1);
            Resources.Add(res2);
            Resources.Add(res3);

            DateTime baseTime = DateTime.Now;

            ModelAppointment apt1 = new ModelAppointment() {
                StartTime = baseTime.AddHours(1),
                EndTime = baseTime.AddHours(2),
                Subject = "Test",
                Location = "Office",
                Description = "Test procedure",
                Price = 10m,
                ResourceId = 1
            };

            ModelAppointment apt2 = new ModelAppointment() {
                StartTime = baseTime.AddHours(2),
                EndTime = baseTime.AddHours(3),
                Subject = "Test2",
                Location = "Office",
                Description = "Test procedure",
                ResourceId = 2
            };

            Appointments.Add(apt1);
            Appointments.Add(apt2);
        }
    }
}