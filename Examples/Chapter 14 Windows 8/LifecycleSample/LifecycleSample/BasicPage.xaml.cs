﻿using System;
using System.Collections.Generic;
using LifecycleSample.Common;
using Windows.Storage;
using Windows.UI.Xaml.Controls;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace LifecycleSample
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class BasicPage : LayoutAwarePage
    {
        public BasicPage()
        {
            InitializeComponent();

            ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;

            if (localSettings.Values["TextBoxValue"] != null)
                MyTextBox.Text = localSettings.Values["TextBoxValue"] as string;
        }

        /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="navigationParameter">The parameter value passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested.
        /// </param>
        /// <param name="pageState">A dictionary of state preserved by this page during an earlier
        /// session.  This will be null the first time a page is visited.</param>
        protected override void LoadState(Object navigationParameter, Dictionary<String, Object> pageState)
        {
            if (pageState != null && pageState.ContainsKey("TextBoxValue"))
            {
                MyTextBox.Text = pageState["TextBoxValue"] as string;
            }
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="pageState">An empty dictionary to be populated with serializable state.</param>
        protected override void SaveState(Dictionary<String, Object> pageState)
        {
            pageState["TextBoxValue"] = MyTextBox.Text;
        }

        private void MyTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;
            localSettings.Values["TextBoxValue"] = MyTextBox.Text;
        }
    }
}