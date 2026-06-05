using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.UI;
using Terraria.ModLoader;

namespace NewGear
{
	public class DemonCustomCurrency : CustomCurrencySingleCoin
	{
		public DemonCustomCurrency(int coinItemId, long currencyCap, string currencyTextKey, Color currencyTextColor) : base(coinItemId, currencyCap) {
			CurrencyTextKey = currencyTextKey;
			CurrencyTextColor = currencyTextColor;
		}
	}
	public sealed class DemonCustomCurrencies : ModSystem {
		public static int DemonItemCurrency {  get; set; }

		public override void PostSetupContent() {
			DemonItemCurrency = CustomCurrencyManager.RegisterCurrency(new DemonCustomCurrency(
				coinItemId: ModContent.ItemType<Items.DemonCoinItem>(),
				currencyCap: 999,
				currencyTextKey: "Mods.NewGear.Currencies.DemonCustomCurrency",
				currencyTextColor: Color.Crimson
			));
		}
	}
}