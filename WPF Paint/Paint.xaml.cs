using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Paint
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, RoutedEventArgs e)
        {
            this.DrawingCanvas.EditingMode = InkCanvasEditingMode.Ink;

        }

        private void btnErase_Click(object sender, RoutedEventArgs e)
        {
            this.DrawingCanvas.EditingMode = InkCanvasEditingMode.EraseByStroke;
        }

        private void btnSelect_Click(object sender, RoutedEventArgs e)
        {
            this.DrawingCanvas.EditingMode = InkCanvasEditingMode.Select;

        }

        private void SetBrushSize(object sender) 
        {
            string text = ((ComboBox)sender).Text;
            int size = 0;

            if(text != "")
            {
                try
                {
                    size = int.Parse(text);
                } catch (FormatException e)
                {

                }
                BrushAttrib.Width = size;
                BrushAttrib.Height = size;
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SetBrushSize(sender);
        }

        private void cboBrushSize_DropDownClosed(object sender, EventArgs e)
        {
            SetBrushSize(sender);
        }
    }
}
