namespace backend02
{
    class Clients
    {
        public string name {get; set;}
        public string adress {get; set;}
        public float value {get; protected set;}
        public float tax_value {get; protected set;}
        public float total {get; protected set;}

        public virtual void PayTax(float x) {
            this.value = x;
            this.tax_value = this.value * 10/100;
            this.total = this.value + this.tax_value;
        }
    }
}