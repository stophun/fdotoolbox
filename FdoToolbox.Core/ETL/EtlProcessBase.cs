using System;
using System.Collections.Generic;
using System.Text;
using FdoToolbox.Core.ETL.Operations;

namespace FdoToolbox.Core.ETL
{
    /// <summary>
    /// Base class for etl processes, provider registration and management
    /// services for the pipeline
    /// </summary>
    /// <typeparam name="TDerived">The type of the derived.</typeparam>
    public class EtlProcessBase<TDerived> : WithLoggingMixin
        where TDerived : EtlProcessBase<TDerived>
    {

        /// <summary>
        /// Ordered list of the operations in this process that will be added to the
        /// operations list after the initialization is completed.
        /// </summary>
        private readonly List<IFdoOperation> lastOperations = new List<IFdoOperation>();

        /// <summary>
        /// Ordered list of the operations in this process
        /// </summary>
        protected readonly List<IFdoOperation> operations = new List<IFdoOperation>();

        /// <summary>
        /// Gets the name of this instance
        /// </summary>
        /// <value>The name.</value>
        public virtual string Name
        {
            get { return GetType().Name; }
        }

        /// <summary>
        /// Registers the specified operation.
        /// </summary>
        /// <param name="operation">The operation.</param>
        public TDerived Register(IFdoOperation operation)
        {
            operations.Add(operation);
            Debug("Register {0} in {1}", operation.Name, Name);
            return (TDerived)this;
        }




        /// <summary>
        /// Registers the operation at the end of the operations queue
        /// </summary>
        /// <param name="operation">The operation.</param>
        public TDerived RegisterLast(IFdoOperation operation)
        {
            lastOperations.Add(operation);
            Debug("RegisterLast {0} in {1}", operation.Name, Name);
            return (TDerived)this;
        }

        /// <summary>
        /// Merges the last operations to the operations list.
        /// </summary>
        protected void MergeLastOperationsToOperations()
        {
            operations.AddRange(lastOperations);
        }
    }
}
