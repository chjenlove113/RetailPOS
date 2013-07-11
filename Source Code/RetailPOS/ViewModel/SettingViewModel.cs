﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows;

namespace RetailPOS.ViewModel
{
   public class SettingViewModel : ViewModelBase
   {
       #region Declare Public and Private Data member
       
       private Visibility _isCategoryVisible;
       private Visibility _isCustomerVisible;
       private Visibility _isProductVisible;
       private Visibility _isShopSettingVisible;
       private Visibility _issearchPromotionalOfferVisible;
       private Visibility _issearchPurchaseHistory;
       private Visibility _isWasteManegementVisible;
       #endregion

       #region Public Properties

       public RelayCommand OpenShopSettingCmd { get; private set; }
       public RelayCommand OpenCategorySettingCmd { get; private set; }
       public RelayCommand OpenCustomerCmd { get; private set; }
       public RelayCommand OpenProductWindowCmd { get; private set; }
       public RelayCommand OpenSettingWindowCmd { get; private set; }
       public RelayCommand BackToMainWindow { get; private set; }
       public RelayCommand OpenSearchPromotionalOffer { get; private set; }
       public RelayCommand OpenSearchPurchaseHistory { get; private set; }
       public RelayCommand OpenWasteManegment { get; private set; }

       public Visibility IsCategoryVisible
       {
           get
           {
               return _isCategoryVisible;
           }
           set
           {
               _isCategoryVisible = value;
               RaisePropertyChanged("IsCategoryVisible");
           }
       }

       public Visibility IsCustomerVisible
       {
           get
           {
               return _isCustomerVisible;
           }
           set
           {
               _isCustomerVisible = value;
               RaisePropertyChanged("IsCustomerVisible");
           }
       }

       public Visibility IsProductVisible
       {
           get
           {
               return _isProductVisible;
           }
           set
           {
               _isProductVisible = value;
               RaisePropertyChanged("IsProductVisible");
           }
       }

       public Visibility IsShopSettingVisible
       {
           get
           {
               return _isShopSettingVisible;
           }
           set
           {
               _isShopSettingVisible = value;
               RaisePropertyChanged("IsShopSettingVisible");
           }
       }

       public Visibility IsSearchPromotionalOfferVisible
       {
           get
           {
               return _issearchPromotionalOfferVisible;
           }
           set
           {
               _issearchPromotionalOfferVisible = value;
               RaisePropertyChanged("IsSearchPromotionalOfferVisible");
           }
       }

       public Visibility IsSearchPurchaseHistoryVisible
       {
           get
           {
               return _issearchPurchaseHistory;
           }
           set
           {
               _issearchPurchaseHistory = value;
               RaisePropertyChanged("IsSearchPurchaseHistoryVisible");
           }
       }

       public Visibility IsWastemengmentVisible
       {
           get
           {
               return _isWasteManegementVisible;
           }
           set
           {
               _isWasteManegementVisible = value;
               RaisePropertyChanged("IsWastemengmentVisible");
           }
       }       
       #endregion

       /// <summary>
       /// Initializes a new instance of the <see cref="SettingViewModel"/> class.
       /// </summary>
       public SettingViewModel()
       {
           HideSettings();
           OpenWasteManegment = new RelayCommand(Openwastemanagement);
           OpenSettingWindowCmd = new RelayCommand(OpenSettingWindow);
           OpenShopSettingCmd = new RelayCommand(OpenShopSettingWindow);
           OpenCategorySettingCmd = new RelayCommand(OpenCategoryWindow);
           OpenCustomerCmd = new RelayCommand(OpenCustomerWindow);
           OpenProductWindowCmd = new RelayCommand(OpenProduct);
           OpenSearchPromotionalOffer = new RelayCommand(OpenSearchPromotionalWindow);
           OpenSearchPurchaseHistory = new RelayCommand(OpenSearchPurchasehistory);

           BackToMainWindow = new RelayCommand(OpenMainWindow);
       }

       /// <summary>
       /// Hides the settings.
       /// </summary>
       private void HideSettings()
       {
           IsWastemengmentVisible = Visibility.Collapsed;
           IsSearchPromotionalOfferVisible = Visibility.Collapsed;
           IsProductVisible = Visibility.Collapsed;
           IsShopSettingVisible = Visibility.Collapsed;
           IsCategoryVisible = Visibility.Collapsed;
           IsCustomerVisible = Visibility.Collapsed;
           IsSearchPurchaseHistoryVisible = Visibility.Collapsed;
       }

       /// <summary>
       /// Opens the product.
       private void OpenProduct()
       {
           ////Hide Previous opened settings tab
           HideSettings();

           IsProductVisible = Visibility.Visible;
       }
      
       /// <summary>
       /// Opens the customer window.
       /// </summary>
       private void OpenCustomerWindow()
       {
           ////Hide Previous opened settings tab
           HideSettings();

           IsCustomerVisible = Visibility.Visible;
       }

       /// <summary>
       /// Opens the main window.
       /// </summary>
       private void OpenMainWindow()
       {
           Dashboard MW = new Dashboard();
           MW.Show();
           SettingsWindow.SettingWindow.Close();
       }

       /// <summary>
       /// Checks for setting win close.
       /// </summary>
       private void CheckForSettingWinClose()
       {
       }

       /// <summary>
       /// Opens the category window.
       /// </summary>
       private void OpenCategoryWindow()
       {
           ////Hide Previous opened settings tab
           HideSettings();

           IsCategoryVisible = Visibility.Visible;
       }

       /// <summary>
       /// Opens the shop setting window.
       /// </summary>
       private void OpenShopSettingWindow()
       {
           ////Hide Previous opened settings tab
           HideSettings();

           IsShopSettingVisible = Visibility.Visible;
       }

       /// <summary>
       /// Opens the setting window.
       /// </summary>
       private void OpenSettingWindow()
       {
           SettingsWindow set = new SettingsWindow();
           set.Show();
           Dashboard._Dashboard.Close();
       }

       /// <summary>
       /// Opens the SearchpromotionalOffer window.
       /// </summary>
       private void OpenSearchPromotionalWindow()
       {
           HideSettings();
           IsSearchPromotionalOfferVisible = Visibility.Visible;
       }

       private void OpenSearchPurchasehistory()
       {
           HideSettings();
           IsSearchPurchaseHistoryVisible = Visibility.Visible;
       }

       private void Openwastemanagement()
       {
           HideSettings();
           IsWastemengmentVisible = Visibility.Visible;
       }
    }
}