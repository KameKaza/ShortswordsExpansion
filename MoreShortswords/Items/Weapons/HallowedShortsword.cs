using Terraria.ID;
using Terraria.ModLoader;

namespace MoreShortswords.Items.Weapons
{
	public class HallowedShortsword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hallowed Shortsword");
		}

		public override void SetDefaults()
		{
			item.damage = 89;
			item.melee = true;
			item.width = 15;
			item.height = 15;
			item.useTime = 16;
			item.useAnimation = 16;
			item.useStyle = 3;
			item.knockBack = 3;
			item.value = 40000;
			item.rare = 5;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HallowedBar, 10);
			recipe.AddTile(412);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}