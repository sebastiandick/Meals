﻿using AppMeal.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppMeal.ViewModels
{
    public class MainViewModel
    {
        #region Properties
        public List<Meal> ListMeal { get; set; }
        #endregion

        #region Singleton
        private static MainViewModel instance;

        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                instance = new MainViewModel();

            }
            return (instance);
        }
        #endregion

        #region Constructor
        public MainViewModel()
        {

        }
        #endregion

        #region ViewModels
        public MealViewModel contactsViewModel { get; set; }
        #endregion

    }
}
