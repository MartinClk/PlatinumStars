using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace PlaneBuyingSystem.Common
{
    public static class EntityValidationConstants
    {
        public static class Category 
        {
            public const int NameMinLenght = 2;
            public const int NameMaxLenght = 50;
        }

        public static class Plane 
        {
            public const int TitleMinLenght = 10;
            public const int TitleMaxLenght = 50;


            public const int AddressMinLenght = 5;
            public const int AddressMaxLenght = 30;

            public const int DescriptionMinLenght = 30;
            public const int DescriptionMaxLenght = 200;

            public const int ImageUrlMaxLenght = 2048;

            public const string PriceMinValue = "0";
            public const string PriceMaxValue = "100000000";
        }

        public static class agent
        {
            public const int PhoneNumberMinLenght = 7;
            public const int PhoneNumberMaxLenght = 15;
        }
    }
}
