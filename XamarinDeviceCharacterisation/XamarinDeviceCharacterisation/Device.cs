using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinDeviceCharacterisation
{
    public class Device
    {
        private static Device _Default;
        public static Device Default
        {
            get { return _Default ?? (_Default = new Device()); }
        }

        public string UniqueId
        {
            get { return GetUniqueId(); }
        }

        public string SerialNumber
        {
            get { return GetSerialNumber(); }
        }

        public string Name
        {
            get { return GetName(); }
        }

        public string Model
        {
            get { return GetModel(); }
        }
        
        public string OS
        {
            get { return GetOS(); }
        }

        public string OSVersion
        {
            get { return GetOSVersion(); }
        }

        public string SSID
        {
            get { return GetSSID(); }
        }
       
        public string BSSID
        {
            get { return GetBSSID(); }
        }
        
        public string BluetoothMacAddress
        {
            get { return GetBluetoothMacAddress(); }
        }


        private string GetUniqueId()
        {
            var id = default(string);
#if __IOS__
            id = UIKit.UIDevice.CurrentDevice.IdentifierForVendor.AsString();
#elif __ANDROID__
            id = Android.OS.Build.Serial;
#endif
            return id;
        }
        
        private string GetSerialNumber()
        {
            var serial = "failed!";
#if __IOS__
            serial = "Unavailable for iOS";   // TODO
#elif __ANDROID__
            serial = Android.OS.Build.Serial;
#endif
            return serial;
        }

        private string GetName()
        {
            var name = "failed!";
#if __IOS__
            name = UIKit.UIDevice.CurrentDevice.Name;
#elif __ANDROID__

            Android.Bluetooth.BluetoothAdapter adapter = Android.Bluetooth.BluetoothAdapter.DefaultAdapter;

            if (adapter != null)
            {
                name = string.IsNullOrEmpty(adapter.Name) ? "Unknown" : adapter.Name;
            }
#endif
            return name;
        }

        private string GetModel()
        {
            var model = "failed!";
#if __IOS__
            model = UIKit.UIDevice.CurrentDevice.Model;
#elif __ANDROID__
            model = GetAndroidModel();
#endif
            return model;
        }

#if __ANDROID__
        private string GetAndroidModel()
        {
            return string.IsNullOrEmpty(global::Android.OS.Build.Model) ?
                string.Empty :
                global::Android.OS.Build.Model.StartsWith(global::Android.OS.Build.Manufacturer) ?
                global::Android.OS.Build.Model :
                string.Format("{0} {1}", global::Android.OS.Build.Manufacturer, global::Android.OS.Build.Model);
        }
#endif

        private string GetOS()
        {
            var os = "failed!";
#if __IOS__
            os = UIKit.UIDevice.CurrentDevice.SystemName;
#elif __ANDROID__
            os = "Android";
#endif
            return os;
        }

        private string GetOSVersion()
        {
            var osVersion = "failed!";
#if __IOS__
            osVersion = UIKit.UIDevice.CurrentDevice.SystemVersion;
#elif __ANDROID__
            osVersion = Android.OS.Build.VERSION.Release;
#endif
            return osVersion;
        }

        public string GetSSID()
        {
            var ssid = "failed!";
#if __IOS__
            ssid = "Unavailable for iOS";
#elif __ANDROID__
            ssid = "TODO!";
            // TODO
            //WifiManager mainWifiObj;
            //mainWifiObj = (WifiManager)_this.GetSystemService(Android.Content.Context.WifiService);

            //if (mainWifiObj.ConnectionInfo.HiddenSSID == false)
            //{
            //    ssid = mainWifiObj.ConnectionInfo.ssid;
            //}
#endif
            return ssid;
        }

        private string GetBSSID()
        {
            var bssid = "failed!";
#if __IOS__
            bssid = "Unavailable for iOS";
#elif __ANDROID__
            bssid = "TODO!";
            // TODO
            //WifiManager mainWifiObj;
            //mainWifiObj = (WifiManager)_this.GetSystemService(Android.Content.Context.WifiService);
            
            //if (mainWifiObj.ConnectionInfo.bssid != null)
            //{
            //    mstr_BSSID = mainWifiObj.ConnectionInfo.bssid;
            //}
#endif
            return bssid;
        }

        private string GetBluetoothMacAddress()
        {
            var macAddress = "failed!";
#if __IOS__
            macAddress = "Unavailable for iOS";
#elif __ANDROID__
            Android.Bluetooth.BluetoothAdapter adapter = Android.Bluetooth.BluetoothAdapter.DefaultAdapter;

            if (adapter != null)
            {
                macAddress = string.IsNullOrEmpty(adapter.Address) ? "Unknown" : adapter.Address;
            }
#endif
            return macAddress;
        }
    }
}
