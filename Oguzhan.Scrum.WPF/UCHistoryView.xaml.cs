using Oguzhan.Scrum.DAL.Implementations;
using Oguzhan.Scrum.Models.Models;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Oguzhan.Scrum.WPF
{
    /// <summary>
    /// Interaction logic for UCHistoryView.xaml
    /// </summary>
    public partial class UCHistoryView : UserControl,INotifyPropertyChanged
    {

        private string _XValue;

        public string XValue
        {
            get { return _XValue; }
            set
            {
                _XValue = value;
                NotifyPropertyChanged();
            }
        }

        private Stories _SelectedStories;

        public Stories SelectedStories
        {
            get { return _SelectedStories; }
            set
            {
                _SelectedStories = value;
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
        StoriesService _StoriesService;
        public UCHistoryView(Stories selectedStories)
        {
            InitializeComponent();
            DataContext = this;
            SelectedStories = selectedStories;
            XValue = selectedStories.Value;
            _StoriesService = new StoriesService();
        }

        private void btn_NotStarted_Click(object sender, RoutedEventArgs e)
        {
            SelectedStories.ElementType = GeneralVariable.ElementType.NotStarted.GetHashCode();
            foreach (var item in _StoriesService.GetAll().ToList())
            {
                if (SelectedStories.Value == item.Value)
                    SelectedStories.Position = item.Position;
            }
            _StoriesService.Update(SelectedStories);
            dynamic ff = Application.Current.MainWindow;
            ff.ChangeObject(this.Parent as WrapPanel, this as UCHistoryView);

        }

        private void btn_InProgress_Click(object sender, RoutedEventArgs e)
        {
            SelectedStories.ElementType = GeneralVariable.ElementType.InProgress.GetHashCode();
            foreach (var item in _StoriesService.GetAll().ToList())
            {
                if (SelectedStories.Value == item.Value)
                    SelectedStories.Position = item.Position;
            }
            _StoriesService.Update(SelectedStories);
            dynamic ff = Application.Current.MainWindow;
            ff.ChangeObject(this.Parent as WrapPanel, this as UCHistoryView);
        }

        private void btn_Done_Click(object sender, RoutedEventArgs e)
        {
            SelectedStories.ElementType = GeneralVariable.ElementType.Done.GetHashCode();
            foreach (var item in _StoriesService.GetAll().ToList())
            {
                if (SelectedStories.Value == item.Value)
                    SelectedStories.Position = item.Position;
            }
            _StoriesService.Update(SelectedStories);
            dynamic ff = Application.Current.MainWindow;
            ff.ChangeObject(this.Parent as WrapPanel, this as UCHistoryView);
        }

        private void btn_Delete_Click(object sender, RoutedEventArgs e)
        {
            _StoriesService.Delete(SelectedStories);
            (this.Parent as WrapPanel).Children.Remove(this as UCHistoryView);
        }
    }
}
