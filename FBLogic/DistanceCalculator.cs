﻿using System;
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

        private static readonly Dictionary<Tuple<eCity, eCity>, int> sr_CityDistances = new Dictionary<Tuple<eCity, eCity>, int>();

        static DistanceCalculator()
        {
            // Initialize distances between cities
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

        private static void addDistance(eCity i_City1, eCity i_City2, int distance)
        {
            // Add distance in both directions for symmetry
            sr_CityDistances[Tuple.Create(i_City1, i_City2)] = distance;
            sr_CityDistances[Tuple.Create(i_City2, i_City1)] = distance;
        }

        public Dictionary<string, int> GetCityStatistics(List<User> i_Friends)
        {
            Dictionary<string, int> cityStatistics = new Dictionary<string, int>();

            foreach (User friend in i_Friends)
            {
                eCity? friendCity = ConvertToECity(friend.Hometown); // Convert friend's hometown to eCity enum

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
                eCity? friendCity = AppManagment.Instance.ConvertToeCity(friend.Hometown); 

                if (friendCity.HasValue)
                {
                    Tuple<eCity, eCity> cityPair = Tuple.Create(i_UserCity, friendCity.Value);

                    if (sr_CityDistances.ContainsKey(cityPair))
                    {
                        totalDistance += sr_CityDistances[cityPair]; 
                        count++;
                    }
                }
            }

            return count > 0 ? totalDistance / count : 0.0; // Return average distance or 0 if no valid data
        }

        public static List<User> GetFriendsWithinDistance(List<User> i_FriendsList, eCity i_UserCity, int i_MaxDistance)
        {
            List<User> closeFriends = new List<User>();

            foreach (User friend in i_FriendsList)
            {
                eCity? friendCity = AppManagment.Instance.ConvertToeCity(friend.Hometown);

                if (friendCity.HasValue)
                {
                    Tuple<eCity, eCity> cityPair = Tuple.Create(i_UserCity, friendCity.Value);

                    if (sr_CityDistances.ContainsKey(cityPair) && sr_CityDistances[cityPair] <= i_MaxDistance)
                    {
                        closeFriends.Add(friend); 
                    }
                }
            }

            return closeFriends;
        }

        public string GetCityWithMostFriends(Dictionary<string, int> i_CityStatistics)
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

        public eCity? ConvertToECity(FacebookWrapper.ObjectModel.City i_City)
        {
            if (i_City == null || string.IsNullOrEmpty(i_City.Name))
            {
                return null;
            }

            // Map city names to eCity enum
            if (i_City.Name.Equals("Tel Aviv", StringComparison.OrdinalIgnoreCase))
            {
                return eCity.TelAviv;
            }
            if (i_City.Name.Equals("Jerusalem", StringComparison.OrdinalIgnoreCase))
            {
                return eCity.Jerusalem;
            }
            if (i_City.Name.Equals("Haifa", StringComparison.OrdinalIgnoreCase))
            {
                return eCity.Haifa;
            }
            if (i_City.Name.Equals("Beersheba", StringComparison.OrdinalIgnoreCase))
            {
                return eCity.Beersheba;
            }
            if (i_City.Name.Equals("Eilat", StringComparison.OrdinalIgnoreCase))
            {
                return eCity.Eilat;
            }
            if (i_City.Name.Equals("Netanya", StringComparison.OrdinalIgnoreCase))
            {
                return eCity.Netanya;
            }
            if (i_City.Name.Equals("Ashdod", StringComparison.OrdinalIgnoreCase))
            {
                return eCity.Ashdod;
            }

            return null; 
        }

        private static bool areCitiesClose(eCity i_UserCity, eCity i_FriendCity)
        {
            Tuple<eCity, eCity> cityPair = Tuple.Create(i_UserCity, i_FriendCity);

            if (sr_CityDistances.ContainsKey(cityPair))
            {
                return sr_CityDistances[cityPair] <= 30; // Consider cities close if distance is <= 30
            }

            return false;
        }

        public List<User> GetCloseFriends(List<User> i_FriendsList, eCity i_UserCity)
        {
            List<User> closeFriends = new List<User>();

            foreach (User friend in i_FriendsList)
            {
                eCity? friendCity = AppManagment.Instance.ConvertToeCity(friend.Hometown);

                if (friendCity.HasValue && areCitiesClose(i_UserCity, friendCity.Value))
                {
                    closeFriends.Add(friend); // Add friend if their city is close
                }
            }

            return closeFriends;
        }

        // Mockup data for simulated statistics
        public Dictionary<string, int> GetSimulatedCityStatistics()
        {
            Dictionary<string, int> simulatedData = new Dictionary<string, int>
            {
                { "Tel Aviv", 5 },
                { "Jerusalem", 3 },
                { "Haifa", 2 },
                { "Eilat", 1 }
            };

            return simulatedData;
        }

        public double CalculateSimulatedAverageDistance()
        {
            return 70.5; 
        }
    }
}