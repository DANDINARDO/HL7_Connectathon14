using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HL7_CDASH_Web.Models
{
    public class VitalSignsViewModels
    {
        [Display(Name = "SubjectID")]
        public string SUBJECTID { get; set; }

        [Display(Name = "Vital Signs Collected?")]
        public string VSPERF { get; set; }

        [Display(Name = "DateTime/SDTN")]
        public string VSDTC { get; set; }

        [Display(Name = "Date Collected")]
        public string VSDAT { get; set; }

        [Display(Name = "Time Collected")]
        public string VSTIM { get; set; }

        [Display(Name = "Sponsor ID")]
        public string VSSPID { get; set; }

        [Display(Name = "Result")]
        public string VSORRES { get; set; }

        [Display(Name = "Units")]
        public string VSORRESU { get; set; }

        [Display(Name = "Clinically Significant")]
        public string VSCLSIG { get; set; }

        [Display(Name = "Location")]
        public string VSLOC { get; set; }

        [Display(Name = "Position")]
        public string VSPOS { get; set; }

        [Display(Name = "Test Name")]
        public string VSTEST { get; set; }

        [Display(Name = "Test Code")]
        public string VSTESTCD { get; set; }

        [Display(Name = "Planned Time Point")]
        public string VSTPT { get; set; }

        public string Results { get; set; }
    }
}