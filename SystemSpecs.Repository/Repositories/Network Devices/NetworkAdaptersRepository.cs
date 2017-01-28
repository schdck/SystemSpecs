﻿using System.Management;
using SystemSpecs.Core.Hardware;

namespace SystemSpecs.Infrastructure.Repositories.NetworkDevices
{
    public class NetworkAdaptersRepository : BaseRepository<NetworkAdapter>
    {
        protected override void InitializeEntities()
        {
            var adapterEnumerator = new ManagementObjectSearcher(new SelectQuery("Win32_NetworkAdapter")).Get().GetEnumerator();
            var configurationEnumerator = new ManagementObjectSearcher(new SelectQuery("Win32_NetworkAdapterConfiguration")).Get().GetEnumerator();

            while(adapterEnumerator.MoveNext() && configurationEnumerator.MoveNext())
            {
                _EntityList.Add(new NetworkAdapter(adapterEnumerator.Current, configurationEnumerator.Current));
            }
        }
    }
}