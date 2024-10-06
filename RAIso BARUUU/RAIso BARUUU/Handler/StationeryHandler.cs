using RAIso_BARUUU.Model;
using RAIso_BARUUU.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Web;

namespace RAIso_BARUUU.Handler
{
    public class StationeryHandler
    {
        public static List<MsStationery> getStationery()
        {
            return StationeryRepository.getStationery();
        }

        public static MsStationery getStationerybyId(int id)
        {
            return StationeryRepository.getStatbyId(id);
        }

        public static MsStationery getStatbyName(String name)
        {
            return StationeryRepository.getStatbyName(name);
        }

        public static void Create(String name, int price)
        {
            StationeryRepository.Create(name, price);
        }

        public static void Update(int id, String name, int price)
        {
            StationeryRepository.Update(id, name, price);
        }

        public static void Delete(int id)
        {
            StationeryRepository.Delete(id);
        }
    }
}