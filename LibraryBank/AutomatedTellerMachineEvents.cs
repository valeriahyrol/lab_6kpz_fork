﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBank
{
    public partial class AutomatedTellerMachine
    {
        public event EventHandler AuthenticationFailed;
        public event EventHandler Authenticated;
        public event EventHandler BalanceChecked;
        public event EventHandler CashWithdrawn;
        public event EventHandler CashDeposited;
        public event EventHandler FundsTransferred;

        protected virtual void OnAuthenticationFailed()
        {
            AuthenticationFailed?.Invoke(this, EventArgs.Empty);
        }

        protected virtual void OnAuthenticated()
        {
            Authenticated?.Invoke(this, EventArgs.Empty);
        }

        protected virtual void OnBalanceChecked()
        {
            BalanceChecked?.Invoke(this, EventArgs.Empty);
        }

        protected virtual void OnCashWithdrawn()
        {
            CashWithdrawn?.Invoke(this, EventArgs.Empty);
        }

        protected virtual void OnCashDeposited()
        {
            CashDeposited?.Invoke(this, EventArgs.Empty);
        }

        protected virtual void OnFundsTransferred()
        {
            FundsTransferred?.Invoke(this, EventArgs.Empty);
        }
    }
}