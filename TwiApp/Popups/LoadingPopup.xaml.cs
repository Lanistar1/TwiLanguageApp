﻿using Rg.Plugins.Popup.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TwiApp.Helpers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwiApp.Popups
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoadingPopup : PopupBasePage
    {
        public static bool IsLoading { get; private set; }
        public static bool IsAppearing { get; private set; }

        public LoadingPopup()
        {
            InitializeComponent();
        }

        protected override void OnDisappearing()
        {
            IsLoading = false;
        }

        #region Instance

        private static LoadingPopup _instance;

        public static LoadingPopup Instance => _instance ?? (_instance = new LoadingPopup());

        public async Task Show(string loadingMessage = null, ICommand closeCommand = null,
            object closeCommandParameter = null, ICommand hideCommand = null, object hideCommandParameter = null, bool isHasBottomButton = false)
        {
            IsAppearing = true;

            await DeviceExtension.BeginInvokeOnMainThreadAsync(() =>
            {
                LabelLoadingMessage.Text = !string.IsNullOrWhiteSpace(loadingMessage)
                    ? loadingMessage
                    : "Please wait...";

                BottomButton.IsVisible = isHasBottomButton;

                ClosePopupCommand = closeCommand;
                ClosePopupCommandParameter = closeCommandParameter;

                HidePopupCommand = hideCommand;
                HidePopupCommandParameter = hideCommandParameter;
            });

            if (IsLoading) return;

            IsLoading = true;

            await DeviceExtension.BeginInvokeOnMainThreadAsync(async () =>
            {
                LoadingIndicator.IsRunning = true;
                await Application.Current.MainPage.Navigation.PushPopupAsync(this);
            });

            IsAppearing = false;
        }

        #endregion

        #region StopProcessing

        public async Task Hide()
        {
            // Waiting for Loading Popup start appearing
            await Task.Delay(50);

            if (IsLoading)
            {
                await Task.Delay(200);

                if (IsAppearing)
                {
                    // Wait for Loading Popup finish appearing
                    await Task.Delay(200);
                }

                IsLoading = false;

                if (Rg.Plugins.Popup.Services.PopupNavigation.Instance.PopupStack.Count != 0)
                    await DeviceExtension.BeginInvokeOnMainThreadAsync(async () =>
                    {
                        LoadingIndicator.IsRunning = false;
                        await Navigation.PopPopupAsync();
                    });
            }
        }

        #endregion

        #region ClosePopupCommand

        public static readonly BindableProperty ClosePopupCommandProperty =
            BindableProperty.Create(nameof(ClosePopupCommand),
                typeof(ICommand),
                typeof(PopupBasePage),
                null,
                BindingMode.TwoWay);

        public ICommand ClosePopupCommand
        {
            get => (ICommand)GetValue(ClosePopupCommandProperty);
            set => SetValue(ClosePopupCommandProperty, value);
        }

        public static readonly BindableProperty ClosePopupCommandParameterProperty =
            BindableProperty.Create(nameof(ClosePopupCommandParameter),
                typeof(object),
                typeof(PopupBasePage),
                null,
                BindingMode.TwoWay);

        public object ClosePopupCommandParameter
        {
            get => GetValue(ClosePopupCommandParameterProperty);
            set => SetValue(ClosePopupCommandParameterProperty, value);
        }

        #endregion

        #region CancelLoading

        protected async void ClosePopupEvent(object sender, EventArgs e)
        {
            await Hide();
            ClosePopupCommand?.Execute(ClosePopupCommandParameter);
        }

        #endregion

        #region HidePopupCommand

        public static readonly BindableProperty HidePopupCommandProperty =
            BindableProperty.Create(nameof(HidePopupCommand),
                typeof(ICommand),
                typeof(PopupBasePage),
                null,
                BindingMode.TwoWay);

        public ICommand HidePopupCommand
        {
            get => (ICommand)GetValue(HidePopupCommandProperty);
            set => SetValue(HidePopupCommandProperty, value);
        }

        public static readonly BindableProperty HidePopupCommandParameterProperty =
            BindableProperty.Create(nameof(HidePopupCommandParameter),
                typeof(object),
                typeof(PopupBasePage),
                null,
                BindingMode.TwoWay);

        public object HidePopupCommandParameter
        {
            get => GetValue(HidePopupCommandParameterProperty);
            set => SetValue(HidePopupCommandParameterProperty, value);
        }

        #endregion

        #region HidePopupEvent

        protected async void HidePopupEvent(object sender, EventArgs e)
        {
            await Hide();
            HidePopupCommand?.Execute(HidePopupCommandParameter);
        }

        #endregion

        // Lock hard ware back button
        protected override bool OnBackButtonPressed()
        {
            return true;
        }

        #region RefreshUI

        public void RefreshUI()
        {
            InitializeComponent();
        }

        #endregion
    }

}