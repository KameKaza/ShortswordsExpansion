using Terraria.ID;
using Terraria.ModLoader;

namespace MoreShortswords.Items.Weapons
{
	public class SolarStabber : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Solar Sword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("You will incarnate enemies.");
		}

		public override void SetDefaults() 
		{
			item.damage = 1000;
			item.melee = true;
			item.width = 15;
			item.height = 15;
			item.useTime = 40;
			item.useAnimation = 40;
			item.useStyle = 3;
			item.knockBack = 8;
			item.value = 200000;
			item.rare = 9;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(3458, 12);
			recipe.AddTile(412);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}