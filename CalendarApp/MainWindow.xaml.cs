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

namespace CalendarApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly BirthdayModel _birthdayModel;

        public MainWindow()
        {
            _birthdayModel = new BirthdayModel();
            InitializeComponent();
        }

        private void OnCalendarChange(object sender, SelectionChangedEventArgs e)
        {

            _birthdayModel.Birthday = MainPicker.SelectedDate ?? DateTime.Now;

            TextBlockAge.Text = "Your age:\n" + _birthdayModel.Age;
            TextBlockWestZodiac.Text = "Western zodiac:\n" + _birthdayModel.WestZodiac;
            TextBlockChiniseZodiac.Text = "Chinise zodiac:\n" + _birthdayModel.ChineseZodiac;
            if (!_birthdayModel.Valid)
            {
                MessageBox.Show("You entered invalid date!", "DatePickerError", MessageBoxButton.OK, MessageBoxImage.Asterisk);
            }
            else
            {
                if (_birthdayModel.IsBirthday)
                {
                    MessageBox.Show("Happy birthday, bro/sister!!! <3");
                }
            }
        }
    }
}
