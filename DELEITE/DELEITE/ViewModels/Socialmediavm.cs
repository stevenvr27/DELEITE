using DELEITE.APPMODELS;
using DELEITE.Models;
using DELEITE.Views.MenuPage;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DELEITE.ViewModels
{
   public  class Socialmediavm
    {
        public ObservableCollection<SocialMedia> sociales { get; set; }
        public Socialmediavm()
        {
            sociales = new ObservableCollection<SocialMedia>();

            {
                new SocialMedia
                {

                    Image = "insta.ico",

                };

                new SocialMedia
                {
                    Image = "insta.ico", 
                };

            
            };
        }





    }
}