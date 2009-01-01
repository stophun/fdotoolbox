using System;
using System.Collections.Generic;
using System.Text;

namespace FdoToolbox.Base.Services
{
    public interface IService
    {
        bool IsInitialized { get; }
        void InitializeService();
        void UnloadService();

        void Load();
        void Save();

        event EventHandler Initialize;
        event EventHandler Unload;
    }
}