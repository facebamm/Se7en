﻿using Se7en.OpenCl.Api.Enum;
using Se7en.OpenCl.Api.Native;
using Se7en.Utils;
using System;
using System.Runtime.InteropServices;
namespace Se7en.OpenCl
{  
    
#pragma warning disable CS1570 // XML comment has badly formed XML -- 'The character(s) '$' cannot be used at this location.'
#pragma warning disable CS1570 // XML comment has badly formed XML -- 'The character(s) ']' cannot be used at this location.'
#pragma warning disable CS1570 // XML comment has badly formed XML -- 'The character(s) ']' cannot be used at this location.'
#pragma warning disable CS1570 // XML comment has badly formed XML -- 'An identifier was expected.'
#pragma warning disable CS1570 // XML comment has badly formed XML -- 'An identifier was expected.'
#pragma warning disable CS1570 // XML comment has badly formed XML -- 'The character(s) '$' cannot be used at this location.'
#pragma warning disable CS1570 // XML comment has badly formed XML -- 'The character(s) '(' cannot be used at this location.'
#pragma warning disable CS1570 // XML comment has badly formed XML -- 'The character(s) '(' cannot be used at this location.'
#pragma warning disable CS1570 // XML comment has badly formed XML -- 'An identifier was expected.'
#pragma warning disable CS1570 // XML comment has badly formed XML -- 'An identifier was expected.'
#pragma warning disable CS1570 // XML comment has badly formed XML -- 'An identifier was expected.'
#pragma warning disable CS1570 // XML comment has badly formed XML -- 'The character(s) ']' cannot be used at this location.'
#pragma warning disable CS1570 // XML comment has badly formed XML -- 'An identifier was expected.'
#pragma warning disable CS1570 // XML comment has badly formed XML -- 'An identifier was expected.'
#pragma warning disable CS1570 // XML comment has badly formed XML -- 'The character(s) ']' cannot be used at this location.'
#pragma warning disable CS1570 // XML comment has badly formed XML -- 'An identifier was expected.'
///=>[^<]+([^>]+)[^<]+([^>]+)>\(([^,]+), out _\)\[0\];
    ///Utils.GetTInfo<$1, $2>(_handle, $3, _getInfoHandler, out _).First();
    ///=>[^<]+<([^>]+)[^<]+<([^>]+)>\(([^,]+), out _\)\.ToStrg\(\);
    ///=> Utils.GetTInfo<$1, $2>(_handle, $3, _getInfoHandler, out _).ToStrg();
    ///((IHandleObjInfo<DeviceInfo>)this).GetTInfo<uint>(DeviceInfo.PreferredLocalAtomicAlignment, out _)[0];
#pragma warning disable CS1570 // XML comment has badly formed XML -- 'Expected an end tag for element 'DeviceInfo'.'
#pragma warning disable CS1570 // XML comment has badly formed XML -- 'Expected an end tag for element ''.'
#pragma warning disable CS1570 // XML comment has badly formed XML -- 'Expected an end tag for element 'uint'.'
    [StructLayout(LayoutKind.Sequential)]
#pragma warning restore CS1570 // XML comment has badly formed XML -- 'An identifier was expected.'
#pragma warning restore CS1570 // XML comment has badly formed XML -- 'Expected an end tag for element 'DeviceInfo'.'
#pragma warning restore CS1570 // XML comment has badly formed XML -- 'The character(s) ']' cannot be used at this location.'
#pragma warning restore CS1570 // XML comment has badly formed XML -- 'An identifier was expected.'
#pragma warning restore CS1570 // XML comment has badly formed XML -- 'An identifier was expected.'
#pragma warning restore CS1570 // XML comment has badly formed XML -- 'Expected an end tag for element ''.'
#pragma warning restore CS1570 // XML comment has badly formed XML -- 'The character(s) ']' cannot be used at this location.'
#pragma warning restore CS1570 // XML comment has badly formed XML -- 'An identifier was expected.'
#pragma warning restore CS1570 // XML comment has badly formed XML -- 'An identifier was expected.'
#pragma warning restore CS1570 // XML comment has badly formed XML -- 'An identifier was expected.'
#pragma warning restore CS1570 // XML comment has badly formed XML -- 'The character(s) '(' cannot be used at this location.'
#pragma warning restore CS1570 // XML comment has badly formed XML -- 'The character(s) '(' cannot be used at this location.'
#pragma warning restore CS1570 // XML comment has badly formed XML -- 'The character(s) '$' cannot be used at this location.'
#pragma warning restore CS1570 // XML comment has badly formed XML -- 'An identifier was expected.'
#pragma warning restore CS1570 // XML comment has badly formed XML -- 'Expected an end tag for element 'uint'.'
#pragma warning restore CS1570 // XML comment has badly formed XML -- 'An identifier was expected.'
#pragma warning restore CS1570 // XML comment has badly formed XML -- 'The character(s) ']' cannot be used at this location.'
#pragma warning restore CS1570 // XML comment has badly formed XML -- 'The character(s) ']' cannot be used at this location.'
#pragma warning restore CS1570 // XML comment has badly formed XML -- 'The character(s) '$' cannot be used at this location.'
    public unsafe readonly struct Platform
    {
        public readonly IntPtr Handle;
        internal Platform(IntPtr handle)
            => Handle = handle;
        public string GetProfile()
           => Utils.GetTInfo<PlatformInfo, byte>(Handle, PlatformInfo.Profile, Cl.GetPlatformInfo, out _).ToStrg();
        public string GetVersion()
           => Utils.GetTInfo<PlatformInfo, byte>(Handle, PlatformInfo.Version, Cl.GetPlatformInfo, out _).ToStrg();
        public string GetName()
           => Utils.GetTInfo<PlatformInfo, byte>(Handle, PlatformInfo.Name, Cl.GetPlatformInfo, out _).ToStrg();
        public string GetVendor()
           => Utils.GetTInfo<PlatformInfo, byte>(Handle, PlatformInfo.Vendor, Cl.GetPlatformInfo, out _).ToStrg();
        public string GetExtensions()
           => Utils.GetTInfo<PlatformInfo, byte>(Handle, PlatformInfo.Extensions, Cl.GetPlatformInfo, out _).ToStrg();
        public ulong GetHosttimerresolution()
           => Utils.GetTInfo<PlatformInfo, ulong>(Handle, PlatformInfo.Vendor, Cl.GetPlatformInfo);

        public Device[] GetDevices(DeviceType type = DeviceType.All)
        {
            Cl.GetDeviceIDs(Handle, type, 0, null, out uint deviceCount);
            Device[] devices = new Device[deviceCount];
            Cl.GetDeviceIDs(Handle, type, deviceCount, devices, out _);
            return devices;
        }

        public static implicit operator IntPtr(Platform platform) => platform.Handle;

    }
}