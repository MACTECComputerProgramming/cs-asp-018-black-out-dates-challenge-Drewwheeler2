using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _018_Challenge_Drew_W
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public DateTime firstDate, secondDate;

        //button
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SetBlackOutDates(firstDate, secondDate);

            DateTime startTime = firstDate;
            DateTime endTime = secondDate;

            TimeSpan duration = endTime - startTime;

            labelAnswer.Content = duration;
        }

        public void secondCalendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            secondDate = CalendarTwo.SelectedDate.Value;
            answerLabelTwo.Content = secondDate;
        }

        public void firstCalendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            firstDate = calendarOne.SelectedDate.Value;
            answerLabel.Content = firstDate;
        }

        private void SetBlackOutDates(DateTime firstDate, DateTime secondDate)
        {
            blackoutCalender.BlackoutDates.Add(new CalendarDateRange(firstDate, secondDate));
        }
    }
}
