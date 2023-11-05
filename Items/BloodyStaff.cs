using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace BrynnerMod.Items
{
	public class BloodyStaff : ModItem
	{
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.BrynnerMod.hjson file.

		public override void SetDefaults()
		{
			Item.width = 28;
			Item.height = 28;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.staff[Type] = true;

			Item.DamageType = DamageClass.Magic;
			Item.noMelee = true;
			Item.mana = 4;
			Item.damage = 100;
			Item.knockBack = 3.5f;

			Item.useTime = 15;
			Item.useAnimation = 15;

			Item.UseSound = SoundID.Item8;

			Item.shoot = 123;
			Item.shootSpeed = 5f;
		}

        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
			Vector2 offset = new Vector2(velocity.X * 3, velocity.Y * 3);
			position += offset;
			return true;
        }

        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Wood, 5);
			recipe.AddIngredient(ItemID.CrimstoneBlock, 10);
			recipe.AddIngredient(ItemID.BloodbathDye, 2);
            recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}