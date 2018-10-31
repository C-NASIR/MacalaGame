using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using  System.Windows.Media.Animation;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace MacalaGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Creating The Animation
        DoubleAnimation Animation = new DoubleAnimation();

        //Creating the Lists that will hold the Images
        List<Image> HoleA1list = new List<Image>();
        List<Image> HoleA2list = new List<Image>();
        List<Image> HoleA3list = new List<Image>();
        List<Image> HoleA4list = new List<Image>();
        List<Image> HoleA5list = new List<Image>();
        List<Image> HoleB1list = new List<Image>();
        List<Image> HoleB2list = new List<Image>();
        List<Image> HoleB3list = new List<Image>();
        List<Image> HoleB4list = new List<Image>();
        List<Image> HoleB5list = new List<Image>();
        public MainWindow()
        {
            InitializeComponent();

            //Adding the list to a contant
            HoleA1list = MakeArray(stoneA11, stoneA12, stoneA13, stoneA14);
            HoleA2list = MakeArray(stoneA21, stoneA22, stoneA23, stoneA24);
            HoleA3list = MakeArray(stoneA31, stoneA32, stoneA33, stoneA34);
            HoleA4list = MakeArray(stoneA41, stoneA42, stoneA43, stoneA44);
            HoleA5list = MakeArray(stoneA51, stoneA52, stoneA53, stoneA54);
            HoleB1list = MakeArray(stoneB11, stoneB12, stoneB13, stoneB14);
            HoleB2list = MakeArray(stoneB21, stoneB22, stoneB23, stoneB24);
            HoleB3list = MakeArray(stoneB31, stoneB32, stoneB33, stoneB34);
            HoleB4list = MakeArray(stoneB41, stoneB42, stoneB43, stoneB44);
            HoleB5list = MakeArray(stoneB51, stoneB52, stoneB53, stoneB54);


        }

        //Method to create the List
        public List<Image> MakeArray(Image Spot0, Image Spot1, Image Spot2, Image Spot3)
        {
            //Creating the lsit
            List<Image> ImageList = new List<Image>();
            
            //Filling the list
            ImageList.Add(Spot0);
            ImageList.Add(Spot1);
            ImageList.Add(Spot2);
            ImageList.Add(Spot3);

            //returning the array
            return ImageList;
        }

        //Method that creats the Animation
        public DoubleAnimation MakeAnimation(int by)
        {
            Animation.By = by;
            Animation.Duration = TimeSpan.FromSeconds(1.5);
            return Animation;
        }

        //The Method that moves the Images (Animates)
         public void Animate(List<Image> Stones)
         {
             int by = 0;

            foreach (var I in Stones)
            {
                by += 130;
                 MakeAnimation(by);
                I.BeginAnimation(Canvas.LeftProperty, Animation);
             }
         }

        // HoleA1 Click Evant (Moves the Stones In it)
        private void HoleA1_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Animate(HoleA1list);
        }

        //HoleA2 Click Event (Moves the Stones In it)
        private void HoleA2_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Animate(HoleA2list);
        }

        //HoleA3 Click Event (Moves the Stones In it)
        private void HoleA3_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Animate(HoleA3list);
        }

        //HoleA4 Click Event (Moves the Stones In it)
        private void HoleA4_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Animate(HoleA4list);
        }

        //HoleA5 Click Event (Moves the Stones In it)
        private void HoleA5_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Animate(HoleA5list);
        }

        //HoleB1 Click Event (Moves the Stones In it)
        private void HoleB1_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Animate(HoleB1list);
        }

        //HoleB2 Click Event (Moves the Stones In it)
        private void HoleB2_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Animate(HoleB2list);
        }

        //HoleB3 Click Event (Moves the Stones In it)
        private void HoleB3_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Animate(HoleB3list);
        }

        //HoleB4 Click Event (Moves the Stones In it)
        private void HoleB4_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Animate(HoleB4list);
        }

        //HoleB5 Click Event (Moves the Stones In it)
        private void HoleB5_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Animate(HoleB5list);
        }
    }
}
