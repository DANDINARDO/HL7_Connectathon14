using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace HL7_CDASH_Web.Models
{
    public class DemographyViewModels
    {
        public static List<SelectListItem> GetSexOptions = new List<SelectListItem>()
        {
            new SelectListItem() {Text = "Male", Value = "M"},
            new SelectListItem() {Text = "Female", Value = "F"}
        };

        public static List<SelectListItem> GetMonth = new List<SelectListItem>()
        {
            new SelectListItem() {Text = "Jan", Value = "1"},
            new SelectListItem() {Text = "Feb", Value = "2"},
            new SelectListItem() {Text = "Mar", Value = "3"},
            new SelectListItem() {Text = "Apr", Value = "4"},
            new SelectListItem() {Text = "May", Value = "5"},
            new SelectListItem() {Text = "Jun", Value = "6"},
            new SelectListItem() {Text = "Jul", Value = "7"},
            new SelectListItem() {Text = "Aug", Value = "8"},
            new SelectListItem() {Text = "Sep", Value = "9"},
            new SelectListItem() {Text = "Oct", Value = "10"},
            new SelectListItem() {Text = "Nov", Value = "11"},
            new SelectListItem() {Text = "Dec", Value = "12"}
        };

        public static List<SelectListItem> GetAgeUnits = new List<SelectListItem>()
        {
            new SelectListItem() {Text = "Days", Value = "MU.DAYS_2011-10-24"},
            new SelectListItem() {Text = "Hours", Value = "MU.HOURS_2011-10-24"},
            new SelectListItem() {Text = "Months", Value = "MU.MONTHS_2011-10-24"},
            new SelectListItem() {Text = "Days", Value = "MU.DAYS_2011-10-24"},
            new SelectListItem() {Text = "Years", Value = "MU.YEARS_2011-10-24"}
        };

        public static List<SelectListItem> GetEthnicity = new List<SelectListItem>()
        {
            new SelectListItem() {Text = "American Indian or Alaska Native", Value = "RACE.AMERICAN_INDIAN_OR_ALASKA_NATIVE"},
            new SelectListItem() {Text = "Asian", Value = "RACE.ASIAN"},
            new SelectListItem() {Text = "Black or African American", Value = "RACE.BLACK_OR_ AFRICAN_AMERICAN"},
            new SelectListItem() {Text = "Native Hawaiian or Other Pacific Islander", Value = "RACE.NATIVE_HAWAIIAN_OR_OTHER_PACIFIC_ISLANDER"},
            new SelectListItem() {Text = "White", Value = "RACE.WHITE"},
            new SelectListItem() {Text = "Specify Other", Value = "RACEOTH"}
        };

        [Display(Name = "Birth Date")]
        public string BRTHDAT { get; set; }

        [Display(Name = "Birth Year")]
        public string BRTHYR { get; set; }

        [Display(Name="Birth Month")]
        public string BRTHMO { get; set; }

        [Display(Name = "Birth Day")]
        public string BRTHDY { get; set; }
        
        [Display(Name="Birth Time")]
        public string BRTHTIM { get; set; }

        public string AGE { get; set; }

        [Display(Name = "Age Units")]
        public string AGEU { get; set; }

        [Display(Name = "Collection Date")]
        public string DMDAT { get; set; }
               
        public string SEX { get; set; }

        [Display(Name = "Ethnicity")]
        public string ETHNIC { get; set; }
        
        public string RACEOTH { get; set; }

        public string Results { get; set; }
    }
}