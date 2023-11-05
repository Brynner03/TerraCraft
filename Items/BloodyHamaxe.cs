using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BrynnerMod.Items
{
	public class BloodyHamaxe : ModItem
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
			Item.knockBack = 5;
			Item.value = 3000;
			Item.rare = 2;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.axe = 12;
			Item.hammer = 63;
			Item.useTurn = true;
			Item.scale = 1.2f;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Wood, 5);
			recipe.AddIngredient(ItemID.CrimstoneBlock, 17);
            recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}