using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XamarinDeviceCharacterisation
{
	public class App : Application
	{
        public App()
        {
            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Spacing = 0,
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.Center,
                    Children = 
                    {
                        new StackLayout
                        {
                            Spacing = 0,
                            Orientation = StackOrientation.Horizontal,
                            Children = {
						        new Label {
							        Text = "Device Unique ID: ",
                                    FontAttributes = FontAttributes.Bold
						        },
                                new Label {
                                    Text = XamarinDeviceCharacterisation.Device.Default.UniqueId
                                }
					        }
                        },
                        new StackLayout
                        {
                            Spacing = 0,
                            Orientation = StackOrientation.Horizontal,
                            Children = {
						        new Label {
							        Text = "Serial Number: ",
                                    FontAttributes = FontAttributes.Bold
						        },
                                new Label {
                                    Text = XamarinDeviceCharacterisation.Device.Default.SerialNumber
                                }
					        }
                        },
                        new StackLayout
                        {
                            Spacing = 0,
                            Orientation = StackOrientation.Horizontal,
                            Children = {
						        new Label {
							        Text = "Device Name: ",
                                    FontAttributes = FontAttributes.Bold
						        },
                                new Label {
                                    Text = XamarinDeviceCharacterisation.Device.Default.Name
                                }
					        }
                        },
                        new StackLayout
                        {
                            Spacing = 0,
                            Orientation = StackOrientation.Horizontal,
                            Children = {
						        new Label {
							        Text = "Model: ",
                                    FontAttributes = FontAttributes.Bold
						        },
                                new Label {
                                    Text = XamarinDeviceCharacterisation.Device.Default.Model
                                }
					        }
                        },
                        new StackLayout
                        {
                            Spacing = 0,
                            Orientation = StackOrientation.Horizontal,
                            Children = {
						        new Label {
							        Text = "OS: ",
                                    FontAttributes = FontAttributes.Bold
						        },
                                new Label {
                                    Text = XamarinDeviceCharacterisation.Device.Default.OS
                                }
					        }
                        },
                        new StackLayout
                        {
                            Spacing = 0,
                            Orientation = StackOrientation.Horizontal,
                            Children = {
						        new Label {
							        Text = "OS Version: ",
                                    FontAttributes = FontAttributes.Bold
						        },
                                new Label {
                                    Text = XamarinDeviceCharacterisation.Device.Default.OSVersion
                                }
					        }
                        },
                        new StackLayout
                        {
                            Spacing = 0,
                            Orientation = StackOrientation.Horizontal,
                            Children = {
						        new Label {
							        Text = "SSID: ",
                                    FontAttributes = FontAttributes.Bold
						        },
                                new Label {
                                    Text = XamarinDeviceCharacterisation.Device.Default.SSID
                                }
					        }
                        },
                        new StackLayout
                        {
                            Spacing = 0,
                            Orientation = StackOrientation.Horizontal,
                            Children = {
						        new Label {
							        Text = "BSSID: ",
                                    FontAttributes = FontAttributes.Bold
						        },
                                new Label {
                                    Text = XamarinDeviceCharacterisation.Device.Default.BSSID
                                }
					        }
                        },
                        new StackLayout
                        {
                            Spacing = 0,
                            Orientation = StackOrientation.Horizontal,
                            Children = {
						        new Label {
							        Text = "MAC Address: ",
                                    FontAttributes = FontAttributes.Bold
						        },
                                new Label {
                                    Text = XamarinDeviceCharacterisation.Device.Default.BluetoothMacAddress
                                }
					        }
                        }

                    }
                }
            };
        }


		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
