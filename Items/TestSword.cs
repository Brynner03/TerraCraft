using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BrynnerMod.Items
{
	public class TestSword : ModItem
	{
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.BrynnerMod.hjson file.

		public override void SetDefaults()
		{
			Item.damage = 23;
			Item.DamageType = DamageClass.Melee;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 26;
			Item.useAnimation = 26;
			Item.useStyle = 1;
			Item.knockBack = 5;
			Item.value = 5000;
			Item.rare = 2;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Wood, 5);
			recipe.AddIngredient(ItemID.CrimstoneBlock, 3);
            recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}