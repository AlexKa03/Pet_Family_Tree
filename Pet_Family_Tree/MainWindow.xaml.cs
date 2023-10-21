using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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

namespace Pet_s_Family_Tree
{
    public partial class MainWindow : Window
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Programing\Pet's Family Tree\Pet's Family Tree\Database.mdf"";Integrated Security=True";
        int counter = 1;

        public MainWindow()
        {
            InitializeComponent();
            LoadButtonsFromDatabase();


            Height = 563;
            Width = 950;
        }

        public class DataRowModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Breed { get; set; }
            public string Color { get; set; }
            public string Gender { get; set; }
        }

        private void LoadButtonsFromDatabase()
        {
            DrawingLines();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM Pets", connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DataRowModel model = new DataRowModel
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Breed = reader.GetString(2),
                            Color = reader.GetString(4),
                            Gender = reader.GetString(5),
                        };

                        Button button = this.FindName($"Button{counter}") as Button;
                        if (button != null)
                        {
                            button.Content = model.Name;
                            button.Tag = model;
                            button.Click += Button_Click;
                        }

                        counter++;
                    }
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = sender as Button;
            DataRowModel model = clickedButton.Tag as DataRowModel;

            Information.Content = $"Name: {model.Name}, Breed: {model.Breed}, Color: {model.Color}, Gender: {model.Gender}";
        }

        #region Draw Lines
        private void DrawingLines()
        {
            ArrowLine1.X1 = Button1.Margin.Left + Button1.Width;
            ArrowLine1.Y1 = Button1.Margin.Top + Button1.Height / 2;
            ArrowLine1.X2 = Button17.Margin.Left + 5;
            ArrowLine1.Y2 = Button17.Margin.Top + Button17.Height / 2;

            ArrowLine2.X1 = Button2.Margin.Left + Button2.Width;
            ArrowLine2.Y1 = Button2.Margin.Top + Button2.Height / 2;
            ArrowLine2.X2 = Button17.Margin.Left + 5;
            ArrowLine2.Y2 = Button17.Margin.Top + Button17.Height / 2;

            ArrowLine3.X1 = Button3.Margin.Left + Button3.Width;
            ArrowLine3.Y1 = Button3.Margin.Top + Button3.Height / 2;
            ArrowLine3.X2 = Button18.Margin.Left + 5;
            ArrowLine3.Y2 = Button18.Margin.Top + Button18.Height / 2;

            ArrowLine4.X1 = Button4.Margin.Left + Button4.Width;
            ArrowLine4.Y1 = Button4.Margin.Top + Button4.Height / 2;
            ArrowLine4.X2 = Button18.Margin.Left + 5;
            ArrowLine4.Y2 = Button18.Margin.Top + Button18.Height / 2;

            ArrowLine5.X1 = Button5.Margin.Left + Button5.Width;
            ArrowLine5.Y1 = Button5.Margin.Top + Button5.Height / 2;
            ArrowLine5.X2 = Button19.Margin.Left + 5;
            ArrowLine5.Y2 = Button19.Margin.Top + Button19.Height / 2;

            ArrowLine6.X1 = Button6.Margin.Left + Button6.Width;
            ArrowLine6.Y1 = Button6.Margin.Top + Button6.Height / 2;
            ArrowLine6.X2 = Button19.Margin.Left + 5;
            ArrowLine6.Y2 = Button19.Margin.Top + Button19.Height / 2;

            ArrowLine7.X1 = Button7.Margin.Left + Button7.Width;
            ArrowLine7.Y1 = Button7.Margin.Top + Button7.Height / 2;
            ArrowLine7.X2 = Button20.Margin.Left + 5;
            ArrowLine7.Y2 = Button20.Margin.Top + Button20.Height / 2;

            ArrowLine8.X1 = Button8.Margin.Left + Button8.Width;
            ArrowLine8.Y1 = Button8.Margin.Top + Button8.Height / 2;
            ArrowLine8.X2 = Button20.Margin.Left + 5;
            ArrowLine8.Y2 = Button20.Margin.Top + Button20.Height / 2;

            ArrowLine9.X1 = Button9.Margin.Left + Button9.Width;
            ArrowLine9.Y1 = Button9.Margin.Top + Button9.Height / 2;
            ArrowLine9.X2 = Button21.Margin.Left + 5;
            ArrowLine9.Y2 = Button21.Margin.Top + Button21.Height / 2;

            ArrowLine10.X1 = Button10.Margin.Left + Button10.Width;
            ArrowLine10.Y1 = Button10.Margin.Top + Button10.Height / 2;
            ArrowLine10.X2 = Button21.Margin.Left + 5;
            ArrowLine10.Y2 = Button21.Margin.Top + Button21.Height / 2;

            ArrowLine11.X1 = Button11.Margin.Left + Button11.Width;
            ArrowLine11.Y1 = Button11.Margin.Top + Button11.Height / 2;
            ArrowLine11.X2 = Button22.Margin.Left + 5;
            ArrowLine11.Y2 = Button22.Margin.Top + Button22.Height / 2;

            ArrowLine12.X1 = Button12.Margin.Left + Button12.Width;
            ArrowLine12.Y1 = Button12.Margin.Top + Button12.Height / 2;
            ArrowLine12.X2 = Button22.Margin.Left + 5;
            ArrowLine12.Y2 = Button22.Margin.Top + Button22.Height / 2;

            ArrowLine13.X1 = Button13.Margin.Left + Button13.Width;
            ArrowLine13.Y1 = Button13.Margin.Top + Button13.Height / 2;
            ArrowLine13.X2 = Button23.Margin.Left + 5;
            ArrowLine13.Y2 = Button23.Margin.Top + Button23.Height / 2;

            ArrowLine14.X1 = Button14.Margin.Left + Button14.Width;
            ArrowLine14.Y1 = Button14.Margin.Top + Button14.Height / 2;
            ArrowLine14.X2 = Button23.Margin.Left + 5;
            ArrowLine14.Y2 = Button23.Margin.Top + Button23.Height / 2;

            ArrowLine15.X1 = Button15.Margin.Left + Button15.Width;
            ArrowLine15.Y1 = Button15.Margin.Top + Button15.Height / 2;
            ArrowLine15.X2 = Button24.Margin.Left + 5;
            ArrowLine15.Y2 = Button24.Margin.Top + Button24.Height / 2;

            ArrowLine16.X1 = Button16.Margin.Left + Button16.Width;
            ArrowLine16.Y1 = Button16.Margin.Top + Button16.Height / 2;
            ArrowLine16.X2 = Button24.Margin.Left + 5;
            ArrowLine16.Y2 = Button24.Margin.Top + Button24.Height / 2;

            ArrowLine17.X1 = Button17.Margin.Left + Button17.Width;
            ArrowLine17.Y1 = Button17.Margin.Top + Button17.Height / 2;
            ArrowLine17.X2 = Button25.Margin.Left + 5;
            ArrowLine17.Y2 = Button25.Margin.Top + Button25.Height / 2;

            ArrowLine18.X1 = Button18.Margin.Left + Button18.Width;
            ArrowLine18.Y1 = Button18.Margin.Top + Button18.Height / 2;
            ArrowLine18.X2 = Button25.Margin.Left + 5;
            ArrowLine18.Y2 = Button25.Margin.Top + Button25.Height / 2;

            ArrowLine19.X1 = Button19.Margin.Left + Button19.Width;
            ArrowLine19.Y1 = Button19.Margin.Top + Button19.Height / 2;
            ArrowLine19.X2 = Button26.Margin.Left + 5;
            ArrowLine19.Y2 = Button26.Margin.Top + Button26.Height / 2;

            ArrowLine20.X1 = Button20.Margin.Left + Button20.Width;
            ArrowLine20.Y1 = Button20.Margin.Top + Button20.Height / 2;
            ArrowLine20.X2 = Button26.Margin.Left + 5;
            ArrowLine20.Y2 = Button26.Margin.Top + Button26.Height / 2;

            ArrowLine21.X1 = Button21.Margin.Left + Button21.Width;
            ArrowLine21.Y1 = Button21.Margin.Top + Button21.Height / 2;
            ArrowLine21.X2 = Button27.Margin.Left + 5;
            ArrowLine21.Y2 = Button27.Margin.Top + Button27.Height / 2;

            ArrowLine22.X1 = Button22.Margin.Left + Button22.Width;
            ArrowLine22.Y1 = Button22.Margin.Top + Button22.Height / 2;
            ArrowLine22.X2 = Button27.Margin.Left + 5;
            ArrowLine22.Y2 = Button27.Margin.Top + Button27.Height / 2;

            ArrowLine23.X1 = Button23.Margin.Left + Button23.Width;
            ArrowLine23.Y1 = Button23.Margin.Top + Button23.Height / 2;
            ArrowLine23.X2 = Button28.Margin.Left + 5;
            ArrowLine23.Y2 = Button28.Margin.Top + Button28.Height / 2;

            ArrowLine24.X1 = Button24.Margin.Left + Button24.Width;
            ArrowLine24.Y1 = Button24.Margin.Top + Button24.Height / 2;
            ArrowLine24.X2 = Button28.Margin.Left + 5;
            ArrowLine24.Y2 = Button28.Margin.Top + Button28.Height / 2;

            ArrowLine25.X1 = Button25.Margin.Left + Button25.Width;
            ArrowLine25.Y1 = Button25.Margin.Top + Button25.Height / 2;
            ArrowLine25.X2 = Button29.Margin.Left + 5;
            ArrowLine25.Y2 = Button29.Margin.Top + Button29.Height / 2;

            ArrowLine26.X1 = Button26.Margin.Left + Button26.Width;
            ArrowLine26.Y1 = Button26.Margin.Top + Button26.Height / 2;
            ArrowLine26.X2 = Button29.Margin.Left + 5;
            ArrowLine26.Y2 = Button29.Margin.Top + Button29.Height / 2;

            ArrowLine27.X1 = Button27.Margin.Left + Button27.Width;
            ArrowLine27.Y1 = Button27.Margin.Top + Button27.Height / 2;
            ArrowLine27.X2 = Button30.Margin.Left + 5;
            ArrowLine27.Y2 = Button30.Margin.Top + Button30.Height / 2;

            ArrowLine28.X1 = Button28.Margin.Left + Button28.Width;
            ArrowLine28.Y1 = Button28.Margin.Top + Button28.Height / 2;
            ArrowLine28.X2 = Button30.Margin.Left + 5;
            ArrowLine28.Y2 = Button30.Margin.Top + Button30.Height / 2;

            ArrowLine29.X1 = Button29.Margin.Left + Button29.Width - 100;
            ArrowLine29.Y1 = Button29.Margin.Top + Button29.Height / 2;
            ArrowLine29.X2 = Button31.Margin.Left + 5;
            ArrowLine29.Y2 = Button31.Margin.Top + Button31.Height / 2;

            ArrowLine30.X1 = Button30.Margin.Left + Button30.Width - 100;
            ArrowLine30.Y1 = Button30.Margin.Top + Button30.Height / 2;
            ArrowLine30.X2 = Button31.Margin.Left + 5;
            ArrowLine30.Y2 = Button31.Margin.Top + Button31.Height / 2;
        }

        #endregion
    }
}