namespace backend02
{
    class Pessoa_Juridica : Clients
    {
        public string cnpj {get;set;}
        public string ie {get;set;}

        public override void PayTax(float x)
        {
            this.value = x;
            this.tax_value = this.value * 20/100;
            this.total = this.value + this.tax_value;
        }
    }
}