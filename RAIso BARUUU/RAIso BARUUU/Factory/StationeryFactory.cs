using RAIso_BARUUU.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAIso_BARUUU.Factory
{
    public class StationeryFactory
    {
        public static MsStationery Create(int id, String name, int price)
        {
            MsStationery msStationery = new MsStationery();
            msStationery.StationeryID = id;
            msStationery.StationeryName = name;
            msStationery.StationeryPrice = price;
            return msStationery;
        }
    }
}