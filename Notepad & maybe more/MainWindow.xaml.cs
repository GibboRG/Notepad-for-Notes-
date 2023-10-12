using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
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

namespace Notepad___maybe_more
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Main Window Setup
            double screenWidth = SystemParameters.PrimaryScreenWidth;
            double screenHeight = SystemParameters.PrimaryScreenHeight;
            this.Height = screenHeight * 2;
            this.Width = screenWidth * 0.3;
            this.Left = SystemParameters.PrimaryScreenWidth - this.Width;
            this.Top = 0;
            this.WindowStyle = WindowStyle.None;
            this.Topmost = true;
            // this.Visibility = Visibility.Hidden;

        }

        private void TitleBar_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            // Prevent moving the window
            e.Handled = true;
        }
    }

    public class Note
    {
        public string TextContent { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateDue { get; set; }

        public Note(string content)
        {
            TextContent = content;
            IsCompleted = false;
            DateCreated = DateTime.Now;

        }

    }
}
