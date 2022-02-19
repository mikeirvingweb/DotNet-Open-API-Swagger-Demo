using System;

namespace DotNetNorthDemoAPI
{
    /// <summary>
    /// a Dot Net North Meetup
    /// </summary>
    public class Meetup
    {
        /// <summary>
        /// Date and Time of the Meetup
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Title of the talk / presentation
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// A long description of the talk and speaker
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// Refreshments on offer - food
        /// </summary>
        public string Food { get; set; }

        /// <summary>
        /// Refreshments on offer - drinks
        /// </summary>
        public string Beverages { get; set; }

        /// <summary>
        /// I'm only coming if there's prizes
        /// </summary>
        public string Swag { get; set; }
    }

    /// <summary>
    /// Please tell us what you can offer to keep our audience fed and watered.
    /// </summary>
    public class Sustenance
    {
        /// <summary>
        /// What food can you supply (is it pizza?)
        /// </summary>
        public string Food { get; set; }

        /// <summary>
        /// Beverages you can supply. The more the merrier. Alcoholic, and Alcohol Free.
        /// </summary>
        public string Beverages { get; set; }
    }
}
