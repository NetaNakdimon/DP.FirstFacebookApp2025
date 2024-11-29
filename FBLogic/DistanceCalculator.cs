using System;
using System.Collections.Generic;
using Facebook;
using FacebookWrapper.ObjectModel;
namespace FBLogic
{
    public class DistanceCalculator
    {
        public enum eCity
        {
            TelAviv,
            Jerusalem,
            Haifa,
            Beersheba,
            Eilat,
            Netanya,
            Ashdod
        }

        private static readonly Dictionary<Tuple<eCity, eCity>, int> r_CityDistances = new Dictionary<Tuple<eCity, eCity>, int>();

        public static eCity? ConvertToECity(FacebookWrapper.ObjectModel.City i_city)
        {
            if (i_city == null || string.IsNullOrEmpty(i_city.Name))
            {
                return null;
            }

            switch (i_city.Name)
            {
                case "Tel Aviv":
                    return eCity.TelAviv;
                case "Jerusalem":
                    return eCity.Jerusalem;
                case "Haifa":
                    return eCity.Haifa;
                case "Netanya":
                    return eCity.Netanya;
                case "Eilat":
                    return eCity.Eilat;
                default:
                    return null; 
            }
        }

        public static Dictionary<string, int> GetCityStatistics(List<User> i_friends)
        {
            Dictionary<string, int> cityStatistics = new Dictionary<string, int>();

            foreach (User friend in i_friends)
            { 
                eCity? friendCity = ConvertToECity(friend.Hometown);

                if (friendCity != null)
                {
                    string cityName = friendCity.ToString();

                    if (cityStatistics.ContainsKey(cityName))
                    {
                        cityStatistics[cityName]++;
                    }

                    else
                    {
                        cityStatistics[cityName] = 1;
                    }
                }
            }

            return cityStatistics;
        }

        static DistanceCalculator()
        {
            r_CityDistances.Add(Tuple.Create(eCity.TelAviv, eCity.Jerusalem), 45);
            r_CityDistances.Add(Tuple.Create(eCity.TelAviv, eCity.Haifa), 60);
            r_CityDistances.Add(Tuple.Create(eCity.TelAviv, eCity.Beersheba), 90);
            r_CityDistances.Add(Tuple.Create(eCity.TelAviv, eCity.Eilat), 240);
            r_CityDistances.Add(Tuple.Create(eCity.TelAviv, eCity.Netanya), 30);
            r_CityDistances.Add(Tuple.Create(eCity.TelAviv, eCity.Ashdod), 40);
            r_CityDistances.Add(Tuple.Create(eCity.Jerusalem, eCity.Haifa), 120);
            r_CityDistances.Add(Tuple.Create(eCity.Jerusalem, eCity.Beersheba), 90);
            r_CityDistances.Add(Tuple.Create(eCity.Jerusalem, eCity.Eilat), 220);
            r_CityDistances.Add(Tuple.Create(eCity.Jerusalem, eCity.Netanya), 50);
            r_CityDistances.Add(Tuple.Create(eCity.Jerusalem, eCity.Ashdod), 40);
        }

        // Method to check if two cities are "close" (30 minutes drive)
        public static bool AreCitiesClose(eCity i_UserCity, eCity i_FriendCity)
        {
            Tuple<eCity, eCity> cityPair = Tuple.Create(i_UserCity, i_FriendCity);

            if (r_CityDistances.ContainsKey(cityPair))
            {
                return r_CityDistances[cityPair] <= 30;
            }

            cityPair = Tuple.Create(i_FriendCity, i_UserCity);

            if (r_CityDistances.ContainsKey(cityPair))
            {
                return r_CityDistances[cityPair] <= 30;
            }

            return false;
        }

        public static List<User> GetCloseFriends(List<User> i_FriendsList, eCity i_UserCity)
        {
            List<User> closeFriends = new List<User>();

            for (int i = 0; i < i_FriendsList.Count; i++)
            {
                User friend = i_FriendsList[i];
                eCity? friendCity = ConvertToECity(friend.Hometown);

                if (friendCity.HasValue && AreCitiesClose(i_UserCity, friendCity.Value))
                {
                    closeFriends.Add(friend);
                }
            }

            return closeFriends;
        }
    }
}
