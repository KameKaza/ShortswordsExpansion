using Terraria.ID;
using Terraria.ModLoader;

namespace MoreShortswords.Items.Weapons
{
	public class CobaltDagger : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cobalt Dagger");
		}

		public override void SetDefaults()
		{
			item.damage = 58;
			item.melee = true;
			item.width = 15;
            item.height = 15;
            item.useTime = 18;
            item.useAnimation = 18;
            item.useStyle = 3;
            item.knockBack = 5;
            item.value = 30000;
            item.rare = 4;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
		}

		public override void AddRecipes()
        {
        	ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CobaltBar, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
            // Recipes here. See Basic Recipe Guide
        }
	}
}