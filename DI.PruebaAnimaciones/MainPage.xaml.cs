using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace DI.PruebaAnimaciones
{
    /// <summary>
    /// Animacion para cada uno de los 5 botones. ya que tienen colores diferentes. Debe de aparecer justo en la posicion 
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            // miStoryboard.Begin();
            crearAnimacion();

            
        }
        /// <summary>
        /// Metodo unificado para crear animacion
        /// </summary>
        private void crearAnimacion()
        {
            Storyboard str = new Storyboard();
            DoubleAnimation dbAnimationEjeX = new DoubleAnimation();// tamanio x
            DoubleAnimation dbAnimationEjeY = new DoubleAnimation();
            ScaleTransition scale = new ScaleTransfor();
            dbAnimationEjeX.AutoReverse = true;
            dbAnimationEjeX.RepeatBehavior = RepeatBehavior.Forever;
            MiRectangulo.Scale = scale;
            //dbAnimationEjeY.RepeatBehavior = RepeatBehavior.Forever;
            //dbAnimationEjeY.AutoReverse = true;
            dbAnimationEjeX.From = 600;
            dbAnimationEjeX.To = 2000;
            dbAnimationEjeX.Duration = TimeSpan.FromSeconds(5); // tendra que ser una variable que se cambie que se cambie segun la velocidad de la aplicacion
            TranslateTransform movedor = new TranslateTransform();            
            str.Children.Add(dbAnimationEjeX);
            Storyboard.SetTarget(dbAnimationEjeX, scale);           
            Storyboard.SetTargetProperty(str, "ScaleX");
            str.Begin();
            
        }





        //private void animarYConfigurarElementos(Random r, Border borde2, DoubleAnimation dbAnimationEjeX, DoubleAnimation dbAnimationEjeY, Storyboard str)
        //{
        //    dbAnimationEjeX.AutoReverse = true;
        //    dbAnimationEjeX.RepeatBehavior = RepeatBehavior.Forever;
        //    dbAnimationEjeY.AutoReverse = true;
        //    dbAnimationEjeY.To = r.Next(-1000, 1000);
        //    dbAnimationEjeY.RepeatBehavior = RepeatBehavior.Forever;
        //    dbAnimationEjeX.To = r.Next(-1000, 1000);
        //    TranslateTransform moveTransform = new TranslateTransform();
        //    moveTransform.X = r.Next(-1000, 1000);
        //    moveTransform.Y = r.Next(-1000, 1000);
        //    borde2.RenderTransform = moveTransform;
        //    dbAnimationEjeX.Duration = new Duration(TimeSpan.FromSeconds(10));
        //    dbAnimationEjeY.Duration = new Duration(TimeSpan.FromSeconds(10));
        //    str.Children.Add(dbAnimationEjeX);
        //    str.Children.Add(dbAnimationEjeY);
        //    Storyboard.SetTarget(dbAnimationEjeY, moveTransform);
        //    Storyboard.SetTarget(dbAnimationEjeX, moveTransform);
        //    Storyboard.SetTargetProperty(dbAnimationEjeY, "Y");
        //    Storyboard.SetTargetProperty(dbAnimationEjeX, "X");
        //    RelativePanel.SetAlignHorizontalCenterWithPanel(borde2, true);
        //    RelativePanel.SetBelow(borde2, stckMenu);
        //    rltRoot.Children.Add(borde2);
        //    str.Begin();
        //}
    }
}
