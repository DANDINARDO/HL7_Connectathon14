using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HL7_CDASH_Web.Models
{
    public class ConcomitantMedicationsViewModels
    {
        public string SUBJECTID { get; set; }

        [Display(Name= "Any meds?")]
        public string CMYN { get; set; }

        [Display(Name = "line number or CM number")]
        public string CMSPID { get; set; }

        [Display(Name = "Medication or Therapy")]
        public string CMTRT { get; set; }

        [Display(Name= "Specific medication/treatment")]
        public string CMOCCUR { get; set; }

        [Display(Name = "Medication Ingredients.")]
        public string CMINGRD { get; set; }

        [Display(Name = "Indication")]
        public string CMINDC { get; set; }

        [Display(Name = "AE ID")]
        public string CMAENO { get; set; }

        [Display(Name = "MH ID")]
        public string CMMHNO { get; set; }

        [Display(Name = "Dose")]
        public string CMDOSTXT { get; set; }

        [Display(Name = "Dose Unit")]
        public string CMDOSE { get; set; }

        [Display(Name = "Total Daily Dose")]
        public string CMDOSTOT { get; set; }

        [Display(Name = "Dose Unit")]
        public string CMDOSU { get; set; }
   
        public string CMDOSFRM { get; set; }
    
        public string CMROUTE { get; set; }
   
        public string CMSTDTC { get; set; }
        
        public string CMSTDAT { get; set; }

        public string CMSTTIM { get; set; }

        public string CMPRIOR { get; set; }

        public string CMENDTC { get; set; }

        public string CMENDAT { get; set; }

        public string CMENTIM { get; set; }

        public string CMONGO { get; set; }

        public string CMDOSFRQ { get; set; }

        public string Results { get; set; }
    }
}