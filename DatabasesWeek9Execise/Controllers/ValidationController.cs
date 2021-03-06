﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DatabasesWeek9Execise.Data;
using Microsoft.AspNetCore.Mvc;

namespace DatabasesWeek9Execise.Controllers
{
    public class ValidationController : Controller
    {
        private readonly DBContext _context;

        public ValidationController(DBContext context)
        {
            _context = context;
        }

        public bool IsUsernameValid(string username)
        {
            return !_context.Users.Any(x => x.Username == username);
        }

        public bool IsPostNumberValid(int postnr)
        {
            return _context.City.Any(x => x.PostNumber == postnr);
        }

       public async Task<bool> IsAddressValidFromApi(string city, int postnr, int streetNr, string streetName)
       {
            var url = "https://dawa.aws.dk/autocomplete?caretpos=28&fuzzy=&q={0}";
            var address = "q=" + streetName + " " + streetNr + "," + postnr + " " + city;
            var client = new HttpClient();
            var content = new StringContent(url + address, Encoding.UTF8, "application/x-www-form-urlencoded");
            var response = await client.GetAsync(string.Format(url, content));
            var result = response.Content.ReadAsStringAsync();

            return false;
       }
    }
}