using System;
using System.IO;
using System.Windows;
using System.Windows.Media.Imaging;

namespace ii
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Label.Content = "Loaded";
        }

        public void OpenImage(string imagePath)
        {
            var path = Path.Combine(Environment.CurrentDirectory, imagePath);
            var imageUri = new Uri(path);
            
            Label.Content = imagePath;
            
            var image = new BitmapImage(imageUri);
            Image.Source = image;
            Width = image.Width;
            Height = image.Height;
        }
    }
}