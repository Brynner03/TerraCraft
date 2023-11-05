using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BrynnerMod.Items
{
	public class BloodyPickaxe : ModItem
	{
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.BrynnerMod.hjson file.

		public override void SetDefaults()
		{
			Item.damage = 9;
			Item.DamageType = DamageClass.Melee;
			Item.width = 15;
			Item.height = 15;
			Item.useTime = 26;
			Item.useAnimation = 26;
			Item.useStyle = 1;
			Item.knockBack = 1;
			Item.value = 5000;
			Item.rare = 2;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.pick = 63;
			Item.useTurn = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Wood, 5);
			recipe.AddIngredient(ItemID.CrimstoneBlock, 9);
            recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}