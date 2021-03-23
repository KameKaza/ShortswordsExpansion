using Terraria.ID;
using Terraria.ModLoader;

namespace MoreShortswords.Items
{
	public class Stabber : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Terra Sword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("A magic, fast blade.");
			// This
		}

		public override void SetDefaults() 
		{
			item.damage = 207;
			item.melee = true;
			item.width = 15;
			item.height = 15;
			item.useTime = 9;
			item.useAnimation = 9;
			item.useStyle = 3;
			item.knockBack = 0;
			item.value = 100000;
			item.rare = 8;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TerraBlade, 1);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();



            recipe = new ModRecipe(mod);
            recipe.AddIngredient(this);
            recipe.AddTile(134);
            recipe.SetResult(ItemID.TerraBlade);
            recipe.AddRecipe();
		}
	}
}