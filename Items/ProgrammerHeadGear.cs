using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ProgrammerSet.Items
{
	public class ProgrammerHeadGear : ModItem
	{
		public override void SetStaticDefaults() 
		{
			Tooltip.SetDefault("Yes the long hair adds protection.");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 5000;
			item.rare = ItemRarityID.LightRed;
			item.defense = 4;
		}

		public override void UpdateEquip(Player player)
		{
			player.minionDamageMult += 0.1f;
			player.meleeSpeed+=0.05f;
			player.numMinions++;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BeeHeadgear, 1);
			recipe.AddIngredient(ItemID.Bone, 10);
			recipe.AddIngredient(ItemID.TissueSample, 10);
			recipe.AddTile(TileID.Hellforge);
			recipe.SetResult(this);
			recipe.AddRecipe();
			recipe.AddIngredient(ItemID.BeeHeadgear, 1);
			recipe.AddIngredient(ItemID.Bone, 10);
			recipe.AddIngredient(ItemID.ShadowScale, 10);
			recipe.AddTile(TileID.Hellforge);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}