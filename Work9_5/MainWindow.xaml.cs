using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using static Work5_5.Work5_5;
using static Work5_5.Work5_5;

namespace Work9_5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ReverseText_OnClick(object sender, RoutedEventArgs e)
        {
            ReverseText.Text = GetStringWithReverseOrderWords(InputText.Text);
        }

        private void SplitText_OnClick(object sender, RoutedEventArgs e)
        {
            WordList.ItemsSource = SplitString(InputText.Text); 
        }

        private void BaseText_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            ClearListAndText();
            
            if (InputText.Text.Length > 0)
                SetButtonEnable(true);
            else
                SetButtonEnable(false);
        }

        private void ClearListAndText()
        {
            WordList.ItemsSource = new String[]{};
            ReverseText.Text = "";
        }
        
        private void SetButtonEnable(bool value)
        {
            ButtonReverseText.IsEnabled = value;
            ButtonSplitText.IsEnabled = value;
        }
        
        private string GetStringWithReverseOrderWords(string text, char stringDelimiter = ' ')
        {
            string[] wordsArray = SplitString(text, stringDelimiter);
            Array.Reverse(wordsArray);
            return String.Join(stringDelimiter.ToString(), wordsArray);
        }
    }
}