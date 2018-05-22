using Oguzhan.Scrum.DAL.Implementations;
using Oguzhan.Scrum.Models.Models;
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

namespace Oguzhan.Scrum.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        #region Page Definations
        StoriesService _StoriesService;
        #endregion

        public MainWindow()
        {
            InitializeComponent();
            _StoriesService = new StoriesService();
            FillAllTable();
        }
        public void ChangeControll(WrapPanel panel, UCHistoryView changeObject)
        {
            if (panel.Children.Count == 0)
            {
                panel.Children.Add(changeObject);
            }
            else
            {
                panel.Children.Insert(0, changeObject);
                for (int i = 0; i < panel.Children.Count; i++)
                {
                    if (panel.Children.Count == 1) break;
                    if (panel.Children.Count - 1 == i) break;
                    if ((panel.Children[i] as UCHistoryView).SelectedStories.ProcessDate > (panel.Children[i + 1] as UCHistoryView).SelectedStories.ProcessDate)
                    {
                        panel.Children.RemoveAt(i);
                        panel.Children.Insert(i + 1, changeObject);

                    }
                }
            }
        }
        public void ChangeObject(WrapPanel deleteObject, UCHistoryView changeObject)
        {
            deleteObject.Children.Remove(changeObject);
            if (changeObject.SelectedStories.ElementType == GeneralVariable.ElementType.InProgress.GetHashCode())
            {
                if (changeObject.SelectedStories.Position == 1)
                    ChangeControll(wrp_InProgress, changeObject);
                else if (changeObject.SelectedStories.Position == 2)
                    ChangeControll(wrp_InProgress2, changeObject);
                else
                    ChangeControll(wrp_InProgress3, changeObject);
            }
            else if (changeObject.SelectedStories.ElementType == GeneralVariable.ElementType.Done.GetHashCode())
            {
                if (changeObject.SelectedStories.Position == 1)
                    ChangeControll(wrp_Done, changeObject);
                else if (changeObject.SelectedStories.Position == 2)
                    ChangeControll(wrp_Done2, changeObject);
                else
                    ChangeControll(wrp_Done3, changeObject);
            }
            else if (changeObject.SelectedStories.ElementType == GeneralVariable.ElementType.NotStarted.GetHashCode())
            {
                if (changeObject.SelectedStories.Position == 1)
                    ChangeControll(wrp_NotStarted, changeObject);
                else if (changeObject.SelectedStories.Position == 2)
                    ChangeControll(wrp_NotStarted2, changeObject);
                else
                    ChangeControll(wrp_NotStarted3, changeObject);
            }
        }
        public void FillAllTable()
        {
            List<Stories> tempList = _StoriesService.GetAll();
            if (tempList == null)
            {
            }
            else
            {
                foreach (Stories item in tempList)
                {
                    if (item.ElementType == GeneralVariable.ElementType.NewStory.GetHashCode())
                    {
                        Label tempLabel = new Label();
                        tempLabel.Content = item.Value;
                        tempLabel.HorizontalContentAlignment = HorizontalAlignment.Center;
                        if (item.Position == 1)
                            wrp_Stroies.Children.Add(tempLabel);
                        else if (item.Position == 2)
                            wrp_Stroies2.Children.Add(tempLabel);
                        else
                            wrp_Stroies3.Children.Add(tempLabel);
                    }
                    else if (item.ElementType == GeneralVariable.ElementType.InProgress.GetHashCode())
                    {
                        UCHistoryView tt = new UCHistoryView(item);
                        if (item.Position == 1)
                            wrp_InProgress.Children.Add(tt);
                        else if (item.Position == 2)
                            wrp_InProgress2.Children.Add(tt);
                        else
                            wrp_InProgress3.Children.Add(tt);
                    }
                    else if (item.ElementType == GeneralVariable.ElementType.NotStarted.GetHashCode())
                    {
                        UCHistoryView tt = new UCHistoryView(item);
                        if (item.Position == 1)
                            wrp_NotStarted.Children.Add(tt);
                        else if (item.Position == 2)
                            wrp_NotStarted2.Children.Add(tt);
                        else
                            wrp_NotStarted3.Children.Add(tt);
                    }
                    else if (item.ElementType == GeneralVariable.ElementType.Done.GetHashCode())
                    {
                        UCHistoryView tt = new UCHistoryView(item);
                        if (item.Position == 1)
                            wrp_Done.Children.Add(tt);
                        else if (item.Position == 2)
                            wrp_Done2.Children.Add(tt);
                        else
                            wrp_Done3.Children.Add(tt);
                    }
                }
            }
        }

        private void btn_NewStories_Click(object sender, RoutedEventArgs e)
        {
            NewStoriesControl(wrp_Stroies, 1);
        }

        private void btn_NewStarted_Click(object sender, RoutedEventArgs e)
        {
            NewStartedControl(wrp_NotStarted, 1);
        }

        private void btn_NewStarted_Click2(object sender, RoutedEventArgs e)
        {
            NewStartedControl(wrp_NotStarted2, 2);
        }
        public void NewStartedControl(WrapPanel panel, int position)
        {
            NewStoryView frm = new NewStoryView();
            frm.ShowDialog();
            if (frm.NewStory != null && frm.NewStory.Trim() != "" && frm.NewStorydate != null)
            {
                Stories tempStories = new Stories();
                tempStories.Value = frm.NewStory +Environment.NewLine + frm.NewStorydate;
                tempStories.ElementType = GeneralVariable.ElementType.NotStarted.GetHashCode();
                tempStories.Position = position;
                if (_StoriesService.Add(tempStories))
                {
                    UCHistoryView tt = new UCHistoryView(tempStories);

                    panel.Children.Add(tt);
                }
                else
                {
                    MessageBox.Show("KAYIT ESNASINDA SORUNLA KARŞILAŞILDI.");
                }
            }

        }
        private void btn_NewStarted_Click3(object sender, RoutedEventArgs e)
        {
            NewStartedControl(wrp_NotStarted3, 3);
        }

        private void btn_NewStories_Click2(object sender, RoutedEventArgs e)
        {
            NewStoriesControl(wrp_Stroies2, 2);
        }
        public void NewStoriesControl(WrapPanel panel, int position)
        {
            NewStoryView frm = new NewStoryView();
            frm.ShowDialog();
            if (frm.NewStory != null && frm.NewStory.Trim() != "")
            {
                Stories tempStories = new Stories();
                tempStories.Value = frm.NewStory+Environment.NewLine+frm.NewStorydate;
                tempStories.ElementType = GeneralVariable.ElementType.NewStory.GetHashCode();
                tempStories.Position = position;
                if (_StoriesService.Add(tempStories))
                {
                    Label tempLabel = new Label();
                    tempLabel.Content = frm.NewStory+Environment.NewLine+frm.NewStorydate;
                    tempLabel.HorizontalContentAlignment = HorizontalAlignment.Center;
                    tempLabel.VerticalContentAlignment = VerticalAlignment.Center;
                    panel.Children.Clear();
                    panel.Children.Add(tempLabel);
                }
                else
                {
                    MessageBox.Show("KAYIT ESNASINDA SORUNLA KARŞILAŞILDI.");
                }
            }
        }
        private void btn_NewStories_Click3(object sender, RoutedEventArgs e)
        {
            NewStoriesControl(wrp_Stroies3, 3);
        }

        private void btn_NewStoriesDelete_Click(object sender, RoutedEventArgs e)
        {
            DeleteStories(wrp_Stroies, 1);
        }

        private void btn_NewStoriesDelete_Click2(object sender, RoutedEventArgs e)
        {
            DeleteStories(wrp_Stroies2, 2);
        }

        private void btn_NewStoriesDelete_Click3(object sender, RoutedEventArgs e)
        {
            DeleteStories(wrp_Stroies3, 3);
        }
        public void DeleteStories(WrapPanel panel, int position)
        {
            foreach (var item in _StoriesService.GetAll())
            {
                if (item.Value == (panel.Children[0] as Label).Content.ToString() && item.Position == position)
                {
                    _StoriesService.Delete(item);
                    panel.Children.Clear();
                    break;
                }
            }
        }
    }
}
