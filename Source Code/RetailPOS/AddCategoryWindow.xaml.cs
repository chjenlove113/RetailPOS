﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RetailPOS
{
    /// <summary>
    /// Interaction logic for AddCategoryWindow.xaml
    /// </summary>
    public partial class AddCategoryWindow : Window
    {

        /// <summary>
        /// Gets or sets the _ add category window.
        /// </summary>
        /// <value>
        /// The _ add category window.
        /// </value>
        public static AddCategoryWindow _AddCategoryWindow
        {
            get;
            set;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="AddCategoryWindow"/> class.
        /// </summary>
        public AddCategoryWindow()
        {
            _AddCategoryWindow  = this;
            InitializeComponent();
        }
    }
}
