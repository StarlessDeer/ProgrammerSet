using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ProgrammerSet.Items
{
	public class ProgrammerSocks : ModItem
	{
		public override void SetStaticDefaults() 
		{
			Tooltip.SetDefault("The pink, light blue and white color just shows appreciation for Sylveon and nothing else.");
		}

		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 14;
			item.value = 20000;
			item.rare = ItemRarityID.LightRed;
			item.defense = 2;
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed += 0.3f;
			player.meleeSpeed += 0.05f;
			player.numMinions++;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BeeBreastplate, 1);
			recipe.AddIngredient(ItemID.Silk, 10);
			recipe.AddIngredient(ItemID.HellstoneBar, 5);
			recipe.AddTile(TileID.Hellforge);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}