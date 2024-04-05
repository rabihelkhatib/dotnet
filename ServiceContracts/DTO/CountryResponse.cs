using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceContracts.DTO
{
    /// <summary>
    /// DTO class that is used as return type for most CountriesService methods
    /// </summary>
    public class CountryResponse
    {
        public string CountryName { get; set; }

        public Guid CountryId { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }
            if(obj.GetType() !=typeof(CountryResponse))
            {
                return false;
            }
            CountryResponse countryResponse = (CountryResponse)obj;

            return CountryId == countryResponse.CountryId && CountryName == countryResponse.CountryName;
        }
    }
    public static class CountryExtensions
    {
        public static CountryResponse ToCountryResponse(this Country country)
        {
            return new CountryResponse { CountryName = country.CountryName, CountryId = country.CountryId };    
        }
    }
}
