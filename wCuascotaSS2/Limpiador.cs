using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace wCuascotaSS2
{
    public class Limpiador
    {
        public static void LimpiarTodo(ContentPage page)
        {
            LimpiarControles(page.Content);
        }
        private static void LimpiarControles(Element element)
        {
            switch (element)
            {
                case Entry entry:
                    entry.Text = "";
                    break;
                case Layout<View> layout:
                    foreach (var hijo in layout.Children)
                    {
                        LimpiarControles(hijo);
                    }
                    break;
            }
        }
    }
}
