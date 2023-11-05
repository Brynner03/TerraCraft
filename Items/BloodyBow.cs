using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BrynnerMod.Items
{
	public class BloodyBow : ModItem
	{
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.BrynnerMod.hjson file.

		public override void SetDefaults()
		{
			Item.damage = 23;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 30;
			Item.useAnimation = 30;
			Item.useStyle = 5;
			Item.knockBack = 5;
			Item.value = 10000;
			Item.rare = 2;
			Item.UseSound = SoundID.Item5;
			Item.autoReuse = true;
			Item.shoot = 1;
			Item.useAmmo = AmmoID.Arrow;
			Item.shootSpeed = 6.25f;
			Item.noMelee = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Silk, 1);
			recipe.AddIngredient(ItemID.Wood, 5);
            recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}

        public override Vector2? HoldoutOffset()
        {
			Vector2 offset = new Vector2(6,0);
            return offset;

        }
    }
}