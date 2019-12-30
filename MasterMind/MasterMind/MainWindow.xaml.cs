using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Threading;

namespace MasterMind
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DateTime dateTime = new DateTime();
        private readonly string path = @"..\..\Data\TextFileRecord.txt";
        public DispatcherTimer dispatcherTimer = new DispatcherTimer();
        public static string NewName = "";
        public List<Record> listRecord = new List<Record>();
        public List<int> SignList = new List<int>();
        public int CountColumnInput = 1;
        public int CountRowInput = 1;
        public string SignInput;
        public Random rnd = new Random();
        public int Target1;
        public int Target2;
        public int Target3;
        public int Target4;
        public Style styleStackPanel;
        public Style stylePicture;
        public Style styleEllipse;
        public Image imageSmile = new Image();
        public Image imageHerc = new Image();
        public Image imageCaro = new Image();
        public Image imagePic = new Image();
        public Image imageTref = new Image();
        public Image imageStar = new Image();
        public bool showSign = false;

        public class Record
        {
            public int Number { get; set; }
            public string Name { get; set; }
            public string Time { get; set; }
        }      

        public MainWindow()
        {
            InitializeComponent();
            styleStackPanel = FindResource("StyleStackPanel") as Style;
            stylePicture = FindResource("StylePicture") as Style;
            styleEllipse = FindResource("StyleEllipse") as Style;
            TimerSet();
            SetPictures();
            StartGame();
           
            
        }

        public void SetPictures()
        {            
            imageSmile.Source = new BitmapImage(new Uri(@"Pictures/SmileT.png", UriKind.Relative));           
            imageHerc.Source = new BitmapImage(new Uri(@"Pictures/Herc.png", UriKind.Relative));         
            imageCaro.Source = new BitmapImage(new Uri(@"Pictures/Caro.png", UriKind.Relative));         
            imagePic.Source = new BitmapImage(new Uri(@"Pictures/Pic.png", UriKind.Relative));          
            imageTref.Source = new BitmapImage(new Uri(@"Pictures/Tref.png", UriKind.Relative));          
            imageStar.Source = new BitmapImage(new Uri(@"Pictures/Star.png", UriKind.Relative));
            imageSmile.Style = stylePicture;
            imageHerc.Style = stylePicture;
            imageCaro.Style = stylePicture;
            imagePic.Style = stylePicture;
            imageTref.Style = stylePicture;
            imageStar.Style = stylePicture;
        }

        private void TimerSet()
        {
            dispatcherTimer.Tick += DispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
        }

        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            dateTime = dateTime.AddSeconds(1);
            LabelTime.Content = dateTime.ToString("mm:ss");
        }

        private void CreateTable()
        {
          
           
            for (int i = 1; i < 5; i++)
            {
                StackPanel stackPanelNew = new StackPanel();
                stackPanelNew.Name = "stackPanel1" + i.ToString();
                RegisterStackPanel(stackPanelNew.Name, stackPanelNew);
                stackPanelNew.Style = styleStackPanel;
                StackPanelInput1.Children.Add(stackPanelNew);               
            }
            for (int i = 1; i < 5; i++)
            {
                StackPanel stackPanelNew = new StackPanel();
                stackPanelNew.Name = "stackPanel2" + i.ToString();
                RegisterStackPanel(stackPanelNew.Name, stackPanelNew);
                stackPanelNew.Style = styleStackPanel;               
                StackPanelInput2.Children.Add(stackPanelNew);
            }
            for (int i = 1; i < 5; i++)
            {
                StackPanel stackPanelNew = new StackPanel();
                stackPanelNew.Name = "stackPanel3" + i.ToString();
                RegisterStackPanel(stackPanelNew.Name, stackPanelNew);
                stackPanelNew.Style = styleStackPanel;
                StackPanelInput3.Children.Add(stackPanelNew);
            }
            for (int i = 1; i < 5; i++)
            {
                StackPanel stackPanelNew = new StackPanel();
                stackPanelNew.Name = "stackPanel4" + i.ToString();
                RegisterStackPanel(stackPanelNew.Name, stackPanelNew);
                stackPanelNew.Style = styleStackPanel;
                StackPanelInput4.Children.Add(stackPanelNew);
            }
            for (int i = 1; i < 5; i++)
            {
                StackPanel stackPanelNew = new StackPanel();
                stackPanelNew.Name = "stackPanel5" + i.ToString();
                RegisterStackPanel(stackPanelNew.Name, stackPanelNew);
                stackPanelNew.Style = styleStackPanel;
                StackPanelInput5.Children.Add(stackPanelNew);
               
            }
            for (int i = 1; i < 5; i++)
            {
                StackPanel stackPanelNew = new StackPanel();
                stackPanelNew.Name = "stackPanel6" + i.ToString();
                RegisterStackPanel(stackPanelNew.Name , stackPanelNew);
                stackPanelNew.Style = styleStackPanel;
                StackPanelInput6.Children.Add(stackPanelNew);
               
            }

        }

        private void RegisterStackPanel(string textStackPanelName, StackPanel textStackPanel)
        {
            if ((StackPanel)this.FindName(textStackPanelName) != null)
                this.UnregisterName(textStackPanelName);
            this.RegisterName(textStackPanelName, textStackPanel);
        }

        public void PrintSign(string sign)
        {
            if (CountColumnInput >=5 || CountRowInput >= 7)
            {
                return;
            }
            StackPanel stackPanelNew = new StackPanel();
            stackPanelNew = FindName("stackPanel" + CountRowInput.ToString() + CountColumnInput.ToString()) as StackPanel;           

            if (sign == "Smile")
            {
                Image image = new Image();
                image.Source = new BitmapImage(new Uri(@"Pictures/SmileT.png", UriKind.Relative));
                image.Style = stylePicture;
                stackPanelNew.Children.Add(image);
                SignList.Add(1);
            }

            if (sign == "Herc")
            {
                Image image = new Image();
                image.Source = new BitmapImage(new Uri(@"Pictures/Herc.png", UriKind.Relative));
                image.Style = stylePicture;
                stackPanelNew.Children.Add(image);
                SignList.Add(2);
            }

            if (sign == "Caro")
            {
                Image image = new Image();
                image.Source = new BitmapImage(new Uri(@"Pictures/Caro.png", UriKind.Relative));
                image.Style = stylePicture;
                stackPanelNew.Children.Add(image);
                SignList.Add(3);
            }

            if (sign == "Pic")
            {
                Image image = new Image();
                image.Source = new BitmapImage(new Uri(@"Pictures/Pic.png", UriKind.Relative));
                image.Style = stylePicture;
                stackPanelNew.Children.Add(image);
                SignList.Add(4);
            }

            if (sign == "Tref")
            {
                Image image = new Image();
                image.Source = new BitmapImage(new Uri(@"Pictures/Tref.png", UriKind.Relative));
                image.Style = stylePicture;
                stackPanelNew.Children.Add(image);
                SignList.Add(5);
            }

            if (sign == "Star")
            {
                Image image = new Image();
                image.Source = new BitmapImage(new Uri(@"Pictures/Star.png", UriKind.Relative));
                image.Style = stylePicture;
                stackPanelNew.Children.Add(image);
                SignList.Add(6);
            }

            if (sign == "Delete")
            {
               
                stackPanelNew.Children.Clear();
                if (SignList.Count == 0)
                {
                    return;
                }
                SignList.RemoveAt(CountColumnInput-1);
                return;
            }
            CountColumnInput++;
        }

        public void StartGame()
        {
            CountRowInput = 1;
            CountColumnInput = 1;
            for (int i = 1; i <= 7; i++)
            {
                StackPanel stackPanelNew = new StackPanel();
                stackPanelNew = FindName("StackPanelInput" + CountRowInput.ToString()) as StackPanel;
                StackPanel stackPanelOutNew = new StackPanel();
                stackPanelOutNew = FindName("StackPanelOutput" + CountRowInput.ToString()) as StackPanel;
                if (stackPanelNew != null)
                {
                    stackPanelNew.Children.Clear();
                    stackPanelOutNew.Children.Clear();
                }
                if (stackPanelOutNew != null)
                {                  
                    stackPanelOutNew.Children.Clear();
                }
                TargetImage1.Source = new BitmapImage(new Uri(@"Pictures/questionmark.png", UriKind.Relative));
                TargetImage2.Source = new BitmapImage(new Uri(@"Pictures/questionmark.png", UriKind.Relative));
                TargetImage3.Source = new BitmapImage(new Uri(@"Pictures/questionmark.png", UriKind.Relative));
                TargetImage4.Source = new BitmapImage(new Uri(@"Pictures/questionmark.png", UriKind.Relative));
                CountRowInput++;
            }
            CountRowInput = 1;
            CreateTable();
            GetTarget();
            SignList.Clear();
            dateTime = dateTime.AddHours(-dateTime.Hour).AddMinutes(-dateTime.Minute).AddSeconds(-dateTime.Second);
            dispatcherTimer.Start();
           
        }

        private void GetTarget()
        {
            Target1 = rnd.Next(1, 6);
            Target2 = rnd.Next(1, 6);
            Target3 = rnd.Next(1, 6);
            Target4 = rnd.Next(1, 6);
        }

        private void ShowTarget()
        {                        
            switch (Target1)
                {
                    case 1:
                        TargetImage1.Source = new BitmapImage(new Uri(@"Pictures/SmileT.png", UriKind.Relative));
                        break;
                    case 2:
                        TargetImage1.Source = new BitmapImage(new Uri(@"Pictures/Herc.png", UriKind.Relative));
                        break;
                    case 3:
                        TargetImage1.Source = new BitmapImage(new Uri(@"Pictures/Caro.png", UriKind.Relative));
                        break;
                    case 4:
                        TargetImage1.Source = new BitmapImage(new Uri(@"Pictures/Pic.png", UriKind.Relative));
                        break;
                    case 5:
                        TargetImage1.Source = new BitmapImage(new Uri(@"Pictures/Tref.png", UriKind.Relative));
                        break;
                    case 6:
                        TargetImage1.Source = new BitmapImage(new Uri(@"Pictures/Star.png", UriKind.Relative));
                        break;

                    default:
                        break;
                }
            switch (Target2)
            {
                case 1:
                    TargetImage2.Source = new BitmapImage(new Uri(@"Pictures/SmileT.png", UriKind.Relative));
                    break;
                case 2:
                    TargetImage2.Source = new BitmapImage(new Uri(@"Pictures/Herc.png", UriKind.Relative));
                    break;
                case 3:
                    TargetImage2.Source = new BitmapImage(new Uri(@"Pictures/Caro.png", UriKind.Relative));
                    break;
                case 4:
                    TargetImage2.Source = new BitmapImage(new Uri(@"Pictures/Pic.png", UriKind.Relative));
                    break;
                case 5:
                    TargetImage2.Source = new BitmapImage(new Uri(@"Pictures/Tref.png", UriKind.Relative));
                    break;
                case 6:
                    TargetImage2.Source = new BitmapImage(new Uri(@"Pictures/Star.png", UriKind.Relative));
                    break;

                default:
                    break;
            }
            switch (Target3)
            {
                case 1:
                    TargetImage3.Source = new BitmapImage(new Uri(@"Pictures/SmileT.png", UriKind.Relative));
                    break;
                case 2:
                    TargetImage3.Source = new BitmapImage(new Uri(@"Pictures/Herc.png", UriKind.Relative));
                    break;
                case 3:
                    TargetImage3.Source = new BitmapImage(new Uri(@"Pictures/Caro.png", UriKind.Relative));
                    break;
                case 4:
                    TargetImage3.Source = new BitmapImage(new Uri(@"Pictures/Pic.png", UriKind.Relative));
                    break;
                case 5:
                    TargetImage3.Source = new BitmapImage(new Uri(@"Pictures/Tref.png", UriKind.Relative));
                    break;
                case 6:
                    TargetImage3.Source = new BitmapImage(new Uri(@"Pictures/Star.png", UriKind.Relative));
                    break;

                default:
                    break;
            }
            switch (Target4)
            {
                case 1:
                    TargetImage4.Source = new BitmapImage(new Uri(@"Pictures/SmileT.png", UriKind.Relative));
                    break;
                case 2:
                    TargetImage4.Source = new BitmapImage(new Uri(@"Pictures/Herc.png", UriKind.Relative));
                    break;
                case 3:
                    TargetImage4.Source = new BitmapImage(new Uri(@"Pictures/Caro.png", UriKind.Relative));
                    break;
                case 4:
                    TargetImage4.Source = new BitmapImage(new Uri(@"Pictures/Pic.png", UriKind.Relative));
                    break;
                case 5:
                    TargetImage4.Source = new BitmapImage(new Uri(@"Pictures/Tref.png", UriKind.Relative));
                    break;
                case 6:
                    TargetImage4.Source = new BitmapImage(new Uri(@"Pictures/Star.png", UriKind.Relative));
                    break;

                default:
                    break;
            }

        }

        private void EditTextFile(string time)
        {
           
            string data = "";
            if (!File.Exists(path))
            {
                MessageBox.Show("File TextFileRecord.txt not found");
                try
                {
                    using (FileStream fs = File.Create(path))
                    {

                    }
                    MessageBox.Show("File TextFileRecord.txt is created");
                }
                catch (Exception exc)
                {

                    MessageBox.Show("File TextFileRecord.txt is not created, error: " + exc);
                }
            }
            data = ((NewName + "      " + time.ToString()) + Environment.NewLine);
            File.AppendAllText(path, data);
            string[] line = File.ReadAllLines(path);
            listRecord.Clear();

            foreach (var item in line)
            {
                if (string.IsNullOrEmpty(item))
                {
                    continue;
                }
                Record record = new Record();
                record.Name = item.Substring(0, item.Length - 5);
                record.Time = (item.Substring(item.Length - 5, 5));
                listRecord.Add(record);

            }
            var NewlistRecord = listRecord.OrderBy(x => x.Time);
            int i = 1;
            foreach (var item in NewlistRecord)
            {
                item.Number = i; i++;
            }

            foreach (var item1 in NewlistRecord)
            {
                if (item1.Number > 10)
                {
                    listRecord.Remove(item1);
                }
            }
            NewlistRecord = listRecord.OrderBy(x => x.Number);
            File.WriteAllText(path, "");
            foreach (var item in NewlistRecord)
            {
                string Time = item.Time;
                data = (item.Name + " " + Time + Environment.NewLine);
                File.AppendAllText(path, data);
            }

            DataGridRecord.ItemsSource = null;
            DataGridRecord.Items.Clear();
            DataGridRecord.ItemsSource = NewlistRecord.ToList();
        }

        private void ReadRecord()
        {
            string[] line = File.ReadAllLines(path);
            listRecord.Clear();

            foreach (var item in line)
            {
                if (string.IsNullOrEmpty(item))
                {
                    continue;
                }
                Record record = new Record();
                record.Name = item.Substring(0, item.Length - 5);
                record.Time = (item.Substring(item.Length - 5, 5));
                listRecord.Add(record);

            }
            var NewlistRecord = listRecord.OrderBy(x => x.Time);
            int i = 1;
            foreach (var item in NewlistRecord)
            {
                item.Number = i; i++;
            }

            foreach (var item1 in NewlistRecord)
            {
                if (item1.Number > 10)
                {
                    listRecord.Remove(item1);
                }
            }
            NewlistRecord = listRecord.OrderBy(x => x.Number);
            File.WriteAllText(path, "");
            foreach (var item in NewlistRecord)
            {
                string Time = item.Time;
                var data = (item.Name + " " + Time + Environment.NewLine);
                File.AppendAllText(path, data);
            }

            DataGridRecord.ItemsSource = null;
            DataGridRecord.Items.Clear();
            DataGridRecord.ItemsSource = NewlistRecord.ToList();
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            ButtonClose.Visibility = Visibility.Hidden;
            GridRecord.Visibility = Visibility.Hidden;
           
            StartGame();
        }

        private void ButtonNewGame_Click(object sender, RoutedEventArgs e)
        {
            StartGame();
        }

        private void CheckInput()
        {
            bool Hit1 = false;
            bool Hit2 = false;
            bool Hit3 = false;
            bool Hit4 = false;           
            List<bool> SignListBool = new List<bool>();
            SignListBool.Add(false);
            SignListBool.Add(false);
            SignListBool.Add(false);
            SignListBool.Add(false);
            SignListBool[0] = false;
            SignListBool[1] = false;
            SignListBool[2] = false;
            SignListBool[3] = false;
            int countHit = 0;
            int countHitSign = 0;

            if (SignList[0] == Target1)
            {
                Hit1 = true;
                SignListBool[0] = true;
                countHit++;
            }
            if (SignList[1] == Target2)
            {
                Hit2 = true;
                SignListBool[1] = true;
                countHit++;
            }
            if (SignList[2] == Target3)
            {
                Hit3 = true;
                SignListBool[2] = true;
                countHit++;
            }
            if (SignList[3] == Target4)
            {
                Hit4 = true;
                SignListBool[3] = true;
                countHit++;
            }

            for (int i = 0; i < 4; i++)
            {
               
                if (SignList[i] == Target1 && Hit1 == false && SignListBool[i] == false)
                {
                    Hit1 = true;
                    SignListBool[i] = true;
                    countHitSign++;
                    continue;
                }
                if (SignList[i] == Target2 && Hit2 == false && SignListBool[i] == false)
                {
                    Hit2 = true;
                    SignListBool[i] = true;
                    countHitSign++;
                    continue;
                }
                if (SignList[i] == Target3 && Hit3 == false && SignListBool[i] == false)
                {
                    Hit3 = true;
                    SignListBool[i] = true;
                    countHitSign++;
                    continue;
                }
                if (SignList[i] == Target4 && Hit4 == false && SignListBool[i] == false)
                {
                    Hit4 = true;
                    SignListBool[i] = true;
                    countHitSign++;
                    continue;
                }
            }
            

            StackPanel stackPanelOut = new StackPanel();
                   
            stackPanelOut = FindName("StackPanelOutput" + (CountRowInput).ToString()) as StackPanel;
            if (countHit > 0)
            {
                for (int i = 1; i <= countHit; i++)
                {
                    //StackPanel stackPanelNew1 = new StackPanel();
                    //stackPanelNew1.Name = "StackPanelOutputCH" + CountRowInput.ToString() + i;
                    //RegisterStackPanel(stackPanelNew1.Name, stackPanelNew1);
                    //stackPanelNew1.Style = styleStackPanel;
                    //stackPanelNew1.Background = Brushes.Red;
                    //stackPanelNew1.Children.Add(ellipse);
                    Shape ellipse = new Ellipse();            
                    ellipse.Style = styleEllipse;
                    ellipse.Fill = Brushes.Red;                   
                    stackPanelOut.Children.Add(ellipse);
                    
                }
            }

            if (countHit == 4)
            {
                ShowTarget();
                dispatcherTimer.Stop();
                Win();
            }

            if (countHitSign > 0)
            {
                for (int i = 1; i <= countHitSign; i++)
                {
                    //StackPanel stackPanelNew2 = new StackPanel();
                    //stackPanelNew2.Name = "StackPanelOutputCH1" + CountRowInput.ToString() + i;
                    //RegisterStackPanel(stackPanelNew2.Name, stackPanelNew2);
                    //stackPanelNew2.Style = styleStackPanel;
                    //stackPanelNew2.Background = Brushes.Yellow;
                    //stackPanelOut.Children.Add(stackPanelNew2);
                    Shape ellipse = new Ellipse();
                    ellipse.Style = styleEllipse;
                    ellipse.Fill = Brushes.Yellow;
                    stackPanelOut.Children.Add(ellipse);
                }
            }
           
            SignList.Clear();
        }

        public void Win()
        {
            MessageBox.Show("You Win !!!");
           
            WindowNewName windowNewName = new WindowNewName();
            windowNewName.ShowDialog();           
            EditTextFile(dateTime.ToString("mm:ss"));          
            GridRecord.Visibility = Visibility.Visible;
            ButtonClose.Visibility = Visibility.Visible;
            StartGame();
        }

        public void Lose()
        {
            MessageBox.Show("You Lose !!!");

        }

        private void ButtonEnter_Click(object sender, RoutedEventArgs e)
        {                       
            if (CountColumnInput != 5)
            {
                return;
            }
            CountColumnInput = 1;
            CheckInput();
            CountRowInput++;
            if (CountRowInput >= 7)
            {
                ShowTarget();
                dispatcherTimer.Stop();
                Lose();
                return;
            }
           
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            SignInput = "Delete";
            CountColumnInput--;
            if (CountColumnInput <= 1)
            {
                CountColumnInput = 1;
            }
            PrintSign(SignInput);
        }

        private void StackPanelSmile_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
           
            SignInput = "Smile";
            PrintSign(SignInput);
        }
      
        private void StackPanelHerc_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
          
            SignInput = "Herc";
            PrintSign(SignInput);
        }

        private void StackPanelCaro_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            SignInput = "Caro";
            PrintSign(SignInput);
        }

        private void StackPanelPic_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            SignInput = "Pic";
            PrintSign(SignInput);
        }

        private void StackPanelTref_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            SignInput = "Tref";
            PrintSign(SignInput);
        }

        private void StackPanelStar_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            SignInput = "Star";
            PrintSign(SignInput);
        }

        private void LabelTime_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //if (showSign == false)
            //{
            //    showSign = true;
            //    ShowTarget();
            //}
            //else
            //{
            //    TargetImage1.Source = new BitmapImage(new Uri(@"Pictures/questionmark.png", UriKind.Relative));
            //    TargetImage2.Source = new BitmapImage(new Uri(@"Pictures/questionmark.png", UriKind.Relative));
            //    TargetImage3.Source = new BitmapImage(new Uri(@"Pictures/questionmark.png", UriKind.Relative));
            //    TargetImage4.Source = new BitmapImage(new Uri(@"Pictures/questionmark.png", UriKind.Relative));
            //    showSign = false;
            //}
           
        }
    }
}
