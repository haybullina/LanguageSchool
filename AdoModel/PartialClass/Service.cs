using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace LearnLanguageSchool.AdoModel
{
    public partial class Service
    {
        public string DiscountedPrice
        {
            get
            {
                if ((int)Discount > 0)
                    return $"{(int)Cost * (100-(int)Discount) / 100} рублей за {DurationInSeconds / 60} минут";
                else
                    return $"{(int)Cost} рублей за {(int)DurationInSeconds / 60} минут";
            }
        }

        public string DiscountString 
        {
            get 
            {
                if ((int)Discount > 0)
                    return $"* скидка {(int)Discount}%";
                else
                    return $"";
            }
        }

        public string CostStrikethrough
        {
            get
            {
                if ((int)Discount > 0)
                    return $"{(int)Cost} ";
                else
                    return $"";
            }
        }

        public SolidColorBrush ColorBackground 
        {
            get 
            {
                if ((int)Discount > 0)
                    return new SolidColorBrush(Color.FromArgb(255, 231, 250, 191));
                else
                    return new SolidColorBrush(Colors.White);

            }
        }
    }
}
