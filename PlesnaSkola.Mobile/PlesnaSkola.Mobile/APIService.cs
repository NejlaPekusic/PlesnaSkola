using Flurl.Http;
using PlesnaSkola.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PlesnaSkola.Mobile
{
    public class APIService
    {
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static Model.Korisnici PrijavljeniKorisnik { get; set; }

        private string APIUrl;
        private readonly string _route;
        public APIService(string route)
        {
            _route = route;
            APIUrl = getApiURL();
        }

        public string getApiURL()
        {
            int port = 49353;

            string local = $"http://localhost:{port}/api";
            string lan_address = $"http://192.168.0.1:{port}/api";

            if (Device.RuntimePlatform == Device.UWP)
                return local;
            else
                return lan_address;
        }


        public async Task<T> Get<T>(object search, string action = null)
        {
            var url = $"{APIUrl}/{_route}";
            try
            {
                if (action != null)
                {
                    url += "/" + action;
                }

                if (search != null)
                {
                    url += "?";
                    url += await search.ToQueryString();
                }

                return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized)
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "You are not logged in.", "OK");
                }
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Forbidden)
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "You are not authorized", "OK");
                    return default(T);
                }
                throw;
            }
        }

        public async Task<T> GetById<T>(object id, string action = null)
        {
            var url = $"{APIUrl}/{_route}";
            try
            {
                if (action != null)
                {
                    url += $"/{action}";
                }
                url += $"/{id}";
                return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized)
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "You are not logged in.", "OK");
                }
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Forbidden)
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "You are not authorized", "OK");
                    return default(T);
                }
                throw;
            }
        }

        public async Task<T> Insert<T>(object request, string action = null)
        {
            var url = $"{APIUrl}/{ _route}";
            if (action != null)
            {
                url += $"/{action}";
            }
            try
            {
                return await url.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized)
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "You are not logged in.", "OK");
                    throw;
                }
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Forbidden)
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "You are not authorized", "OK");
                    return default(T);
                }

                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine(string.Join(",", error.Value));
                }

                await Application.Current.MainPage.DisplayAlert("Error", stringBuilder.ToString(), "OK");
                return default(T);
            }
            catch (Exception)
            {
                return default(T);

            }

        }

        public async Task<T> Update<T>(int id, object request, string action = null)
        {
            try
            {
                var url = $"{APIUrl}/{ _route}";
                if (action != null)
                {
                    url += $"/{action}";
                }
                url += $"/{id}";

                return await url.WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized)
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "You are not logged in.", "OK");
                    throw;
                }
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Forbidden)
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "You are not authorized", "OK");
                    return default(T);
                }

                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine(string.Join(",", error.Value));
                }

                await Application.Current.MainPage.DisplayAlert("Error", stringBuilder.ToString(), "OK");
                return default(T);
            }

        }
        public async Task<T> Delete<T>(int id)
        {
            var url = $"{APIUrl}/{_route}/{id}";

            try
            {
                return await url.WithBasicAuth(Username, Password).DeleteAsync().ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized)
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "You are not logged in.", "OK");
                }
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Forbidden)
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "You are not authorized", "OK");
                }
                return default(T);
            }
        }

    }
}
