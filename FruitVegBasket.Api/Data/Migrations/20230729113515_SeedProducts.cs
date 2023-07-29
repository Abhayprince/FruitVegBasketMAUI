using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FruitVegBasket.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Unit",
                table: "Product",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Offer",
                keyColumn: "Id",
                keyValue: 1,
                column: "BgColor",
                value: "#d0f200");

            migrationBuilder.UpdateData(
                table: "Offer",
                keyColumn: "Id",
                keyValue: 3,
                column: "BgColor",
                value: "#ea978d");

            migrationBuilder.UpdateData(
                table: "Offer",
                keyColumn: "Id",
                keyValue: 4,
                column: "BgColor",
                value: "#e28083");

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "Image", "Name", "Price", "Unit" },
                values: new object[,]
                {
                    { 1, (short)13, null, "Chicken Breast", 4.99m, "per pound" },
                    { 2, (short)13, null, "Pork Chops", 6.99m, "per pound" },
                    { 3, (short)14, null, "Salmon", 9.99m, "per pound" },
                    { 4, (short)14, null, "Shrimp", 12.99m, "per pound" },
                    { 5, (short)13, null, "Chicken Thighs", 3.99m, "per pound" },
                    { 6, (short)13, null, "Ground Turkey", 4.99m, "per pound" },
                    { 7, (short)13, null, "Lamb Chops", 10.99m, "per pound" },
                    { 8, (short)14, null, "Tuna", 8.99m, "per pound" },
                    { 9, (short)13, null, "Pork Ribs", 7.99m, "per pound" },
                    { 10, (short)14, null, "Cod", 10.99m, "per pound" },
                    { 11, (short)13, null, "Chicken Wings", 3.99m, "per pound" },
                    { 12, (short)13, null, "Ground Pork", 4.99m, "per pound" },
                    { 13, (short)14, null, "Tilapia", 7.99m, "per pound" },
                    { 14, (short)13, null, "Chicken Drumsticks", 2.99m, "per pound" },
                    { 15, (short)13, null, "Turkey Breast", 5.99m, "per pound" },
                    { 16, (short)14, null, "Catfish", 9.99m, "per pound" },
                    { 17, (short)14, null, "Scallops", 15.99m, "per pound" },
                    { 18, (short)13, null, "Turkey Bacon", 4.99m, "per pack" },
                    { 19, (short)13, null, "Ground Chicken", 4.99m, "per pound" },
                    { 20, (short)14, null, "Salmon Fillet", 12.99m, "per pound" },
                    { 21, (short)13, null, "Pork Sausage", 5.99m, "per pack" },
                    { 22, (short)12, null, "Large Eggs", 2.99m, "per dozen" },
                    { 23, (short)12, null, "Extra Large Eggs", 3.49m, "per dozen" },
                    { 24, (short)12, null, "Jumbo Eggs", 3.99m, "per dozen" },
                    { 25, (short)12, null, "Organic Eggs", 4.99m, "per dozen" },
                    { 26, (short)12, null, "Free-Range Eggs", 4.99m, "per dozen" },
                    { 27, (short)12, null, "Cage-Free Eggs", 4.99m, "per dozen" },
                    { 28, (short)12, null, "Brown Eggs", 3.99m, "per dozen" },
                    { 29, (short)12, null, "White Eggs", 2.99m, "per dozen" },
                    { 30, (short)12, null, "Liquid Egg Whites", 3.99m, "per carton" },
                    { 31, (short)12, null, "Egg Beaters", 3.99m, "per carton" },
                    { 32, (short)12, null, "Egg Yolks", 2.99m, "per dozen" },
                    { 33, (short)12, null, "Egg Substitutes", 3.49m, "per carton" },
                    { 34, (short)12, null, "Pasteurized Eggs", 4.99m, "per dozen" },
                    { 35, (short)12, null, "Egg Whites", 2.99m, "per carton" },
                    { 36, (short)12, null, "Egg Powder", 3.99m, "per container" },
                    { 37, (short)12, null, "Hard-Boiled Eggs", 3.99m, "per package" },
                    { 38, (short)12, null, "Deviled Eggs", 4.99m, "per package" },
                    { 39, (short)12, null, "Scrambled Eggs", 3.99m, "per package" },
                    { 40, (short)12, null, "Egg Salad", 4.99m, "per package" },
                    { 41, (short)12, null, "Omelette Mix", 3.99m, "per container" },
                    { 42, (short)10, null, "Salted Butter", 3.99m, "per pound" },
                    { 43, (short)10, null, "Unsalted Butter", 3.99m, "per pound" },
                    { 44, (short)10, null, "Margarine", 2.99m, "per pound" },
                    { 45, (short)10, null, "Cheddar Cheese", 4.99m, "per pound" },
                    { 46, (short)10, null, "Mozzarella Cheese", 3.99m, "per pound" },
                    { 47, (short)10, null, "Swiss Cheese", 4.99m, "per pound" },
                    { 48, (short)10, null, "Parmesan Cheese", 5.99m, "per pound" },
                    { 49, (short)10, null, "Blue Cheese", 5.99m, "per pound" },
                    { 50, (short)10, null, "Brie Cheese", 6.99m, "per pound" },
                    { 51, (short)10, null, "Camembert Cheese", 6.99m, "per pound" },
                    { 52, (short)10, null, "Feta Cheese", 4.99m, "per pound" },
                    { 53, (short)10, null, "Cottage Cheese", 3.99m, "per pound" },
                    { 54, (short)10, null, "Colby Cheese", 4.99m, "per pound" },
                    { 55, (short)10, null, "Pepper Jack Cheese", 4.99m, "per pound" },
                    { 56, (short)10, null, "Gouda Cheese", 5.99m, "per pound" },
                    { 57, (short)10, null, "Havarti Cheese", 5.99m, "per pound" },
                    { 58, (short)10, null, "Monterey Jack Cheese", 4.99m, "per pound" },
                    { 59, (short)10, null, "Muenster Cheese", 5.99m, "per pound" },
                    { 60, (short)10, null, "Provolone Cheese", 4.99m, "per pound" },
                    { 61, (short)10, null, "Ghee", 7.99m, "per pound" },
                    { 62, (short)9, null, "Whole Milk", 2.99m, "per gallon" },
                    { 63, (short)9, null, "Skim Milk", 3.49m, "per gallon" },
                    { 64, (short)9, null, "Almond Milk", 2.99m, "per carton" },
                    { 65, (short)9, null, "Soy Milk", 3.49m, "per carton" },
                    { 66, (short)9, null, "Greek Yogurt", 1.99m, "per container" },
                    { 67, (short)9, null, "Plain Yogurt", 1.99m, "per container" },
                    { 68, (short)9, null, "Flavored Yogurt", 2.49m, "per container" },
                    { 69, (short)9, null, "Curd", 2.99m, "per container" },
                    { 70, (short)9, null, "Low-Fat Milk", 2.99m, "per gallon" },
                    { 71, (short)9, null, "Buttermilk", 2.49m, "per quart" },
                    { 72, (short)9, null, "Coconut Milk", 2.99m, "per carton" },
                    { 73, (short)9, null, "Condensed Milk", 3.99m, "per can" },
                    { 74, (short)9, null, "Yogurt Drink", 2.99m, "per bottle" },
                    { 75, (short)9, null, "Probiotic Yogurt", 2.99m, "per container" },
                    { 76, (short)9, null, "Sour Cream", 1.99m, "per container" },
                    { 77, (short)9, null, "Whipped Cream", 2.49m, "per can" },
                    { 78, (short)9, null, "Milkshake", 2.99m, "per bottle" },
                    { 79, (short)9, null, "Lassi", 1.99m, "per bottle" },
                    { 80, (short)9, null, "Evaporated Milk", 3.99m, "per can" },
                    { 81, (short)9, null, "Half and Half", 2.99m, "per pint" },
                    { 82, (short)7, null, "Lettuce", 1.99m, "per head" },
                    { 83, (short)7, null, "Tomatoes", 2.99m, "per pound" },
                    { 84, (short)7, null, "Cucumbers", 1.99m, "per pound" },
                    { 85, (short)7, null, "Bell Peppers", 1.99m, "each" },
                    { 86, (short)7, null, "Carrots", 1.49m, "per pound" },
                    { 87, (short)7, null, "Radishes", 1.99m, "per bunch" },
                    { 88, (short)7, null, "Cabbage", 1.49m, "per pound" },
                    { 89, (short)7, null, "Onions", 0.99m, "per pound" },
                    { 90, (short)7, null, "Corn", 0.69m, "per ear" },
                    { 91, (short)7, null, "Celery", 1.99m, "per bunch" },
                    { 92, (short)7, null, "Mushrooms", 2.99m, "per pound" },
                    { 93, (short)7, null, "Avocado", 1.99m, "each" },
                    { 94, (short)7, null, "Spinach", 2.99m, "per pound" },
                    { 95, (short)7, null, "Sprouts", 2.49m, "per pound" },
                    { 96, (short)7, null, "Beets", 2.99m, "per bunch" },
                    { 97, (short)7, null, "Romaine Lettuce", 2.49m, "per head" },
                    { 98, (short)7, null, "Arugula", 2.99m, "per bunch" },
                    { 99, (short)7, null, "Cherry Tomatoes", 3.99m, "per pound" },
                    { 100, (short)7, null, "Red Onions", 0.99m, "per pound" },
                    { 101, (short)7, null, "Peppers", 1.99m, "each" },
                    { 102, (short)5, null, "Broccoli", 2.99m, "per pound" },
                    { 103, (short)5, null, "Green Beans", 3.49m, "per pound" },
                    { 104, (short)5, null, "Zucchini", 1.99m, "per pound" },
                    { 105, (short)5, null, "Asparagus", 3.99m, "per pound" },
                    { 106, (short)5, null, "Brussels Sprouts", 2.99m, "per pound" },
                    { 107, (short)5, null, "Cucumber", 1.49m, "each" },
                    { 108, (short)5, null, "Peas", 2.49m, "per pound" },
                    { 109, (short)5, null, "Artichoke", 2.99m, "each" },
                    { 110, (short)5, null, "Kale", 3.49m, "per bunch" },
                    { 111, (short)5, null, "Green Bell Pepper", 1.99m, "each" },
                    { 112, (short)5, null, "Okra", 2.99m, "per pound" },
                    { 113, (short)5, null, "Green Cabbage", 1.49m, "per pound" },
                    { 114, (short)5, null, "Green Peppers", 1.99m, "each" },
                    { 115, (short)5, null, "Snow Peas", 3.99m, "per pound" },
                    { 116, (short)5, null, "Green Onions", 0.99m, "per bunch" },
                    { 117, (short)5, null, "Lima Beans", 2.49m, "per pound" },
                    { 118, (short)5, null, "Green Tomatoes", 1.99m, "per pound" },
                    { 119, (short)5, null, "Green Peas", 2.99m, "per pound" },
                    { 120, (short)5, null, "Green Garlic", 1.99m, "per bunch" },
                    { 121, (short)5, null, "Green Chard", 2.99m, "per bunch" },
                    { 122, (short)6, null, "Spinach", 2.99m, "per pound" },
                    { 123, (short)6, null, "Kale", 3.49m, "per bunch" },
                    { 124, (short)6, null, "Lettuce", 1.99m, "per head" },
                    { 125, (short)6, null, "Arugula", 2.99m, "per bunch" },
                    { 126, (short)6, null, "Cabbage", 1.49m, "per head" },
                    { 127, (short)6, null, "Collard Greens", 2.99m, "per bunch" },
                    { 128, (short)6, null, "Swiss Chard", 2.99m, "per bunch" },
                    { 129, (short)6, null, "Mustard Greens", 2.49m, "per bunch" },
                    { 130, (short)6, null, "Bok Choy", 1.99m, "per pound" },
                    { 131, (short)6, null, "Watercress", 3.99m, "per bunch" },
                    { 132, (short)6, null, "Romaine Lettuce", 2.49m, "per head" },
                    { 133, (short)6, null, "Cilantro", 0.99m, "per bunch" },
                    { 134, (short)6, null, "Parsley", 0.99m, "per bunch" },
                    { 135, (short)6, null, "Dandelion Greens", 2.99m, "per bunch" },
                    { 136, (short)6, null, "Green Leaf Lettuce", 1.99m, "per head" },
                    { 137, (short)6, null, "Red Leaf Lettuce", 1.99m, "per head" },
                    { 138, (short)6, null, "Iceberg Lettuce", 1.49m, "per head" },
                    { 139, (short)6, null, "Endive", 2.49m, "per bunch" },
                    { 140, (short)6, null, "Kohlrabi", 1.99m, "per pound" },
                    { 141, (short)6, null, "Mizuna", 2.49m, "per bunch" },
                    { 142, (short)2, null, "Strawberries", 2.99m, "per pound" },
                    { 143, (short)2, null, "Blueberries", 3.99m, "per pound" },
                    { 144, (short)2, null, "Raspberries", 4.99m, "per pound" },
                    { 145, (short)2, null, "Blackberries", 3.99m, "per pound" },
                    { 146, (short)2, null, "Watermelon", 0.39m, "per pound" },
                    { 147, (short)2, null, "Cantaloupe", 1.99m, "each" },
                    { 148, (short)2, null, "Honeydew", 2.49m, "each" },
                    { 149, (short)2, null, "Peaches", 1.99m, "per pound" },
                    { 150, (short)2, null, "Plums", 2.99m, "per pound" },
                    { 151, (short)2, null, "Apricots", 2.99m, "per pound" },
                    { 152, (short)2, null, "Nectarines", 3.49m, "per pound" },
                    { 153, (short)2, null, "Cherries", 4.99m, "per pound" },
                    { 154, (short)2, null, "Grapes", 2.99m, "per pound" },
                    { 155, (short)2, null, "Oranges", 0.99m, "per pound" },
                    { 156, (short)2, null, "Mangoes", 1.99m, "each" },
                    { 157, (short)2, null, "Pineapple", 2.99m, "each" },
                    { 158, (short)2, null, "Pears", 2.99m, "per pound" },
                    { 159, (short)2, null, "Apples", 1.99m, "per pound" },
                    { 160, (short)2, null, "Kiwi", 0.99m, "each" },
                    { 161, (short)2, null, "Limes", 0.49m, "each" },
                    { 162, (short)3, null, "Dragon Fruit", 4.99m, "each" },
                    { 163, (short)3, null, "Mangosteen", 6.99m, "per pound" },
                    { 164, (short)3, null, "Rambutan", 5.49m, "per pound" },
                    { 165, (short)3, null, "Durian", 9.99m, "each" },
                    { 166, (short)3, null, "Kiwano (Horned Melon)", 3.99m, "each" },
                    { 167, (short)3, null, "Cherimoya", 6.99m, "each" },
                    { 168, (short)3, null, "Pitahaya (Dragon Fruit)", 5.99m, "each" },
                    { 169, (short)3, null, "Physalis", 4.99m, "per pound" },
                    { 170, (short)3, null, "Passion Fruit", 4.99m, "per pound" },
                    { 171, (short)3, null, "Kumquat", 3.99m, "per pound" },
                    { 172, (short)3, null, "Mamey Sapote", 6.99m, "each" },
                    { 173, (short)3, null, "Papaya", 3.99m, "each" },
                    { 174, (short)3, null, "Jabuticaba", 7.99m, "per pound" },
                    { 175, (short)3, null, "Salak (Snake Fruit)", 8.99m, "per pound" },
                    { 176, (short)3, null, "Guava", 3.99m, "per pound" },
                    { 177, (short)3, null, "Lychee", 5.99m, "per pound" },
                    { 178, (short)3, null, "Starfruit", 4.99m, "each" },
                    { 179, (short)3, null, "Carambola (Star Fruit)", 4.99m, "each" },
                    { 180, (short)3, null, "Pomelo", 5.99m, "each" },
                    { 181, (short)3, null, "Feijoa", 4.99m, "per pound" },
                    { 182, (short)3, null, "Custard Apple", 6.99m, "each" },
                    { 183, (short)3, null, "Jackfruit", 6.99m, "per pound" },
                    { 184, (short)3, null, "Longan", 5.99m, "per pound" },
                    { 185, (short)3, null, "Açai", 9.99m, "per pound" },
                    { 186, (short)3, null, "Soursop", 7.99m, "per pound" },
                    { 187, (short)3, null, "Pepino Melon", 3.99m, "each" },
                    { 188, (short)3, null, "Mango", 4.99m, "each" },
                    { 189, (short)3, null, "Avocado", 3.99m, "each" },
                    { 190, (short)3, null, "Persimmon", 4.99m, "each" },
                    { 191, (short)3, null, "Banana Passionfruit", 6.99m, "per pound" },
                    { 192, (short)3, null, "Cactus Pear", 3.99m, "each" },
                    { 193, (short)3, null, "Pitaya (Dragon Fruit)", 5.99m, "each" },
                    { 194, (short)3, null, "African Horned Cucumber", 4.99m, "each" },
                    { 195, (short)3, null, "Star Apple", 6.99m, "each" },
                    { 196, (short)3, null, "Barbados Cherry", 5.99m, "per pound" },
                    { 197, (short)3, null, "Cupuaçu", 7.99m, "each" },
                    { 198, (short)3, null, "Atemoya", 7.99m, "each" },
                    { 199, (short)3, null, "Sapodilla", 6.99m, "each" },
                    { 200, (short)3, null, "Cupuacu", 7.99m, "each" },
                    { 201, (short)3, null, "Feijoa", 4.99m, "per pound" },
                    { 202, (short)3, null, "Black Sapote", 7.99m, "each" },
                    { 203, (short)3, null, "Breadfruit", 4.99m, "each" },
                    { 204, (short)3, null, "Canistel", 6.99m, "each" },
                    { 205, (short)3, null, "Soursop", 7.99m, "per pound" },
                    { 206, (short)3, null, "Jujube", 5.99m, "per pound" },
                    { 207, (short)3, null, "Marula", 8.99m, "each" },
                    { 208, (short)3, null, "Ugli Fruit", 4.99m, "each" },
                    { 209, (short)3, null, "Mango", 4.99m, "each" },
                    { 210, (short)3, null, "Avocado", 3.99m, "each" },
                    { 211, (short)3, null, "Persimmon", 4.99m, "each" },
                    { 212, (short)3, null, "Banana Passionfruit", 6.99m, "per pound" },
                    { 213, (short)3, null, "Cactus Pear", 3.99m, "each" },
                    { 214, (short)3, null, "Pitaya (Dragon Fruit)", 5.99m, "each" },
                    { 215, (short)3, null, "African Horned Cucumber", 4.99m, "each" },
                    { 216, (short)3, null, "Star Apple", 6.99m, "each" },
                    { 217, (short)3, null, "Barbados Cherry", 5.99m, "per pound" },
                    { 218, (short)3, null, "Cupuaçu", 7.99m, "each" },
                    { 219, (short)3, null, "Atemoya", 7.99m, "each" },
                    { 220, (short)3, null, "Sapodilla", 6.99m, "each" },
                    { 221, (short)3, null, "Cupuacu", 7.99m, "each" },
                    { 222, (short)3, null, "Feijoa", 4.99m, "per pound" },
                    { 223, (short)3, null, "Black Sapote", 7.99m, "each" },
                    { 224, (short)3, null, "Breadfruit", 4.99m, "each" },
                    { 225, (short)3, null, "Canistel", 6.99m, "each" },
                    { 226, (short)3, null, "Soursop", 7.99m, "per pound" },
                    { 227, (short)3, null, "Jujube", 5.99m, "per pound" },
                    { 228, (short)3, null, "Marula", 8.99m, "each" },
                    { 229, (short)3, null, "Ugli Fruit", 4.99m, "each" },
                    { 300, (short)1, null, "Apple", 1.99m, "per pound" },
                    { 301, (short)1, null, "Pear", 2.49m, "per pound" },
                    { 302, (short)1, null, "Plum", 1.79m, "per pound" },
                    { 303, (short)1, null, "Cherry", 4.99m, "per pound" },
                    { 304, (short)1, null, "Apricot", 3.49m, "per pound" },
                    { 305, (short)1, null, "Peach", 2.99m, "per pound" },
                    { 306, (short)1, null, "Watermelon", 4.99m, "each" },
                    { 307, (short)1, null, "Pineapple", 3.99m, "each" },
                    { 308, (short)1, null, "Mango", 2.79m, "each" },
                    { 309, (short)1, null, "Avocado", 1.49m, "each" },
                    { 310, (short)1, null, "Cantaloupe", 3.99m, "each" },
                    { 311, (short)1, null, "Grapefruit", 1.49m, "each" },
                    { 312, (short)1, null, "Raspberry", 3.99m, "per pound" },
                    { 313, (short)1, null, "Blueberry", 3.99m, "per pound" },
                    { 314, (short)1, null, "Blackberry", 4.49m, "per pound" },
                    { 315, (short)1, null, "Strawberry", 2.99m, "per pound" },
                    { 316, (short)1, null, "Currant", 4.99m, "per pound" },
                    { 317, (short)1, null, "Fig", 2.99m, "per pound" },
                    { 318, (short)1, null, "Grapes", 2.49m, "per pound" },
                    { 319, (short)1, null, "Kiwi", 0.99m, "each" },
                    { 320, (short)1, null, "Mandarin", 2.99m, "per pound" },
                    { 321, (short)1, null, "Orange", 0.99m, "per pound" },
                    { 322, (short)1, null, "Lemon", 0.69m, "per pound" },
                    { 323, (short)1, null, "Passion Fruit", 4.99m, "per pound" },
                    { 324, (short)1, null, "Pomegranate", 3.99m, "each" },
                    { 325, (short)1, null, "Papaya", 2.99m, "each" },
                    { 326, (short)1, null, "Pomegranate", 3.99m, "each" },
                    { 327, (short)1, null, "Red Currant", 4.99m, "per pound" },
                    { 328, (short)1, null, "Tomato", 0.99m, "per pound" },
                    { 329, (short)4, null, "Cucumber", 0.79m, "each" },
                    { 330, (short)4, null, "Zucchini", 0.89m, "per pound" },
                    { 331, (short)4, null, "Carrot", 0.99m, "per pound" },
                    { 332, (short)4, null, "Broccoli", 1.29m, "per pound" },
                    { 333, (short)4, null, "Spinach", 1.99m, "per pound" },
                    { 334, (short)4, null, "Lettuce", 1.49m, "per pound" },
                    { 335, (short)4, null, "Onion", 0.79m, "per pound" },
                    { 336, (short)4, null, "Potato", 0.69m, "per pound" },
                    { 337, (short)4, null, "Bell Pepper", 1.19m, "per pound" },
                    { 338, (short)4, null, "Eggplant", 1.59m, "each" },
                    { 339, (short)4, null, "Asparagus", 2.99m, "per pound" },
                    { 340, (short)4, null, "Celery", 0.99m, "per pound" },
                    { 341, (short)4, null, "Cauliflower", 1.79m, "each" },
                    { 342, (short)4, null, "Green Bean", 2.29m, "per pound" },
                    { 343, (short)4, null, "Cabbage", 0.99m, "per pound" },
                    { 344, (short)4, null, "Corn", 0.59m, "each" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DropColumn(
                name: "Unit",
                table: "Product");

            migrationBuilder.UpdateData(
                table: "Offer",
                keyColumn: "Id",
                keyValue: 1,
                column: "BgColor",
                value: "#e1f1e7");

            migrationBuilder.UpdateData(
                table: "Offer",
                keyColumn: "Id",
                keyValue: 3,
                column: "BgColor",
                value: "#e28083");

            migrationBuilder.UpdateData(
                table: "Offer",
                keyColumn: "Id",
                keyValue: 4,
                column: "BgColor",
                value: "#e1f1e7");
        }
    }
}
