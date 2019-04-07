namespace BehavioralPatterns.TemplateMethod
{
    public abstract class FoodDelivery
    {
        protected abstract void TakeOrder();
        protected abstract void ProcessPayment();
        protected abstract void Prepare();
        protected abstract void Cook();
        protected abstract void Deliver();
        public void ProcessOrder()
        {
            TakeOrder();
            ProcessPayment();
            Prepare();
            Cook();
            Deliver();
        }
    }
}
