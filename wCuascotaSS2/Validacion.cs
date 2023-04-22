using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace wCuascotaSS2
{
    public class Validacion
    {
        public static bool ValidacionNumerica(string input)
        {
            try
            {
                double value = double.Parse(input);

                if (value < 0.1 || value > 10)
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }

            return true;
        }
    }
}
