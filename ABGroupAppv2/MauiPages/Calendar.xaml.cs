using DevExpress.Maui.Scheduler;
using System.ComponentModel;

namespace ABGroupAppv2.MauiPages
{
    public partial class Calendar
    {
        public Calendar()
        {
            BindingContext = new ReceptionDeskViewModel();
            InitializeComponent();

        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
        //
        //Day View
        //
        private void DayView_OnTap(object sender, SchedulerGestureEventArgs e)
        {
            if (e.AppointmentInfo == null)
            {
                ShowNewAppointmentEditDayPage(e.IntervalInfo);
                return;
            }
            AppointmentItem appointment = e.AppointmentInfo.Appointment;
            ShowAppointmentEditDayPage(appointment);
        }

        private void ShowAppointmentEditDayPage(AppointmentItem appointment)
        {
            AppointmentEditPage appEditPage = new AppointmentEditPage(appointment, this.storageday);
            Navigation.PushAsync(appEditPage);
        }

        private void ShowNewAppointmentEditDayPage(IntervalInfo info)
        {
            AppointmentEditPage appEditPage = new AppointmentEditPage(info.Start, info.End,
                                                                     info.AllDay, this.storageday);
            Navigation.PushAsync(appEditPage);
        }
        //
        //Week View
        //
        private void WorkWeekView_Tap(object sender, SchedulerGestureEventArgs e)
        {
            if (e.AppointmentInfo == null)
            {
                ShowNewAppointmentEditWeekPage(e.IntervalInfo);
                return;
            }
            AppointmentItem appointment = e.AppointmentInfo.Appointment;
            ShowAppointmentEditWeekPage(appointment);
        }

        private void ShowAppointmentEditWeekPage(AppointmentItem appointment)
        {
            AppointmentEditPage appEditPage = new AppointmentEditPage(appointment, this.storageweek);
            Navigation.PushAsync(appEditPage);
        }

        private void ShowNewAppointmentEditWeekPage(IntervalInfo info)
        {
            AppointmentEditPage appEditPage = new AppointmentEditPage(info.Start, info.End,
                                                                     info.AllDay, this.storageweek);
            Navigation.PushAsync(appEditPage);
        }
        //
        //
        //
        public class ReceptionDeskViewModel : INotifyPropertyChanged
        {
            readonly ReceptionDeskData data;

            public event PropertyChangedEventHandler PropertyChanged;
            public DateTime StartDate { get { return ReceptionDeskData.BaseDate; } }
            public IReadOnlyList<MedicalAppointment> MedicalAppointments
            { get => data.MedicalAppointments; }

            public IReadOnlyList<MedicalAppointmentType> AppointmentTypes { get => data.Labels; }

            public ReceptionDeskViewModel()
            {
                data = new ReceptionDeskData();
            }

            protected void RaisePropertyChanged(string name)
            {
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}

    //public class Employee
    //{
    //    public string Name { get; set; }
    //    public DateTime BirthDate { get; set; }
    //    public bool OnLeave { get; set; }

    //}


