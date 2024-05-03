﻿using System.ComponentModel;
using System.Reflection;

namespace VehicleBookingRentalApp.Services.Utils
{
    public static class GetReflistDescription
    {
        public static string GetEnumDescription<T>(this T value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());
            if (fi != null)
            {
                DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
                if (attributes.Length > 0)
                {
                    return attributes[0].Description;
                }
                else
                {
                    return value.ToString();
                }
            }
            return value.ToString();
        }
    }
}