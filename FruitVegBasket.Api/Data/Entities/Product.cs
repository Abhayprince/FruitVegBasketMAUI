using FruitVegBasket.Shared.Dtos;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq.Expressions;

namespace FruitVegBasket.Api.Data.Entities
{
    [Table(nameof(Product))]
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(180)]
        public string? Image { get; set; }
        public decimal Price { get; set; }

        [Required, MaxLength(25)]
        public string Unit { get; set; }

        public short CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public Product(int id, string name, string? image, decimal price, string unit, short categoryId)
        {
            Id = id;
            Name = name;
            Image = image;
            Price = price;
            Unit = unit;
            CategoryId = categoryId;
        }

        public static IEnumerable<Product> GetInitialData()
        {
            var products = new List<Product>();

            var meatAndseafood = new List<Product>
            {
                new(1, "Chicken Breast", null, 4.99m, "per pound", 13), new(2, "Pork Chops", null, 6.99m, "per pound", 13), new(3, "Salmon", null, 9.99m, "per pound", 14), new(4, "Shrimp", null, 12.99m, "per pound", 14), new(5, "Chicken Thighs", null, 3.99m, "per pound", 13), new(6, "Ground Turkey", null, 4.99m, "per pound", 13), new(7, "Lamb Chops", null, 10.99m, "per pound", 13), new(8, "Tuna", null, 8.99m, "per pound", 14), new(9, "Pork Ribs", null, 7.99m, "per pound", 13), new(10, "Cod", null, 10.99m, "per pound", 14), new(11, "Chicken Wings", null, 3.99m, "per pound", 13), new(12, "Ground Pork", null, 4.99m, "per pound", 13), new(13, "Tilapia", null, 7.99m, "per pound", 14), new(14, "Chicken Drumsticks", null, 2.99m, "per pound", 13), new(15, "Turkey Breast", null, 5.99m, "per pound", 13), new(16, "Catfish", null, 9.99m, "per pound", 14), new(17, "Scallops", null, 15.99m, "per pound", 14), new(18, "Turkey Bacon", null, 4.99m, "per pack", 13), new(19, "Ground Chicken", null, 4.99m, "per pound", 13), new(20, "Salmon Fillet", null, 12.99m, "per pound", 14), new(21, "Pork Sausage", null, 5.99m, "per pack", 13)
            };
            products.AddRange(meatAndseafood);

            var eggs = new List<Product>()
            {
                new(22, "Large Eggs", null, 2.99m, "per dozen", 12), new(23, "Extra Large Eggs", null, 3.49m, "per dozen", 12), new(24, "Jumbo Eggs", null, 3.99m, "per dozen", 12), new(25, "Organic Eggs", null, 4.99m, "per dozen", 12), new(26, "Free-Range Eggs", null, 4.99m, "per dozen", 12), new(27, "Cage-Free Eggs", null, 4.99m, "per dozen", 12), new(28, "Brown Eggs", null, 3.99m, "per dozen", 12), new(29, "White Eggs", null, 2.99m, "per dozen", 12), new(30, "Liquid Egg Whites", null, 3.99m, "per carton", 12), new(31, "Egg Beaters", null, 3.99m, "per carton", 12), new(32, "Egg Yolks", null, 2.99m, "per dozen", 12), new(33, "Egg Substitutes", null, 3.49m, "per carton", 12), new(34, "Pasteurized Eggs", null, 4.99m, "per dozen", 12), new(35, "Egg Whites", null, 2.99m, "per carton", 12), new(36, "Egg Powder", null, 3.99m, "per container", 12), new(37, "Hard-Boiled Eggs", null, 3.99m, "per package", 12), new(38, "Deviled Eggs", null, 4.99m, "per package", 12), new(39, "Scrambled Eggs", null, 3.99m, "per package", 12), new(40, "Egg Salad", null, 4.99m, "per package", 12), new(41, "Omelette Mix", null, 3.99m, "per container", 12)
            };
            products.AddRange(eggs);

            var butterCheese = new List<Product>
            {
                new(42, "Salted Butter", null, 3.99m, "per pound", 10), new(43, "Unsalted Butter", null, 3.99m, "per pound", 10), new(44, "Margarine", null, 2.99m, "per pound", 10), new(45, "Cheddar Cheese", null, 4.99m, "per pound", 10), new(46, "Mozzarella Cheese", null, 3.99m, "per pound", 10), new(47, "Swiss Cheese", null, 4.99m, "per pound", 10), new(48, "Parmesan Cheese", null, 5.99m, "per pound", 10), new(49, "Blue Cheese", null, 5.99m, "per pound", 10), new(50, "Brie Cheese", null, 6.99m, "per pound", 10), new(51, "Camembert Cheese", null, 6.99m, "per pound", 10), new(52, "Feta Cheese", null, 4.99m, "per pound", 10), new(53, "Cottage Cheese", null, 3.99m, "per pound", 10), new(54, "Colby Cheese", null, 4.99m, "per pound", 10), new(55, "Pepper Jack Cheese", null, 4.99m, "per pound", 10), new(56, "Gouda Cheese", null, 5.99m, "per pound", 10), new(57, "Havarti Cheese", null, 5.99m, "per pound", 10), new(58, "Monterey Jack Cheese", null, 4.99m, "per pound", 10), new(59, "Muenster Cheese", null, 5.99m, "per pound", 10), new(60, "Provolone Cheese", null, 4.99m, "per pound", 10), new(61, "Ghee", null, 7.99m, "per pound", 10)
            };
            products.AddRange(butterCheese);

            var milkCurdYogurt = new List<Product>
            {
                new(62, "Whole Milk", null, 2.99m, "per gallon", 9), new(63, "Skim Milk", null, 3.49m, "per gallon", 9), new(64, "Almond Milk", null, 2.99m, "per carton", 9), new(65, "Soy Milk", null, 3.49m, "per carton", 9), new(66, "Greek Yogurt", null, 1.99m, "per container", 9), new(67, "Plain Yogurt", null, 1.99m, "per container", 9), new(68, "Flavored Yogurt", null, 2.49m, "per container", 9), new(69, "Curd", null, 2.99m, "per container", 9), new(70, "Low-Fat Milk", null, 2.99m, "per gallon", 9), new(71, "Buttermilk", null, 2.49m, "per quart", 9), new(72, "Coconut Milk", null, 2.99m, "per carton", 9), new(73, "Condensed Milk", null, 3.99m, "per can", 9), new(74, "Yogurt Drink", null, 2.99m, "per bottle", 9), new(75, "Probiotic Yogurt", null, 2.99m, "per container", 9), new(76, "Sour Cream", null, 1.99m, "per container", 9), new(77, "Whipped Cream", null, 2.49m, "per can", 9), new(78, "Milkshake", null, 2.99m, "per bottle", 9), new(79, "Lassi", null, 1.99m, "per bottle", 9), new(80, "Evaporated Milk", null, 3.99m, "per can", 9), new(81, "Half and Half", null, 2.99m, "per pint", 9)
            };
            products.AddRange(milkCurdYogurt);

            var salads = new List<Product>
            {
                new(82, "Lettuce", null, 1.99m, "per head", 7), new(83, "Tomatoes", null, 2.99m, "per pound", 7), new(84, "Cucumbers", null, 1.99m, "per pound", 7), new(85, "Bell Peppers", null, 1.99m, "each", 7), new(86, "Carrots", null, 1.49m, "per pound", 7), new(87, "Radishes", null, 1.99m, "per bunch", 7), new(88, "Cabbage", null, 1.49m, "per pound", 7), new(89, "Onions", null, 0.99m, "per pound", 7), new(90, "Corn", null, 0.69m, "per ear", 7), new(91, "Celery", null, 1.99m, "per bunch", 7), new(92, "Mushrooms", null, 2.99m, "per pound", 7), new(93, "Avocado", null, 1.99m, "each", 7), new(94, "Spinach", null, 2.99m, "per pound", 7), new(95, "Sprouts", null, 2.49m, "per pound", 7), new(96, "Beets", null, 2.99m, "per bunch", 7), new(97, "Romaine Lettuce", null, 2.49m, "per head", 7), new(98, "Arugula", null, 2.99m, "per bunch", 7), new(99, "Cherry Tomatoes", null, 3.99m, "per pound", 7), new(100, "Red Onions", null, 0.99m, "per pound", 7), new(101, "Peppers", null, 1.99m, "each", 7)
            };
            products.AddRange(salads);

            var greenVegetables = new List<Product>
            {
                new(102, "Broccoli", null, 2.99m, "per pound", 5), new(103, "Green Beans", null, 3.49m, "per pound", 5), new(104, "Zucchini", null, 1.99m, "per pound", 5), new(105, "Asparagus", null, 3.99m, "per pound", 5), new(106, "Brussels Sprouts", null, 2.99m, "per pound", 5), new(107, "Cucumber", null, 1.49m, "each", 5), new(108, "Peas", null, 2.49m, "per pound", 5), new(109, "Artichoke", null, 2.99m, "each", 5), new(110, "Kale", null, 3.49m, "per bunch", 5), new(111, "Green Bell Pepper", null, 1.99m, "each", 5), new(112, "Okra", null, 2.99m, "per pound", 5), new(113, "Green Cabbage", null, 1.49m, "per pound", 5), new(114, "Green Peppers", null, 1.99m, "each", 5), new(115, "Snow Peas", null, 3.99m, "per pound", 5), new(116, "Green Onions", null, 0.99m, "per bunch", 5), new(117, "Lima Beans", null, 2.49m, "per pound", 5), new(118, "Green Tomatoes", null, 1.99m, "per pound", 5), new(119, "Green Peas", null, 2.99m, "per pound", 5), new(120, "Green Garlic", null, 1.99m, "per bunch", 5), new(121, "Green Chard", null, 2.99m, "per bunch", 5)
            };
            products.AddRange(greenVegetables);

            var leafyVegetables = new List<Product>
            {
                new(122, "Spinach", null, 2.99m, "per pound", 6), new(123, "Kale", null, 3.49m, "per bunch", 6), new(124, "Lettuce", null, 1.99m, "per head", 6), new(125, "Arugula", null, 2.99m, "per bunch", 6), new(126, "Cabbage", null, 1.49m, "per head", 6), new(127, "Collard Greens", null, 2.99m, "per bunch", 6), new(128, "Swiss Chard", null, 2.99m, "per bunch", 6), new(129, "Mustard Greens", null, 2.49m, "per bunch", 6), new(130, "Bok Choy", null, 1.99m, "per pound", 6), new(131, "Watercress", null, 3.99m, "per bunch", 6), new(132, "Romaine Lettuce", null, 2.49m, "per head", 6), new(133, "Cilantro", null, 0.99m, "per bunch", 6), new(134, "Parsley", null, 0.99m, "per bunch", 6), new(135, "Dandelion Greens", null, 2.99m, "per bunch", 6), new(136, "Green Leaf Lettuce", null, 1.99m, "per head", 6), new(137, "Red Leaf Lettuce", null, 1.99m, "per head", 6), new(138, "Iceberg Lettuce", null, 1.49m, "per head", 6), new(139, "Endive", null, 2.49m, "per bunch", 6), new(140, "Kohlrabi", null, 1.99m, "per pound", 6), new(141, "Mizuna", null, 2.49m, "per bunch", 6)
            };
            products.AddRange(leafyVegetables);

            var seasonalFruits = new List<Product>
            {
                new(142, "Strawberries", null, 2.99m, "per pound", 2), new(143, "Blueberries", null, 3.99m, "per pound", 2), new(144, "Raspberries", null, 4.99m, "per pound", 2), new(145, "Blackberries", null, 3.99m, "per pound", 2), new(146, "Watermelon", null, 0.39m, "per pound", 2), new(147, "Cantaloupe", null, 1.99m, "each", 2), new(148, "Honeydew", null, 2.49m, "each", 2), new(149, "Peaches", null, 1.99m, "per pound", 2), new(150, "Plums", null, 2.99m, "per pound", 2), new(151, "Apricots", null, 2.99m, "per pound", 2), new(152, "Nectarines", null, 3.49m, "per pound", 2), new(153, "Cherries", null, 4.99m, "per pound", 2), new(154, "Grapes", null, 2.99m, "per pound", 2), new(155, "Oranges", null, 0.99m, "per pound", 2), new(156, "Mangoes", null, 1.99m, "each", 2), new(157, "Pineapple", null, 2.99m, "each", 2), new(158, "Pears", null, 2.99m, "per pound", 2), new(159, "Apples", null, 1.99m, "per pound", 2), new(160, "Kiwi", null, 0.99m, "each", 2), new(161, "Limes", null, 0.49m, "each", 2)
            };
            products.AddRange(seasonalFruits);

            var exoticFruits = new List<Product>
            {
                new(162, "Dragon Fruit", null, 4.99m, "each", 3), new(163, "Mangosteen", null, 6.99m, "per pound", 3), new(164, "Rambutan", null, 5.49m, "per pound", 3), new(165, "Durian", null, 9.99m, "each", 3), new(166, "Kiwano (Horned Melon)", null, 3.99m, "each", 3), new(167, "Cherimoya", null, 6.99m, "each", 3), new(168, "Pitahaya (Dragon Fruit)", null, 5.99m, "each", 3), new(169, "Physalis", null, 4.99m, "per pound", 3), new(170, "Passion Fruit", null, 4.99m, "per pound", 3), new(171, "Kumquat", null, 3.99m, "per pound", 3), new(172, "Mamey Sapote", null, 6.99m, "each", 3), new(173, "Papaya", null, 3.99m, "each", 3), new(174, "Jabuticaba", null, 7.99m, "per pound", 3), new(175, "Salak (Snake Fruit)", null, 8.99m, "per pound", 3), new(176, "Guava", null, 3.99m, "per pound", 3), new(177, "Lychee", null, 5.99m, "per pound", 3), new(178, "Starfruit", null, 4.99m, "each", 3), new(179, "Carambola (Star Fruit)", null, 4.99m, "each", 3), new(180, "Pomelo", null, 5.99m, "each", 3), new(181, "Feijoa", null, 4.99m, "per pound", 3), new(182, "Custard Apple", null, 6.99m, "each", 3), new(183, "Jackfruit", null, 6.99m, "per pound", 3), new(184, "Longan", null, 5.99m, "per pound", 3), new(185, "Açai", null, 9.99m, "per pound", 3), new(186, "Soursop", null, 7.99m, "per pound", 3), new(187, "Pepino Melon", null, 3.99m, "each", 3), new(188, "Mango", null, 4.99m, "each", 3), new(189, "Avocado", null, 3.99m, "each", 3), new(190, "Persimmon", null, 4.99m, "each", 3), new(191, "Banana Passionfruit", null, 6.99m, "per pound", 3), new(192, "Cactus Pear", null, 3.99m, "each", 3), new(193, "Pitaya (Dragon Fruit)", null, 5.99m, "each", 3), new(194, "African Horned Cucumber", null, 4.99m, "each", 3), new(195, "Star Apple", null, 6.99m, "each", 3), new(196, "Barbados Cherry", null, 5.99m, "per pound", 3), new(197, "Cupuaçu", null, 7.99m, "each", 3), new(198, "Atemoya", null, 7.99m, "each", 3), new(199, "Sapodilla", null, 6.99m, "each", 3), new(200, "Cupuacu", null, 7.99m, "each", 3), new(201, "Feijoa", null, 4.99m, "per pound", 3), new(202, "Black Sapote", null, 7.99m, "each", 3), new(203, "Breadfruit", null, 4.99m, "each", 3), new(204, "Canistel", null, 6.99m, "each", 3), new(205, "Soursop", null, 7.99m, "per pound", 3), new(206, "Jujube", null, 5.99m, "per pound", 3), new(207, "Marula", null, 8.99m, "each", 3), new(208, "Ugli Fruit", null, 4.99m, "each", 3), new(209, "Mango", null, 4.99m, "each", 3), new(210, "Avocado", null, 3.99m, "each", 3), new(211, "Persimmon", null, 4.99m, "each", 3), new(212, "Banana Passionfruit", null, 6.99m, "per pound", 3), new(213, "Cactus Pear", null, 3.99m, "each", 3), new(214, "Pitaya (Dragon Fruit)", null, 5.99m, "each", 3), new(215, "African Horned Cucumber", null, 4.99m, "each", 3), new(216, "Star Apple", null, 6.99m, "each", 3), new(217, "Barbados Cherry", null, 5.99m, "per pound", 3), new(218, "Cupuaçu", null, 7.99m, "each", 3), new(219, "Atemoya", null, 7.99m, "each", 3), new(220, "Sapodilla", null, 6.99m, "each", 3), new(221, "Cupuacu", null, 7.99m, "each", 3), new(222, "Feijoa", null, 4.99m, "per pound", 3), new(223, "Black Sapote", null, 7.99m, "each", 3), new(224, "Breadfruit", null, 4.99m, "each", 3), new(225, "Canistel", null, 6.99m, "each", 3), new(226, "Soursop", null, 7.99m, "per pound", 3), new(227, "Jujube", null, 5.99m, "per pound", 3), new(228, "Marula", null, 8.99m, "each", 3), new(229, "Ugli Fruit", null, 4.99m, "each", 3)
            };
            products.AddRange(exoticFruits);

            var fruitsAndVegetables = new List<Product>
            {
                new(300, "Apple", null, 1.99m, "per pound", 1), new(301, "Pear", null, 2.49m, "per pound", 1), new(302, "Plum", null, 1.79m, "per pound", 1), new(303, "Cherry", null, 4.99m, "per pound", 1), new(304, "Apricot", null, 3.49m, "per pound", 1), new(305, "Peach", null, 2.99m, "per pound", 1), new(306, "Watermelon", null, 4.99m, "each", 1), new(307, "Pineapple", null, 3.99m, "each", 1), new(308, "Mango", null, 2.79m, "each", 1), new(309, "Avocado", null, 1.49m, "each", 1), new(310, "Cantaloupe", null, 3.99m, "each", 1), new(311, "Grapefruit", null, 1.49m, "each", 1), new(312, "Raspberry", null, 3.99m, "per pound", 1), new(313, "Blueberry", null, 3.99m, "per pound", 1), new(314, "Blackberry", null, 4.49m, "per pound", 1), new(315, "Strawberry", null, 2.99m, "per pound", 1), new(316, "Currant", null, 4.99m, "per pound", 1), new(317, "Fig", null, 2.99m, "per pound", 1), new(318, "Grapes", null, 2.49m, "per pound", 1), new(319, "Kiwi", null, 0.99m, "each", 1), new(320, "Mandarin", null, 2.99m, "per pound", 1), new(321, "Orange", null, 0.99m, "per pound", 1), new(322, "Lemon", null, 0.69m, "per pound", 1), new(323, "Passion Fruit", null, 4.99m, "per pound", 1), new(324, "Pomegranate", null, 3.99m, "each", 1), new(325, "Papaya", null, 2.99m, "each", 1), new(326, "Pomegranate", null, 3.99m, "each", 1), new(327, "Red Currant", null, 4.99m, "per pound", 1), new(328, "Tomato", null, 0.99m, "per pound", 1), new(329, "Cucumber", null, 0.79m, "each", 4), new(330, "Zucchini", null, 0.89m, "per pound", 4), new(331, "Carrot", null, 0.99m, "per pound", 4), new(332, "Broccoli", null, 1.29m, "per pound", 4), new(333, "Spinach", null, 1.99m, "per pound", 4), new(334, "Lettuce", null, 1.49m, "per pound", 4), new(335, "Onion", null, 0.79m, "per pound", 4), new(336, "Potato", null, 0.69m, "per pound", 4), new(337, "Bell Pepper", null, 1.19m, "per pound", 4), new(338, "Eggplant", null, 1.59m, "each", 4), new(339, "Asparagus", null, 2.99m, "per pound", 4), new(340, "Celery", null, 0.99m, "per pound", 4), new(341, "Cauliflower", null, 1.79m, "each", 4), new(342, "Green Bean", null, 2.29m, "per pound", 4), new(343, "Cabbage", null, 0.99m, "per pound", 4), new(344, "Corn", null, 0.59m, "each", 4)
            };
            products.AddRange(fruitsAndVegetables);

            return products;
        }

        internal static readonly Expression<Func<Product, ProductDto>> DtoSelector =
            p => new ProductDto(p.Id, p.Name, p.Image, p.Price, p.Unit, p.CategoryId);
    }
}
