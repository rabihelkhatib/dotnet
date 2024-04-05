using ServiceContracts.DTO;

namespace ServiceContracts
{
    /// <summary>
    /// Represents business logic for manipulating Country entity
    /// </summary>
    public interface ICountriesService
    {

        /// <summary>
        /// Method that adds Country object to a list of countries
        /// </summary>
        /// <param name="request">Country object to be added</param>
        /// <returns>Returns the Country object after adding it (including newly generated country id)</returns>
        CountryResponse AddCountry(CountryAddRequest? request);


        /// <summary>
        /// Returns all countries in the list
        /// </summary>
        /// <returns>All countries from the list as list of CountryResponse</returns>
        List<CountryResponse> GetAllCountries();

        /// <summary>
        /// It returns a country object based on the given country id
        /// </summary>
        /// <param name="countryId"> Country Guid</param>
        /// <returns>Matching country as CountryResponse object</returns>
        CountryResponse? GetCountryById(Guid? countryId);
    }
}
