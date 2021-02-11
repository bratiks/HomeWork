using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace hallelujah_dz2_2
{

    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
            this.Icon = new Icon("../../icon.ico");
            LoadMonthCalendar();
            listbox_priority.SelectedIndex = listbox_priority.Items.IndexOf("Середній");
            listbox_events.DisplayMember = "eventInfo";
        }

        [XmlElement] List<Event> myEvents = new List<Event>();
        DateTime tempDate;

        private void btn_addEvent_Click(object sender, EventArgs e)
        {
            Event myEvent = new Event();
            myEvent.date = tempDate;

            if (tb_eventName.Text == String.Empty) { tb_eventName.Select(); MessageBox.Show("Введіть назву події", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            else { myEvent.eventName = tb_eventName.Text; tb_eventName.Text = String.Empty; }
            if (tb_eventPlace.Text != String.Empty) { myEvent.eventPlace = tb_eventPlace.Text; tb_eventPlace.Text = String.Empty;}
            else { myEvent.eventPlace = String.Empty; }

            myEvent.priority = listbox_priority.SelectedItem.ToString();
            myEvent.SetInfo();

            myEvents.Add(myEvent);
            listbox_events.Items.Add(myEvent);

            tb_eventPlace.Text = String.Empty;
            tb_eventName.Text = String.Empty;

        }

        private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime date = new DateTime(monthCalendar.SelectionRange.Start.Year, monthCalendar.SelectionRange.Start.Month, monthCalendar.SelectionRange.Start.Day);
            monthCalendar.BoldedDates = new DateTime[] { date };
            tempDate = date;
        }

        private void btn_deleteAllEvents_Click(object sender, EventArgs e)
        {
            listbox_events.Items.Clear();
            myEvents.Clear();
        }

        private void btn_deleteEvent_Click(object sender, EventArgs e)
        {
            if(listbox_events.SelectedItem == null) { MessageBox.Show("Виберіть подію з списка", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            myEvents.RemoveAt(listbox_events.SelectedIndex);
            listbox_events.Items.RemoveAt(listbox_events.SelectedIndex);
            
        }

        private void LoadMonthCalendar()
        {
            int changeDateRange = 200;

            monthCalendar.MinDate = monthCalendar.TodayDate;
            monthCalendar.MaxDate = new DateTime(monthCalendar.TodayDate.Year + changeDateRange, monthCalendar.TodayDate.Month, monthCalendar.TodayDate.Day);
            monthCalendar.SetSelectionRange(monthCalendar.TodayDate, monthCalendar.TodayDate);

            monthCalendar.BoldedDates = new DateTime[] { new DateTime(monthCalendar.TodayDate.Year, monthCalendar.TodayDate.Month, monthCalendar.TodayDate.Day) };

            monthCalendar.MaxSelectionCount = 1;

            tempDate = monthCalendar.TodayDate;
        }
        [Serializable] public class Event
        {
            public string eventName { get; set; }
            public DateTime date { get; set; }
            public string priority { get; set; }
            public string eventPlace { get; set; }
            public string eventInfo { get; set; }

            public void SetInfo()
            {
                if (eventPlace == String.Empty) { eventInfo = $"Подія: {eventName}  \t Дата: {date.ToShortDateString()}\t Приорітет: {priority}"; }
                else
                {
                    eventInfo = $"Подія: {eventName} \tМісце: {eventPlace} \tДата: {date.ToShortDateString()}\t Приорітет: {priority}";
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Event>));

            using (FileStream fs = new FileStream($"../../{monthCalendar.TodayDate.ToShortDateString()}.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, myEvents);

            }
        }
    }
}
