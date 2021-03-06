﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMvc.Infrastructure
{
    public class ApiPaths
    {
        public static class Basket
        {
            public static string GetBasket(string baseUri, string basketId)
            {
                return $"{baseUri}/{basketId}";
            }

            public static string UpdateBasket(string baseUri)
            {
                return baseUri;
            }

            public static string CleanBasket(string baseUri, string basketId)
            {
                return $"{baseUri}/{basketId}";
            }
        }

        public static class Catalog
        {
            public static string GetAllEvents(string baseUri, int page, int take, int? category, int? metroArea)
            {
                var filterQs = String.Empty;

                if (category.HasValue || metroArea.HasValue)
                {
                    var categoryQs = (category.HasValue) ? category.ToString() : "null";
                    var metroAreaQs = (metroArea.HasValue) ? metroArea.ToString() : "null";

                    filterQs = $"/category/{categoryQs}/metroArea/{metroAreaQs}";
                }

                return $"{baseUri}events{filterQs}?pageIndex={page}&pageSize={take}";
            }

            public static string GetAllCategories(string baseUri)
            {
                return $"{baseUri}eventcategories";
            }

            public static string GetAllMetroAreas(string baseUri)
            {
                return $"{baseUri}eventmetroareas";

            }
        }

        public static class Order
        {
            public static string GetOrder(string baseUri, string orderId)
            {
                return $"{baseUri}/{orderId}";
            }

            public static string GetOrders(string baseUri)
            {
                return baseUri;
            }
            public static string AddNewOrder(string baseUri)
            {
                return $"{baseUri}/new";
            }
        }
    }
}
