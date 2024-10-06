using RAIso_BARUUU.Handler;
using RAIso_BARUUU.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;
using System.Web;

namespace RAIso_BARUUU.Controller
{
    public class StationeryController
    {
        public static String Insert(String name, int price)
        {
            if(name == null || price == null)
            {
                return "All field must be filled!";
            }
            if(name.Length < 3 || name.Length > 50)
            {
                return "Name must be between 3 and 50 characters!";
            }
            if (!IsPriceNumeric(price))
            {
                return "Price must be numeric!";
            }
            if(price < 2000)
            {
                return "Price at least needs to be 2000!";
            }
            StationeryHandler.Create(name, price);
            return null;
        }

        public static String Update(int id, String name, int price)
        {
            MsStationery stat = StationeryHandler.getStationerybyId(id);
            if(stat == null)
            {
                return "Stationery not found!";
            }
            if (name == null || price == null)
            {
                return "All field must be filled!";
            }
            if (name.Length < 3 || name.Length > 50)
            {
                return "Name must be between 3 and 50 characters!";
            }
            if (!IsPriceNumeric(price))
            {
                return "Price must be numeric!";
            }
            if (price < 2000)
            {
                return "Price at least needs to be 2000!";
            }
            StationeryHandler.Update(id, name, price);
            return null;
        }

        public static String Delete(int id)
        {
            MsStationery stat = StationeryHandler.getStationerybyId(id);
            if(stat == null)
            {
                return "Stationery not found!";
            }
            StationeryHandler.Delete(id);
            return null;
        }


        public static bool IsPriceNumeric(int price)
        {
            String input = price.ToString();
            String pattern = @"^\d+$"; 

            return Regex.IsMatch(input, pattern);
        }

        public static List<MsStationery> getStationery()
        {
            return StationeryHandler.getStationery();
        }

        public static MsStationery getStatbyName(String name)
        {
            return StationeryHandler.getStatbyName(name);
        }

        public static MsStationery getStatbyId(int id)
        {
            return StationeryHandler.getStationerybyId(id);
        }
    }
}