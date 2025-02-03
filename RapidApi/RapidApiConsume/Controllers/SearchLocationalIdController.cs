using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Newtonsoft.Json;
using RapidApiConsume.Models;
using static RapidApiConsume.Models.BookingApiLocationsSearchViewModel;

namespace RapidApiConsume.Controllers
{
    public class SearchLocationalIdController : Controller
    {
        public async Task<IActionResult> Index(string CityName)
        {

            if (!string.IsNullOrEmpty(CityName))
            {
                List<BookingApiLocationsSearchViewModel> model = new List<BookingApiLocationsSearchViewModel>();
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/hotels/locations?name={CityName}"),
                    Headers =
                    {
                        { "X-RapidAPI-Key", "58f424e036mshe10d405d0e042d0p1e7aeejsn6ba01aa62488" },
                        { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
                    },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    model = JsonConvert.DeserializeObject<List<BookingApiLocationsSearchViewModel>>(body);
                    return View(model.Take(1).ToList());
                }
            }
            else
            {
                List<BookingApiLocationsSearchViewModel> model = new List<BookingApiLocationsSearchViewModel>();
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://booking-com15.p.rapidapi.com/api/v1/hotels/searchDestination?query=Paris"),
                    Headers =
                    {
                        { "x-rapidapi-key", "58f424e036mshe10d405d0e042d0p1e7aeejsn6ba01aa62488" },
                        { "x-rapidapi-host", "booking-com15.p.rapidapi.com" },
                    },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    model = JsonConvert.DeserializeObject<List<BookingApiLocationsSearchViewModel>>(body);
                    return View(model.Take(1).ToList());
                }
            }
        }
    }
    }

