using DevExpress.Xpf.Core.Native;
using DevExpress.Xpf.Scheduler.Drawing;
using System;
using System.Windows;

namespace VisualDayViewExample {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            schedulerControl1.Start = DateTime.Today;
            schedulerControl1.ActiveView.SelectAppointment(schedulerControl1.Storage.AppointmentStorage[0]);   
        }

        private void btnApplyCustomStyle_Click(object sender, RoutedEventArgs e) {
            #region #ApplyCustomStyle
            VisualDayViewGroupByResource visualDayViewElement = LayoutHelper.FindElementByType(schedulerControl1, typeof(VisualDayViewGroupByResource)) as VisualDayViewGroupByResource;
            if (visualDayViewElement != null) {
                visualDayViewElement.Style = this.Resources.MergedDictionaries[2]["CustomDayViewGroupByResourceStyle"] as System.Windows.Style;
            }
            #endregion #ApplyCustomStyle
        }

        #region #CustomizeVisualViewInfo
        private void schedulerControl1_CustomizeVisualViewInfo(object sender, DevExpress.Xpf.Scheduler.CustomizeVisualViewInfoEventArgs e) {
            // Determine whether the currently active view is the Day View and appointments are grouped by resource.
            if (e.VisualViewInfo is VisualDayViewGroupByResource) {
                VisualDayViewGroupByResource dayViewByResource = (VisualDayViewGroupByResource)e.VisualViewInfo;
                // Hide day headers.
               dayViewByResource.ShowDayHeaders = false;
                // Hide time ruler headers.
                dayViewByResource.ShowTimeRulerHeader = false;
            }
        }
        #endregion #CustomizeVisualViewInfo
    }
}
