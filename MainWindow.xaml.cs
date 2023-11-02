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
using static System.Net.Mime.MediaTypeNames;

namespace DTP9_MUD_WPF_stub
{

    public partial class MainWindow : Window
    {
        string imgDir = "..\\..\\..\\images\\";
        public MainWindow()
        {
            InitializeComponent();
            // Gör all initiering nedanför den här texten!
            string title, text, warn, directions, decoration;


            decoration = "---------------------";
            warn = Labyrinth.WarningText();
            title = Labyrinth.CurrentTitle();
            text = Labyrinth.CurrentText();
            directions = Labyrinth.Directions();

            string StartText = $"{warn}\n{decoration}\n{text}\n" +
                $"{decoration}\n{directions}\n{decoration}";
            string Text() { return StartText; }//TODO: lägga den i Room.cs

            Title.Text = title;
            
            StoryField.Text = Text();
            Uri img = new Uri(imgDir+"illusion.png", UriKind.RelativeOrAbsolute);
            MainImage.Source = BitmapFrame.Create(img);
        }
        private void ApplicationKeyPress(object sender, KeyEventArgs e)
        {
            
            
           
            string output = "Key pressed: ";
            output += e.Key.ToString();
            KeyPressDisplay.Text = output;
            if (e.Key == Key.Escape)
            {
                System.Windows.Application.Current.Shutdown();
            }
            else if (e.Key == Key.H)
            {
                Title.Text = Labyrinth.HelpTitle();
                StoryField.Text = Labyrinth.HelpText();
                Uri img = new Uri(imgDir + "illusion2.png", UriKind.RelativeOrAbsolute);
                MainImage.Source = BitmapFrame.Create(img);
            }
            else if (e.Key == Key.W)
            {
                Labyrinth.DoCommand("w");
                Title.Text = "w";
                StoryField.Text = Labyrinth.CurrentText() + "\n" + Labyrinth.WarningText() + "\n" + Labyrinth.Directions();
                Uri img = new Uri(imgDir + "winterbath.png", UriKind.RelativeOrAbsolute);
                MainImage.Source = BitmapFrame.Create(img);
            }
            else if (e.Key == Key.S)
            {
                Labyrinth.DoCommand("s");
                Title.Text = "s";
                StoryField.Text = Labyrinth.CurrentText() + "\n" + Labyrinth.WarningText() + "\n" + Labyrinth.Directions();
                Uri img = new Uri(imgDir + "winterbath.png", UriKind.RelativeOrAbsolute);
                MainImage.Source = BitmapFrame.Create(img);
            }
            else if (e.Key == Key.A)
            {
                Labyrinth.DoCommand("a");
                Title.Text = "a";
                StoryField.Text = Labyrinth.CurrentText() + "\n" + Labyrinth.WarningText() + "\n" + Labyrinth.Directions();
                Uri img = new Uri(imgDir + "winterbath.png", UriKind.RelativeOrAbsolute);
                MainImage.Source = BitmapFrame.Create(img);
            }
            else if (e.Key == Key.D)
            {
                Labyrinth.DoCommand("D");
                Title.Text = "d";
                StoryField.Text = Labyrinth.CurrentText() + "\n" + Labyrinth.WarningText() + "\n" + Labyrinth.Directions();
                Uri img = new Uri(imgDir + "winterbath.png", UriKind.RelativeOrAbsolute);
                MainImage.Source = BitmapFrame.Create(img);
            }
        }
    }
}
