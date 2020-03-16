using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace ParkingLot.Domain.Utils
{
    public static class EnumUtils
    {
        public static string GetDescriptionByCode<TEntity>(int code)
        {
            List<TEntity> listValues = Enum.GetValues(typeof(TEntity)).Cast<TEntity>().ToList();

            FieldInfo fieldInfo = listValues.ElementAt(code).GetType().GetField(listValues.ElementAt(code).ToString());
            DescriptionAttribute[] attributes = fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

            return attributes.ElementAt(0).Description;
        }
    }
}