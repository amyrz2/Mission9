using System;
using System.Text.Json.Serialization;
using Bookstore.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Bookstore.Models
{
	public class SessionBasket : Basket
	{

        public static Basket GetBasket(IServiceProvider services)
        {
            // pull info about the session first
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            // look and see if there's a "Basket" (a new session) if not, make a new session
            SessionBasket basket = session?.GetJson<SessionBasket>("Basket") ?? new SessionBasket();

            // update the session information
            basket.Session = session;

            return basket;
        }


        [JsonIgnore]
		public ISession Session { get; set; }

        public override void AddItem(Book bo, int qty)
        {
            base.AddItem(bo, qty);
            Session.SetJson("Basket", this);
        }

        public override void RemoveItem(Book bo)
        {
            base.RemoveItem(bo);
            Session.SetJson("Basket", this);
        }

        public override void ClearBasket()
        {
            base.ClearBasket();
            Session.Remove("Basket");
        }
    }
}

