using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace NewGear.Content.Items
{
	public class DemonCoinItem : ModItem
	{
		public override void SetStaticDefaults() {
			// The text shown below some item names is called a tooltip. Tooltips are defined in the localization files. See en-US.hjson.

			// How many items are needed in order to research duplication of this item in Journey mode. See https://terraria.wiki.gg/wiki/Journey_Mode#Research for a list of commonly used research amounts depending on item type. This defaults to 1, which is what most items will use, so you can omit this for most ModItems.
			Item.ResearchUnlockCount = 100;

			// This item is a custom currency (registered in ExampleMod), so you might want to make it give "coin luck" to the player when thrown into shimmer. See https://terraria.wiki.gg/wiki/Luck#Coins
			// However, since this item is also used in other shimmer related examples, it's commented out to avoid the item disappearing
			ItemID.Sets.CoinLuckValue[Type] = Item.value;
		}

		public override void SetDefaults() {
			Item.width = 20; // The item texture's width
			Item.height = 20; // The item texture's height
			Item.IsACoin = true;
			Item.IsCurrency = true;

			Item.maxStack = Item.CommonMaxStack;
			// This is the equivalent between the Demon Coin value and the coins from Terraria
			// One Demon Coin is equal to 100 Platinum coins
			Item.value = Item.buyPrice(int platinum: 100);
		}
	}
}
