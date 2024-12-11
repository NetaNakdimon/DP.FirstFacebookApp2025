using System;
using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace FBAppLogic
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

        static DistanceCalculator()
        {
            // Initialize distances (both directions)
            addDistance(eCity.TelAviv, eCity.Jerusalem, 45);
            addDistance(eCity.TelAviv, eCity.Haifa, 60);
            addDistance(eCity.TelAviv, eCity.Beersheba, 90);
            addDistance(eCity.TelAviv, eCity.Eilat, 240);
            addDistance(eCity.TelAviv, eCity.Netanya, 30);
            addDistance(eCity.TelAviv, eCity.Ashdod, 40);
            addDistance(eCity.Jerusalem, eCity.Haifa, 120);
            addDistance(eCity.Jerusalem, eCity.Beersheba, 90);
            addDistance(eCity.Jerusalem, eCity.Eilat, 220);
            addDistance(eCity.Jerusalem, eCity.Netanya, 50);
            addDistance(eCity.Jerusalem, eCity.Ashdod, 40);
        }

        private static void addDistance(eCity i_city1, eCity i_city2, int distance)
        {
            r_CityDistances[Tuple.Create(i_city1, i_city2)] = distance;
            r_CityDistances[Tuple.Create(i_city2, i_city1)] = distance;
        }

        public static Dictionary<string, int> GetCityStatistics(List<User> i_friends)
        {
            Dictionary<string, int> cityStatistics = new Dictionary<string, int>();

            foreach (User friend in i_friends)
            {
                eCity? friendCity = ConvertToECity(friend.Hometown);

                if (friendCity.HasValue)
                {
                    string cityName = friendCity.Value.ToString();

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

        public static double CalculateAverageDistance(eCity i_UserCity, List<User> i_FriendsList)
        {
            double totalDistance = 0.0;
            int count = 0;

            foreach (User friend in i_FriendsList)
            {
                eCity? friendCity = ConvertToECity(friend.Hometown);

                if (friendCity.HasValue)
                {
                    Tuple<eCity, eCity> cityPair = Tuple.Create(i_UserCity, friendCity.Value);

                    if (r_CityDistances.ContainsKey(cityPair))
                    {
                        totalDistance += r_CityDistances[cityPair];
                        count++;
                    }
                }
            }

            return count > 0 ? totalDistance / count : 0.0;
        }

        public static List<User> GetFriendsWithinDistance(List<User> i_FriendsList, eCity i_UserCity, int i_MaxDistance)
        {
            List<User> closeFriends = new List<User>();

            foreach (User friend in i_FriendsList)
            {
                eCity? friendCity = ConvertToECity(friend.Hometown);

                if (friendCity.HasValue)
                {
                    Tuple<eCity, eCity> cityPair = Tuple.Create(i_UserCity, friendCity.Value);

                    if (r_CityDistances.ContainsKey(cityPair) && r_CityDistances[cityPair] <= i_MaxDistance)
                    {
                        closeFriends.Add(friend);
                    }
                }
            }

            return closeFriends;
        }

        public static string GetCityWithMostFriends(Dictionary<string, int> i_CityStatistics)
        {
            string topCity = null;
            int maxFriends = 0;

            foreach (KeyValuePair<string, int> cityStat in i_CityStatistics)
            {
                if (cityStat.Value > maxFriends)
                {
                    maxFriends = cityStat.Value;
                    topCity = cityStat.Key;
                }
            }

            return topCity != null ? topCity + " with " + maxFriends + " friends" : "No friends found.";
        }

        public static eCity? ConvertToECity(FacebookWrapper.ObjectModel.City i_city)
        {
            if (i_city == null || string.IsNullOrEmpty(i_city.Name))
            {
                return null;
            }

            if (i_city.Name.Equals("Tel Aviv", StringComparison.OrdinalIgnoreCase))
            {
                return eCity.TelAviv;
            }
            if (i_city.Name.Equals("Jerusalem", StringComparison.OrdinalIgnoreCase))
            {
                return eCity.Jerusalem;
            }
            if (i_city.Name.Equals("Haifa", StringComparison.OrdinalIgnoreCase))
            {
                return eCity.Haifa;
            }
            if (i_city.Name.Equals("Beersheba", StringComparison.OrdinalIgnoreCase))
            {
                return eCity.Beersheba;
            }
            if (i_city.Name.Equals("Eilat", StringComparison.OrdinalIgnoreCase))
            {
                return eCity.Eilat;
            }
            if (i_city.Name.Equals("Netanya", StringComparison.OrdinalIgnoreCase))
            {
                return eCity.Netanya;
            }
            if (i_city.Name.Equals("Ashdod", StringComparison.OrdinalIgnoreCase))
            {
                return eCity.Ashdod;
            }

            return null;
        }

        private static bool areCitiesClose(eCity i_UserCity, eCity i_FriendCity)
        {
            Tuple<eCity, eCity> cityPair = Tuple.Create(i_UserCity, i_FriendCity);

            if (r_CityDistances.ContainsKey(cityPair))
            {
                return r_CityDistances[cityPair] <= 30;
            }

            return false;
        }

        public static List<User> GetCloseFriends(List<User> i_FriendsList, eCity i_UserCity)
        {
            List<User> closeFriends = new List<User>();

            foreach (User friend in i_FriendsList)
            {
                eCity? friendCity = ConvertToECity(friend.Hometown);

                if (friendCity.HasValue && areCitiesClose(i_UserCity, friendCity.Value))
                {
                    closeFriends.Add(friend);
                }
            }

            return closeFriends;
        }

        //Mockup Data because no persmission to friends hometowns
        public static Dictionary<string, int> GetSimulatedCityStatistics()
        {
            // Simulate city statistics data
            Dictionary<string, int> simulatedData = new Dictionary<string, int>
    {
        { "Tel Aviv", 5 },
        { "Jerusalem", 3 },
        { "Haifa", 2 },
        { "Eilat", 1 }
    };

            return simulatedData;
        }


        public static double CalculateSimulatedAverageDistance()
        {
            return 70.5; 
        }

    }
}
