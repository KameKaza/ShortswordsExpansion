using Terraria.ID;
using Terraria.ModLoader;

namespace MoreShortswords.Items.Weapons
{
    public class ChlorophyteStabber : ModItem
    {
        public override void SetStaticDefaults()
        {
        	DisplayName.SetDefault("Chlorophyte Shortsword");
            Tooltip.SetDefault("Planty of Stabs");
        }

        public override void SetDefaults()
        {
            item.damage = 99;
            item.melee = true;
            item.width = 15;
            item.height = 15;
            item.useTime = 16;
            item.useAnimation = 16;
            item.useStyle = 3;
            item.knockBack = 5;
            item.value = 50000;
            item.rare = 7;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            // Set other item.X values here
        }

        public override void AddRecipes()
        {
        	ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ChlorophyteBar, 12);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();
            // Recipes here. See Basic Recipe Guide
        }
    }
}