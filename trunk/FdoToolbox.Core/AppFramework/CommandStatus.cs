using System;
using System.Collections.Generic;
using System.Text;

namespace FdoToolbox.Core.AppFramework
{
    /// <summary>
    /// Status codes that can be returned by any console application
    /// </summary>
    public enum CommandStatus : int
    {
        E_OK = 0,
        E_FAIL_SDF_CREATE = 1,
        E_FAIL_APPLY_SCHEMA = 2,
        E_FAIL_DESTROY_DATASTORE = 3,
        E_FAIL_CONNECT = 4,
        E_FAIL_SERIALIZE_SCHEMA_XML = 5,
        E_FAIL_CREATE_DATASTORE = 6,
        E_FAIL_BULK_COPY = 7,
        E_FAIL_TASK_VALIDATION = 8,
        E_FAIL_CREATE_CONNECTION = 9,
        E_FAIL_SCHEMA_NOT_FOUND = 10,
        E_FAIL_CLASS_NOT_FOUND = 11,
        E_FAIL_UNSUPPORTED_CAPABILITY = 12,
        E_FAIL_LOAD_QUERY_RESULTS = 13,
        E_FAIL_UNKNOWN = 14
    }
}