using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Oguzhan.Scrum.WPF
{
    /// <summary>
    /// Interaction logic for NewStoryView.xaml
    /// </summary>
    public partial class NewStoryView : Window, INotifyPropertyChanged
    {
        #region Property Definations

        private string _NewStory;
        public string NewStory
        {
            get { return _NewStory; }
            set
            {
                _NewStory = value;
                NotifyPropertyChanged();
            }
        }
        private string _NewStorydate;
        public string NewStorydate
        {
            get { return _NewStorydate; }
            set
            {
                _NewStorydate = value;
                NotifyPropertyChanged();
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
        public NewStoryView()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void btn_Add_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void txt_NewStory_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
