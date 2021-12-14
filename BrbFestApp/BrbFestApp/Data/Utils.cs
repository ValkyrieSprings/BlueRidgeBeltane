using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using BrbFestApp.Models;
using BrbFestApp.Common;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Xamarin.Essentials;

namespace BrbFestApp.Data
{
    public static class Utils
    {
        public static Task GetRemoteDataAsync()
        {
            return Task.Run(async () => await GetRemoteData());
        }

        private static async Task GetRemoteData()
        {
            await Task.Run(async () => await GetSettingsAsync());
            await Task.Run(async () => await GetItemTypesAsync());
            await Task.Run(async () => await GetPersonsAsync());
            await Task.Run(async () => await GetInfoItemsAsync());
            await Task.Run(async () => await GetScheduleItemsAsync());
            await Task.Run(async () => await GetxScheduleItem_PersonsAsync());
        }

        private static async Task<InfoItems> GetInfoItemsAsync()
        {
            var client = new HttpClient();
            try
            {
                client.DefaultRequestHeaders.Add("User-Agent", "BRB Fest App");

                var httpResponse = await client.GetAsync(new Uri(Constants.GitHost + Constants.DataFiles.InfoItems));
                if (httpResponse.IsSuccessStatusCode)
                {
                    var json = await httpResponse.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<InfoItems>(json);
                    return data;
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            return null;
        }
        
        

        private static async Task<ItemTypes> GetItemTypesAsync()
        {
            var client = new HttpClient();
            try
            {
                client.DefaultRequestHeaders.Add("User-Agent", "BRB Fest App");
                var httpResponse = await client.GetAsync(new Uri(Constants.GitHost + Constants.DataFiles.ItemTypes));
                if (httpResponse.IsSuccessStatusCode)
                {
                    var json = await httpResponse.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<ItemTypes>(json);
                    return data;
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            return null;
        }
        private static async Task<Persons> GetPersonsAsync()
        {
            var client = new HttpClient();
            try
            {
                client.DefaultRequestHeaders.Add("User-Agent", "BRB Fest App");
                var httpResponse = await client.GetAsync(new Uri(Constants.GitHost + Constants.DataFiles.Persons));
                if (httpResponse.IsSuccessStatusCode)
                {
                    var json = await httpResponse.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<Persons>(json);
                    return data;
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            return null;
        }
        private static async Task<ScheduleItems> GetScheduleItemsAsync()
        {
            var client = new HttpClient();
            try
            {
                client.DefaultRequestHeaders.Add("User-Agent", "BRB Fest App");
                var httpResponse = await client.GetAsync(new Uri(Constants.GitHost + Constants.DataFiles.ScheduleItems));
                if (httpResponse.IsSuccessStatusCode)
                {
                    var json = await httpResponse.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<ScheduleItems>(json);
                    return data;
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            return null;
        }
        private static async Task<xScheduleItem_Persons> GetxScheduleItem_PersonsAsync()
        {
            var client = new HttpClient();
            try
            {
                client.DefaultRequestHeaders.Add("User-Agent", "BRB Fest App");
                var httpResponse = await client.GetAsync(new Uri(Constants.GitHost + Constants.DataFiles.xScheduleItem_Persons));
                if (httpResponse.IsSuccessStatusCode)
                {
                    var json = await httpResponse.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<xScheduleItem_Persons>(json);
                    return data;
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            return null;
        }


        private static async Task<List<Setting>> GetSettingsAsync()
        {
            var client = new HttpClient();
            try
            {
                client.DefaultRequestHeaders.Add("User-Agent", "BRB Fest App");

                var httpResponse = await client.GetAsync(new Uri(Constants.GitHost + Constants.DataFiles.Settings));
                if (httpResponse.IsSuccessStatusCode)
                {
                    var json = await httpResponse.Content.ReadAsStringAsync();
                    var data = JObject.Parse(json);
                    foreach (var kp in data)
                    {
                        Preferences.Set(kp.Key, kp.Value.ToString());
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }

            return null;



        }
        
    }
}