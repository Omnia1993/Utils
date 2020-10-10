
    using System;

    namespace Inheritance
    {
        class Transaction
        {
            private DateTime timestamp;
            private bool successful;
            private decimal amount;
            private string type;

            public DateTime Timestamp { get => timestamp; set => timestamp = value; }
            public bool Successful { get => successful; set => successful = value; }
            public decimal Amount { get => amount; set => amount = value; }
            public string Type { get => type; set => type = value; }

            public Transaction(decimal amount, string type, bool success)
            {
                this.amount = amount;
                this.type = type;
                this.timestamp = DateTime.Now;
                this.successful = success;
            }

            public override string ToString()
            {
                return String.Format("Transaction: {0}\n\tAmount: {1,10:C} Successful?: {2}", Type, Amount, Successful);
            }
        }
    }


    
