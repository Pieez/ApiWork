using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Entites;

namespace WebApplication1.Models
{
    public class PicturesModels
    {

        public PicturesModels(Pictures pictures)
        {
            Id = pictures.Id;

            FileName = pictures.FileName;

            Tittle = pictures.Title;

            
            
        }

        public int Id {get; set; }
        public string FileName {get; set; }

        public string Tittle { get; set; }

        public string ImagesData { get; set; }

    }
    

}