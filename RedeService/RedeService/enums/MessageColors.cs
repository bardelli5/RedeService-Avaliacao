using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedeService.Enums
{
    public enum MessageColors
    {
        SUCCESS,
        ERROR
    }

    public static class MessageColorsExtension
    {
        public static Color GetColor(this MessageColors messageColors)
        {
            if (messageColors.Equals(MessageColors.SUCCESS)) 
                return Color.ForestGreen;
            else 
                return Color.Red;
        }
    }
}
