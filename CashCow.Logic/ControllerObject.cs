//@BaseCode
using CashCow.Logic.Contracts;
using CommonBase.Extensions;
using System;

namespace CashCow.Logic
{
    internal class ControllerObject : IDisposable
    {
        private bool contextOwner;
        protected IContext Context { get; set; }

        public ControllerObject(IContext context)
        {
            context.CheckArgument(nameof(context));
            contextOwner = true;
        }

        public ControllerObject(ControllerObject other)
        {
            other.CheckArgument(nameof(other));

            contextOwner = false;
            Context = other.Context;
        }

        #region Dispose Pattern
        private bool disposedValue;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~ControllerObject()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        void IDisposable.Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
