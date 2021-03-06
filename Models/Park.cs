using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace NationalParks.Models
{
    public class Park
    {


        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("countryCode")]
        public string CountryCode { get; set; }

        [BsonElement("countryName")]
        public string CountryName { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("toponymName")]
        public string ToponymName { get; set; }

        [BsonElement("coordinates")]
        public List<double> Coordinates { get; set; }

        public double Longitude { get; set; }

        public double Latitude { get; set; }

        [BsonConstructor]
        public Park(string id, string countryCode, string countryName, string name, string toponymName, List<double> coordinates )
        {
            Id = id;
            CountryCode = countryCode;
            CountryName = countryName;
            Name = name;
            ToponymName = toponymName;
            Longitude = coordinates[1];
            Latitude = coordinates[0];
            Coordinates = coordinates;
        }

        [BsonConstructor]
        public Park(string countryCode, string countryName, string name, string toponymName, List<double> coordinates )
        {
            CountryCode = countryCode;
            CountryName = countryName;
            Name = name;
            ToponymName = toponymName;
            Longitude = coordinates[1];
            Latitude = coordinates[0];
            Coordinates = coordinates;
        }

    }
}