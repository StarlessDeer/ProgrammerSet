using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ProgrammerSet.Items
{
	public class ProgrammerSkirt : ModItem
	{
		public override void SetStaticDefaults() 
		{
			Tooltip.SetDefault("Only the bravest of warrior were deemed worthy of wearing this.");
		}

		public override void SetDefaults()
		{
			item.width = 32;
			item.height = 24;
			item.value = 10000;
			item.rare = ItemRarityID.LightRed;
			item.defense = 5;
		}

		public override void UpdateEquip(Player player)
		{
			player.meleeSpeed += 0.1f;
			player.minionKB += 0.1f;
			player.numMinions++;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BeeGreaves, 1);
			recipe.AddIngredient(ItemID.Silk, 5);
			recipe.AddIngredient(ItemID.CrimtaneBar, 10);
			recipe.AddTile(TileID.Hellforge);
			recipe.SetResult(this);
			recipe.AddRecipe();
			recipe.AddIngredient(ItemID.BeeGreaves, 1);
			recipe.AddIngredient(ItemID.Silk, 5);
			recipe.AddIngredient(ItemID.DemoniteBar, 10);
			recipe.AddTile(TileID.Hellforge);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}