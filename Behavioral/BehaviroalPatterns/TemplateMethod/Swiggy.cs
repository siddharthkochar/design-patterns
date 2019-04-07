namespace BehavioralPatterns.TemplateMethod
{
    using System;

    public class Swiggy : FoodDelivery
    {
        protected override void TakeOrder() => throw new NotImplementedException();

        protected override void ProcessPayment() => throw new NotImplementedException();

        protected override void Prepare() => throw new NotImplementedException();

        protected override void Cook() => throw new NotImplementedException();

        protected override void Deliver() => throw new NotImplementedException();
    }
}
