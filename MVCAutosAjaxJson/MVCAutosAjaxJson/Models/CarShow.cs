//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCAutosAjaxJson.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Web;

    public partial class CarShow
    {
  

        [Required (ErrorMessage ="This Field is Required")]
        public int AutoID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public Nullable<int> YearMade { get; set; }
        public string Color { get; set; }
        [DisplayName("Image")]
        public string ImagePath { get; set; }

        [NotMapped]
        public HttpPostedFileBase ImageUpload { get; set; }

        public CarShow()
        {
            ImagePath = "~/Appfiles/Images/image soon.png";
        }

    }

  

}